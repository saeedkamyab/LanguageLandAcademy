using ManagmentSystem.Application.Contract.Tuition.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain.BaseInterface;

namespace ManagmentSystem.Domain.TuitionAgg.Interface
{
    public interface ITuitionRepository:IBaseRepository<long,Tuition>
    {
        List<AllTuitions> GetAllTuitions();
        List<AllTuitions> GetAllTuitionsByStId(long id);

    }
}
