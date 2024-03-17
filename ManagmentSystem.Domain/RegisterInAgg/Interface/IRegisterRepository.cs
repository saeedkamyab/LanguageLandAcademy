using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Application.Contract.RegisterIn.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain.BaseInterface;

namespace ManagmentSystem.Domain.RegisterInAgg.Interface
{
    public interface IRegisterRepository:IBaseRepository<long, Register>
    {

        List<GetAllRegisteration> GetAllRegisteration();

        EditRegisteration GetRegisterationEditDetails(long id);

        List<GetAllRegisteration> GetUnDeletedRegisteration();

        List<GetAllRegisteration> GetReByTcId(long id);

        RegisterationViewModel GetRegisterationItemDetails(long id);
    }
}
