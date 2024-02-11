using ManagmentSystem.Application.Contract.Level.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.LevelAgg.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public OperationResult CreateLevel(AddLevelItem entity)
        {
            var result = new OperationResult();
            var level = new Level(entity.LevelName, entity.LevelType, entity.LevelDescription);
            _levelRepository.Create(level);
            _levelRepository.SaveChanges();
            return result.Succeeded();
        }

        public OperationResult DeleteLevel(RemoveLevelItem entity)
        {
            throw new NotImplementedException();
        }


        public List<GetAllLevelItems> GetAllLevels()
        {
          return _levelRepository.getAllLevels();
        }

        public OperationResult RestoreLevel(RestoreLevelItem entity)
        {
            throw new NotImplementedException();
        }

        public OperationResult UpdateLevel(EditLevelItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
