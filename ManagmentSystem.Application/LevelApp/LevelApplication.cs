using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.LevelAgg.Interface;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.LevelApp
{
    public class LevelApplication : ILevelApplication
    {
        private readonly ILevelRepository _levelRepository;

        public LevelApplication(ILevelRepository levelRepository)
        {
            _levelRepository = levelRepository;
        }

        public OperationResult AddLevel(AddLevelItem entity)
        {
            var result = new OperationResult();
            var level = new Level(entity.Name, entity.Type,entity.Fee, entity.Description);
            _levelRepository.Create(level);
            _levelRepository.SaveChanges();
            return result.Succeeded();
        }

        public OperationResult EditLevel(EditLevelItem entity)
        {
            var operation = new OperationResult();
            var level = _levelRepository.Get(entity.Id);
            if (level == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            level.Edit(entity.Name, entity.Type, entity.Fee, entity.Description);
            _levelRepository.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult DeleteLevel(int id)
        {
            OperationResult result = new OperationResult();
            var level = _levelRepository.Get(id);
            if (level == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            level.Remove();
            _levelRepository.SaveChanges();
            return result.Succeeded();
        }

        public OperationResult RestoreLevel(int id)
        {
            OperationResult result = new OperationResult();
            var level = _levelRepository.Get(id);
            if (level == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            level.Restore();
            _levelRepository.SaveChanges();
            return result.Succeeded();
        }

        public List<GetAllLevelItems> GetAllLevels()
        {
          return _levelRepository.GetAllLevels();
        }

        public EditLevelItem GetLevelItemDetail(int id)
        {
            return _levelRepository.GetLevelItemDetails(id);
        }

        public List<GetAllLevelItems> GetUnDeletedLevels()
        {
            return _levelRepository.GetUnDeletedLevels();
        }
    }
}
