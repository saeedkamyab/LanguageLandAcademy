using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using ZeroFramework.Domain.BaseInterface;

namespace AccountManagment.Domain.RoleAgg.Interface
{
    public interface IRoleRepository:IBaseRepository<int,Role>
    {
        List<RoleViewModel> List();
        EditRole GetDetails(int id);
    }
}
