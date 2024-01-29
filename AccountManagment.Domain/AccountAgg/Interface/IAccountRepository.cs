using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using ZeroFramework.Domain.BaseInterface;

namespace AccountManagment.Domain.AccountAgg.Interface
{
    public interface IAccountRepository : IBaseRepository<long, Account>
    {
        Account GetBy(string username);
        EditAccount GetDetails(long id);
        List<AccountViewModel> GetAccounts();
        List<AccountViewModel> Search(AccountSearchModel searchModel);
    }
}
