using ManagmentSystem.Application.Contract.Level.ViewModels;
using ZeroFramework.Application.Common;
namespace ManagmentSystem.Application.Contract.HomeworkExams.Interface
{
    public interface IHomeworkExamApplication
    {

        List<GetAllLevelItems> GetAllLevels();
        
        List<GetAllLevelItems> GetUnDeletedLevels();

        EditLevelItem GetLevelItemDetail(int id);

        OperationResult AddLevel(AddLevelItem entity);

        OperationResult EditLevel(EditLevelItem entity);

        OperationResult DeleteLevel(int id);

        OperationResult RestoreLevel(int id);

    }
}
