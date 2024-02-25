using ManagmentSystem.Application.Contract.AbsentPresent.ViewModels;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using ZeroFramework.Application.Common;
namespace ManagmentSystem.Application.Contract.AbsentPresent.Interface
{
    public interface IAbsentPresentApplication
    {

        List<GetAllAbPreItems> GetAllAbPre();
        
        EditAbPreItem GetAbPreItemDetail(long id);

        OperationResult AddAbPre(AddAbPreItem entity);

        OperationResult EditAbPre(EditAbPreItem entity);

        OperationResult Absent(long id);

        OperationResult Present(long id);

    }
}
