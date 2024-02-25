using ManagmentSystem.Application.Contract.AbsentPresent.Interface;
using ManagmentSystem.Application.Contract.AbsentPresent.ViewModels;
using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.LevelAgg.Interface;
using ManagmentSystem.Domain.PresentAbsentAgg.Interface;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.AbsentPresentApp
{
    public class AbsentPresentApplication : IAbsentPresentApplication
    {
        private readonly IAbsentPresentRepository _AbPreRepository;

        public AbsentPresentApplication(IAbsentPresentRepository AbPreRepository)
        {
            _AbPreRepository = AbPreRepository;
        }



        public List<GetAllAbPreItems> GetAllAbPre()
        {
            throw new NotImplementedException();
        }

        public EditAbPreItem GetAbPreItemDetail(long id)
        {
            throw new NotImplementedException();
        }

        public OperationResult AddAbPre(AddAbPreItem entity)
        {
            throw new NotImplementedException();
        }

        public OperationResult EditAbPre(EditAbPreItem entity)
        {
            throw new NotImplementedException();
        }

        public OperationResult Absent(long id)
        {
            throw new NotImplementedException();
        }

        public OperationResult Present(long id)
        {
            throw new NotImplementedException();
        }
















        //public OperationResult AddLevel(AddLevelItem entity)
        //{
        //    var result = new OperationResult();
        //    var level = new Level(entity.Name, entity.Type,entity.Fee, entity.Description);
        //    _levelRepository.Create(level);
        //    _levelRepository.SaveChanges();
        //    return result.Succeeded();
        //}

        //public OperationResult EditLevel(EditAbPreItem entity)
        //{
        //    var operation = new OperationResult();
        //    var level = _levelRepository.Get(entity.Id);
        //    if (level == null)
        //        return operation.Failed(ApplicationMessages.RecordNotFound);
        //    level.Edit(entity.Name, entity.Type, entity.Fee, entity.Description);
        //    _levelRepository.SaveChanges();
        //    return operation.Succeeded();
        //}

        //public OperationResult DeleteLevel(int id)
        //{
        //    OperationResult result = new OperationResult();
        //    var level = _levelRepository.Get(id);
        //    if (level == null)
        //        return result.Failed(ApplicationMessages.RecordNotFound);
        //    level.Remove();
        //    _levelRepository.SaveChanges();
        //    return result.Succeeded();
        //}

        //public OperationResult RestoreLevel(int id)
        //{
        //    OperationResult result = new OperationResult();
        //    var level = _levelRepository.Get(id);
        //    if (level == null)
        //        return result.Failed(ApplicationMessages.RecordNotFound);
        //    level.Restore();
        //    _levelRepository.SaveChanges();
        //    return result.Succeeded();
        //}

        //public List<GetAllLevelItems> GetAllLevels()
        //{
        //  return _levelRepository.GetAllLevels();
        //}

        //public EditAbPreItem GetLevelItemDetail(int id)
        //{
        //    return _levelRepository.GetLevelItemDetails(id);
        //}

        //public List<GetAllLevelItems> GetUnDeletedLevels()
        //{
        //    return _levelRepository.GetUnDeletedLevels();
        //}

    }
}
