using AccountManagment.Infrastructure.EfCore;
using LLaQuery.Contracts.Account;

namespace LLaQuery.Queries
{
    public class AccountQuery : IAccountListQuery
    {
        private readonly AccountManagmentContext _context;

        public AccountQuery(AccountManagmentContext context)
        {
            _context = context;
        }

        public List<AccountListQueryModel> AllAccounts()
        {
            return _context.Accounts.Select(x => new AccountListQueryModel
            {
                FullName = x.FullName,
                FName = x.FName,
                NationalCode = x.NationalCode,
                ProfilePhoto = x.ProfilePhoto,
                Description = x.Description
            }).ToList();
        }
    }
}
