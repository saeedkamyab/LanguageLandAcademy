using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.Contract.TermClass.Interface
{
    public interface ITermClassApplication
    {
        List<GetAllTermClassItems> GetAllTermClass();
        
        EditTermClass GetDetails(int id);

        OperationResult CreateTermClass(CreateTermClass entity);

        OperationResult UpdateTermClass(EditTermClass entity);

        OperationResult DeleteTermClass(RemoveTermClassItem entity);

        OperationResult RestoreTermClass(RestoreTermClassItem entity);

    }
}
