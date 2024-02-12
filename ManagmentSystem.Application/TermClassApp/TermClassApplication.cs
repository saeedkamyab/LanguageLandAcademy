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

        public OperationResult CreateTermClass(CreateTermClass entity)
        {
            var operation = new OperationResult();
            var termClass = new TermClass(entity.StartTime,entity.EndTime,
                entity.Day,entity.Description,entity.LevelId,entity.RoomId,new List<Person>());
            _tcRepo.Create(termClass);
            _tcRepo.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult DeleteTermClass(RemoveTermClassItem entity)
        {
            throw new NotImplementedException();
        }

        public List<GetAllTermClassItems> GetAllTermClass()
        {
          return _tcRepo.getAllTermClasses();
        }

        public EditTermClass GetDetails(int id)
        {
            return _tcRepo.GetDetails(id);
        }

        public OperationResult RestoreTermClass(RestoreTermClassItem entity)
        {
            throw new NotImplementedException();
        }

        public OperationResult UpdateTermClass(EditTermClass entity)
        {
            throw new NotImplementedException();
        }
    }
}
