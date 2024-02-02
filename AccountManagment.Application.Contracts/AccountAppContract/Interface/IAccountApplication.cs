using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using ZeroFramework.Application.Common;

namespace AccountManagment.Application.Contracts.AccountAppContract.Interface
{
    public interface IAccountApplication
    {
        void Logout();

        EditAccount GetDetails(long id);

        OperationResult Login(Login command);

        List<AccountViewModel> GetAccounts();

        AccountViewModel GetAccountBy(long id);

        OperationResult Edit(EditAccount command);

        OperationResult Register(RegisterAccount command);

        List<AccountViewModel> Search(AccountSearchModel searchModel);
    
    }
}
