using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using ZeroFramework.Application.Common;

namespace AccountManagment.Application.Contracts.RoleAppContract.Interface
{
    public interface IRoleApplication
    {
        OperationResult Create(CreateRole command);
        OperationResult Edit(EditRole command);
        List<RoleViewModel> List();
        EditRole GetDetails(int id);
    }
}
