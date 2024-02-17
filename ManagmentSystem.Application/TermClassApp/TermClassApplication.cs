using ManagmentSystem.Application.Contract.TermClass.Interface;
using ManagmentSystem.Application.Contract.TermClass.ViewModels;
using ManagmentSystem.Domain.TermClassAgg;
using ManagmentSystem.Domain.TermClassAgg.Interface;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.TermClassApp
{
    public class TermClassApplication : ITermClassApplication
    {
        private readonly ITermClassRepository _tcRepo;

        public TermClassApplication(ITermClassRepository tcRepo)
        {
            _tcRepo = tcRepo;
        }
        public List<GetAllTermClassItems> GetAllTermClass()
        {
            return _tcRepo.getAllTermClasses();
        }

        public OperationResult CreateTermClass(CreateTermClass entity)
        {
            var operation = new OperationResult();
            var termClass = new TermClass(entity.StartTime,entity.EndTime,
                entity.Day,entity.Room,entity.StartDate,entity.EndDate,entity.Description,entity.LevelId);
            _tcRepo.Create(termClass);
            _tcRepo.SaveChanges();
            return operation.Succeeded();
        }
        public EditTermClass GetDetails(int id)
        {
            return _tcRepo.GetDetails(id);
        }
        public OperationResult UpdateTermClass(EditTermClass entity)
        {
            var operation = new OperationResult();
            var termClass = _tcRepo.Get(entity.Id);
            if (termClass == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            termClass.Edit(entity.StartTime, entity.EndTime,
                entity.Day, entity.Room, entity.StartDate, entity.EndDate,entity.Status, entity.Description, entity.LevelId);
            _tcRepo.SaveChanges();
            return operation.Succeeded();
        }
        public OperationResult DeleteTermClass(long id)
        {
            OperationResult result = new OperationResult();
            var termClass = _tcRepo.Get(id);
            if (termClass == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            termClass.Remove();
            _tcRepo.SaveChanges();
            return result.Succeeded();
        }
        public OperationResult RestoreTermClass(long id)
        {
            OperationResult result = new OperationResult();
            var termClass = _tcRepo.Get(id);
            if (termClass == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            termClass.Restore();
            _tcRepo.SaveChanges();
            return result.Succeeded();
        }

       
    }
}
