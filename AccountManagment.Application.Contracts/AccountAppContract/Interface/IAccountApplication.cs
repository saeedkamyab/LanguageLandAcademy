using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Application.Common;

namespace AccountManagment.Application.Contracts.AccountAppContract.Interface
{
    public interface IAccountApplication
    {
        //AccountViewModel GetAccountBy(long id);
        OperationResult Register(RegisterAccount command);
        //OperationResult Edit(EditAccount command);
        //OperationResult ChangePassword(ChangePassword command);
        //OperationResult Login(Login command);
        //EditAccount GetDetails(long id);
        //List<AccountViewModel> Search(AccountSearchModel searchModel);
        //void Logout();
        //List<AccountViewModel> GetAccounts();
    }
}
