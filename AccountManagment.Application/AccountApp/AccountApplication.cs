using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using AccountManagment.Domain.AccountAgg.Interface;
using AccountManagment.Domain.AccountAgg;
using ZeroFramework.Application.Common;
using AccountManagment.Domain.RoleAgg.Interface;

namespace AccountManagment.Application.AccountApp
{
    public class AccountApplication : IAccountApplication
    {
        private readonly IPasswordHasher _passHasher;
        private readonly IFileUploader _fileUploader;
        private readonly IAccountRepository _accountRep;
        private readonly IRoleRepository _roleRep;
        private readonly IAuthHelper _authHelper;
       
        public AccountApplication(IPasswordHasher passHasher, IFileUploader fileUploader,
            IAccountRepository accountRep, IRoleRepository roleRep, IAuthHelper authHelper)
        {
            //_passHasher = passHasher;
            _fileUploader = fileUploader;
            _accountRep = accountRep;
            _roleRep = roleRep;
            _authHelper = authHelper;
        }

        public OperationResult Register(RegisterAccount command)
        {
            OperationResult result = new OperationResult();

            var username = UsNPassGenerator.GenerateUserName();
            var pass =UsNPassGenerator.GeneratePass(command.NationalCode);

            var account = new Account(command.FullName, command.FName,
                command.NationalCode, command.Gender, null, null, command.RoleId,
                username, pass, command.Description);

            _accountRep.Create(account);
            _accountRep.SaveChanges();
            return result.Succeeded();
        }
        public OperationResult ChangePassword(ChangePassword command)
        {
            var operation = new OperationResult();
            var account = _accountRep.Get(command.Id);
            if (account == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (command.Password != command.RePassword)
                return operation.Failed(ApplicationMessages.PasswordsNotMatch);

            var password = _passHasher.Hash(command.Password);
        
            account.ChangePassword(password);
            _accountRep.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult Edit(EditAccount command)
        {
            var operation = new OperationResult();
            var account = _accountRep.Get(command.Id);
            if (account == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_accountRep.Exists(x =>
                (x.UserName == command.UserName) && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var path = $"profilePhotos";

            var picturePath = _fileUploader.Upload(command.ProfilePhoto, path);
    
          
            account.Edit(command.FullName, command.UserName,command.FName
                ,command.NationalCode,command.Gender,command.Address, command.RoleId, picturePath,command.Description);
            _accountRep.SaveChanges();
            return operation.Succeeded();
        }

        public AccountViewModel GetAccountBy(long id)
        {
            var account = _accountRep.Get(id);
            return new AccountViewModel()
            {
                FullName = account.FullName
            };
        }

        public List<AccountViewModel> GetAccounts()
        {
            return _accountRep.GetAccounts();
        }

        public EditAccount GetDetails(long id)
        {
            return _accountRep.GetDetails(id);
        }

        public OperationResult Login(Login command)
        {
            var operation = new OperationResult();
            var account = _accountRep.GetBy(command.Username);
            if (account == null)
                return operation.Failed(ApplicationMessages.WrongUserPass);

            //var result = account.Password, command.Password;
            ////var result = _passHasher.Check(account.Password, command.Password);
            //if (!result.Verified)
            //    return operation.Failed(ApplicationMessages.WrongUserPass);

            var permissions = _roleRep.Get(account.RoleId)
                .Permissions
                .Select(x => x.Code)
                .ToList();

            var authViewModel = new AuthViewModel(account.Id, account.RoleId, account.FullName
                , account.UserName,  permissions);

            _authHelper.Signin(authViewModel);
            return operation.Succeeded();
        }

        public void Logout()
        {
            _authHelper.SignOut();
        }



        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            return _accountRep.Search(searchModel);
        }
    }
}
