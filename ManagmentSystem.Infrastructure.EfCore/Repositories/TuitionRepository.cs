using ManagmentSystem.Application.Contract.Tuition.ViewModels;
using ManagmentSystem.Domain.TuitionAgg;
using ManagmentSystem.Domain.TuitionAgg.Interface;
using ZeroFramework.Infrastructure;

namespace ManagmentSystem.Infrastructure.EfCore.Repositories
{
    public class TuitionRepository : RepositoryBase<long, Tuition>, ITuitionRepository
    {
        private readonly ManagmentSystemContext _context;

        public TuitionRepository(ManagmentSystemContext context) : base(context)
        {
            _context = context;
        }

        public List<AllTuitions> GetAllTuitions()
        {
            return _context.Tuitions.Select(tu => new AllTuitions
            {
                Id = tu.Id,
                OwnerId = tu.OwnerId,
                CreateDate = tu.CreateDate.ToString(),
                TuitionAmount = tu.TuitionAmount,
                TuitionDescription = tu.TuitionDescription,
                TuitionPayDate = tu.TuitionPayDate.ToString(),
                TuitionStatus = tu.TuitionStatus,
                IsRemoved = tu.IsRemoved,
                LastUpdate = tu.LastUpdate.ToString()
            }).ToList();
            //throw new NotImplementedException();
        }

     
    }
}
