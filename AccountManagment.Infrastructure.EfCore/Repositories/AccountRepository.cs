using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using AccountManagment.Domain.AccountAgg;
using AccountManagment.Domain.AccountAgg.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Infrastructure;

namespace AccountManagment.Infrastructure.EfCore.Repositories
{
    public class AccountRepository : RepositoryBase<long, Account>, IAccountRepository
    {
        private readonly AccountManagmentContext _acMaContext;

        public AccountRepository(AccountManagmentContext acMaContext):base(acMaContext) 
        {
            _acMaContext = acMaContext;
        }

        public List<AccountViewModel> GetAccounts()
        {
            throw new NotImplementedException();
        }

        public Account GetBy(string username)
        {
            throw new NotImplementedException();
        }

        public EditAccount GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
