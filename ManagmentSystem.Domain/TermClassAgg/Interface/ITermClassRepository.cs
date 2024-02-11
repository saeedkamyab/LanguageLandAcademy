using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using ZeroFramework.Domain.BaseInterface;

namespace ManagmentSystem.Domain.TermClassAgg.Interface
{
    public interface ITermClassRepository:IBaseRepository<long, TermClass>
    {
        List<GetAllTermClassItems> getAllTermClasses();
        EditTermClass GetDetails(int id);
    }
}
