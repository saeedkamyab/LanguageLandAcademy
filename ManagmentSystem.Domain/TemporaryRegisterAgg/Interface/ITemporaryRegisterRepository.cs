using ManagmentSystem.Application.Contract.TemporaryRegister.ViewModels;
using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain.BaseInterface;

namespace ManagmentSystem.Domain.TemporaryRegisterAgg.Interface
{
    public interface ITemporaryRegisterRepository:IBaseRepository<int,TemporaryRegister>
    {
        List<AllTemporaryRegister> GetAllTeRegister();
        EditTemporaryRegister GetDetails(int id);
    }
}
