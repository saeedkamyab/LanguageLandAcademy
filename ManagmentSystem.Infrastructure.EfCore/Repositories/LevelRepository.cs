using ManagmentSystem.Domain.TuitionAgg.Interface;
using ManagmentSystem.Domain.TuitionAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Infrastructure;
using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.LevelAgg.Interface;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Application.Contract.Tuition.ViewModels;

namespace ManagmentSystem.Infrastructure.EfCore.Repositories
{
    public class LevelRepository : RepositoryBase<int, Level>, ILevelRepository
    {
        private readonly ManagmentSystemContext _context;

        public LevelRepository(ManagmentSystemContext context) : base(context)
        {
            _context = context;
        }

        public List<GetAllLevelItems> getAllLevels()
        {
            return _context.Levels.Select(le => new GetAllLevelItems
            {
                Id = le.Id,
                LevelName = le.LevelName,
                CreationDate = le.CreateDate.ToString(),
                LevelDescription = le.LevelDescription,
                LevelType = le.LevelType,
                LastUpdate = le.LastUpdate.ToString()
            }).ToList();
        }
    }
}
