using ZeroFramework.Infrastructure;
using ManagmentSystem.Domain.PresentAbsentAgg.Interface;
using System.Linq.Expressions;
using ZeroFramework.Domain.BaseInterface;
using ManagmentSystem.Domain.PresentAbsentAgg;

namespace ManagmentSystem.Infrastructure.EfCore.Repositories
{
    public class AbsentPresentRepository : RepositoryBase<long, AbsentPresent>, IAbsentPresentRepository
    {
        private readonly ManagmentSystemContext _context;

        public AbsentPresentRepository(ManagmentSystemContext context) : base(context)
        {
            _context = context;
        }

        public void Create(Domain.PresentAbsentAgg.AbsentPresent entity)
        {
            throw new NotImplementedException();
        }

        public void CreateRange(List<Domain.PresentAbsentAgg.AbsentPresent> entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Domain.PresentAbsentAgg.AbsentPresent entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Domain.PresentAbsentAgg.AbsentPresent, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.PresentAbsentAgg.AbsentPresent entity)
        {
            throw new NotImplementedException();
        }

        Domain.PresentAbsentAgg.AbsentPresent IBaseRepository<long, Domain.PresentAbsentAgg.AbsentPresent>.Get(long Id)
        {
            throw new NotImplementedException();
        }

        List<Domain.PresentAbsentAgg.AbsentPresent> IBaseRepository<long, Domain.PresentAbsentAgg.AbsentPresent>.GetAll()
        {
            throw new NotImplementedException();
        }
        //public List<GetAllLevelItems> GetAllLevels()
        //{
        //    return _context.Levels.Select(le => new GetAllLevelItems
        //    {
        //        Id = le.Id,
        //        Name = le.Name,
        //        CreationDate = le.CreateDate.ToString(),
        //        Description = le.Description,
        //        Type = le.Type,
        //        Fee = le.Fee,
        //        IsRemoved = le.IsRemoved,
        //        LastUpdate = le.LastUpdate.ToString()
        //    }).ToList();
        //}

        //public EditLevelItem GetLevelItemDetails(int id)
        //{
        //    return _context.Levels.Select(x => new EditLevelItem
        //    {
        //        Id = x.Id,
        //        Name = x.Name,
        //        Fee = x.Fee,
        //        Type = x.Type,
        //        Description = x.Description,
        //    }).FirstOrDefault(x => x.Id == id);

        //}

        //public List<GetAllLevelItems> GetUnDeletedLevels()
        //{
        //    return _context.Levels.Select(le => new GetAllLevelItems
        //    {
        //        Id = le.Id,
        //        Name = le.Name,
        //        CreationDate = le.CreateDate.ToString(),
        //        Description = le.Description,
        //        Type = le.Type,
        //        Fee = le.Fee,
        //        IsRemoved = le.IsRemoved,
        //        LastUpdate = le.LastUpdate.ToString()
        //    }).Where(x => x.IsRemoved == false).ToList();
        //}
    }
}
