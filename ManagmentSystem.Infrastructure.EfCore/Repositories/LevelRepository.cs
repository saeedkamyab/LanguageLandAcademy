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
using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;

namespace ManagmentSystem.Infrastructure.EfCore.Repositories
{
    public class LevelRepository : RepositoryBase<int, Level>, ILevelRepository
    {
        private readonly ManagmentSystemContext _context;

        public LevelRepository(ManagmentSystemContext context) : base(context)
        {
            _context = context;
        }
        public List<GetAllLevelItems> GetAllLevels()
        {
            return _context.Levels.Select(le => new GetAllLevelItems
            {
                Id = le.Id,
                Name = le.Name,
                CreationDate = le.CreateDate.ToString(),
                Description = le.Description,
                Type = le.Type,
                Fee = le.Fee,
                IsRemoved = le.IsRemoved,
                LastUpdate = le.LastUpdate.ToString()
            }).ToList();
        }

        public EditLevelItem GetLevelItemDetails(int id)
        {
            return _context.Levels.Select(x => new EditLevelItem
            {
                Id = x.Id,
                Name = x.Name,
                Fee = x.Fee,
                Type = x.Type,
                Description = x.Description,
            }).FirstOrDefault(x => x.Id == id);

        }
    }
}
