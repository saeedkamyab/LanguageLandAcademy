using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using AccountManagment.Domain.AccountAgg;
using AccountManagment.Domain.AccountAgg.Interface;
using Microsoft.EntityFrameworkCore;
using ZeroFramework.Infrastructure;

namespace AccountManagment.Infrastructure.EfCore.Repositories
{
    public class AccountRepository : RepositoryBase<long, Account>, IAccountRepository
    {
        private readonly AccountManagmentContext _acMaContext;

        public AccountRepository(AccountManagmentContext acMaContext) : base(acMaContext)
        {
            _acMaContext = acMaContext;
        }


        public Account GetBy(string username)
        {
            return _acMaContext.Accounts.FirstOrDefault(x => x.UserName == username);
        }

        public EditAccount GetDetails(long id)
        {
            //this method will get data and map them on edit model to fill
            //bind properties on view for editing

            return _acMaContext.Accounts.Select(x => new EditAccount
            {
                Id = x.Id,
                FullName = x.FullName,
                UserName = x.UserName,
                FName = x.FName,
                NationalCode = x.NationalCode,
                Address = x.Address,
                Description = x.Description,
                RoleId = x.RoleId,

            }).FirstOrDefault(x => x.Id == id);


        }

        public List<AccountViewModel> GetAccounts()
        {
            return _acMaContext.Accounts.Select(x => new AccountViewModel
            {
                Id = x.Id,
                FullName = x.FullName
            }).ToList();
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            var query = _acMaContext.Accounts.Include(x => x.Role).Select(x => new AccountViewModel
            {
                Id = x.Id,
                FullName = x.FullName,
                ProfilePhoto = x.ProfilePhoto,
                Role = x.Role.Name,
                RoleId = x.RoleId,
                UserName = x.UserName,
                CreationDate = x.CreateDate.ToString()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Fullname))
                query = query.Where(x => x.FullName.Contains(searchModel.Fullname));

            if (!string.IsNullOrWhiteSpace(searchModel.Username))
                query = query.Where(x => x.UserName.Contains(searchModel.Username));

            if (searchModel.RoleId > 0)
                query = query.Where(x => x.RoleId == searchModel.RoleId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
