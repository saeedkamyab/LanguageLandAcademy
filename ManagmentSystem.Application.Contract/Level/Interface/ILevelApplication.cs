using ManagmentSystem.Application.Contract.Level.ViewModels;
using ZeroFramework.Application.Common;
namespace ManagmentSystem.Application.Contract.Level.Interface
{
    public interface ITemporaryRegisterApplication
    {

        List<GetAllLevelItems> GetAllLevels();

        OperationResult CreateLevel(AddLevelItem entity);

        OperationResult UpdateLevel(EditLevelItem entity);

        OperationResult DeleteLevel(RemoveLevelItem entity);

        OperationResult RestoreLevel(RestoreLevelItem entity);

    }
}
