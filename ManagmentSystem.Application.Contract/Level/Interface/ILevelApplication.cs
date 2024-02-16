using ManagmentSystem.Application.Contract.Level.ViewModels;
using ZeroFramework.Application.Common;
namespace ManagmentSystem.Application.Contract.Level.Interface
{
    public interface ILevelApplication
    {

        List<GetAllLevelItems> GetAllLevels();
        
        List<GetAllLevelItems> GetUnDeletedLevels();

        EditLevelItem GetLevelItemDetail(int id);

        OperationResult AddLevel(AddLevelItem entity);

        OperationResult EditLevel(EditLevelItem entity);

        OperationResult DeleteLevel(int id);

        OperationResult RestoreLevel(int entity);

    }
}
