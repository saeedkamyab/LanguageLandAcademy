using AccountManagment.Application.Contracts.AccountAppContract.Interface;
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using AccountManagment.Domain.AccountAgg.Interface;
using AccountManagment.Domain.AccountAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Application.Common;

namespace AccountManagment.Application.AccountApp
{
    public class AccountApplication : IAccountApplication
    {
        //private readonly IPasswordHasher _passHasher;
        //private readonly IFileUploader _fileUploader;
        private readonly IAccountRepository _accountRep;

        public AccountApplication(/*IPasswordHasher passHasher,*/
           /* IFileUploader fileUploader,*/ IAccountRepository accountRep)
        {
            //_passHasher = passHasher;
            //_fileUploader = fileUploader;
            _accountRep = accountRep;
        }

        public OperationResult Register(RegisterAccount command)
        {
            OperationResult result = new OperationResult();

            var username = UsNPassGenerator.GenerateUserName();
            var pass = UsNPassGenerator.GeneratePass(command.NationalCode);

            var account = new Account(command.FullName, command.FName,
                command.NationalCode, command.Gender, null, null, command.RoleId,
                username, pass, command.Description);

            _accountRep.Create(account);
            _accountRep.SaveChanges();
            return result.Succeeded();
        }






        //public OperationResult ChangePassword(ChangePassword command)
        //{
        //    throw new NotImplementedException();
        //}

        //public OperationResult Edit(EditAccount command)
        //{
        //    throw new NotImplementedException();
        //}

        //public AccountViewModel GetAccountBy(long id)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<AccountViewModel> GetAccounts()
        //{
        //    throw new NotImplementedException();
        //}

        //public EditAccount GetDetails(long id)
        //{
        //    throw new NotImplementedException();
        //}

        //public OperationResult Login(Login command)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Logout()
        //{
        //    throw new NotImplementedException();
        //}



        //public List<AccountViewModel> Search(AccountSearchModel searchModel)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
