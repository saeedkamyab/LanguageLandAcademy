using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using ManagmentSystem.Application.Contract.Level.ViewModels;

using ZeroFramework.Domain.BaseInterface;

namespace ManagmentSystem.Domain.PresentAbsentAgg.Interface
{
    public interface IAbsentPresentRepository:IBaseRepository<long,AbsentPresent>
    {
    

    }
}
