using AccountManagment.Application.Contracts.RoleAppContract.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain.BaseInterface;

namespace AccountManagment.Domain.RoleAgg.Interface
{
    public interface IRoleRepository:IBaseRepository<int,Role>
    {
        List<RoleViewModel> List();
        EditRole GetDetails(long id);
    }
}
