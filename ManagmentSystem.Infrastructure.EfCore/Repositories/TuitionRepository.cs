using ManagmentSystem.Application.Contract.Tuition.ViewModels;
using ManagmentSystem.Domain.TuitionAgg;
using ManagmentSystem.Domain.TuitionAgg.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                CreateDate = tu.CreateDate.ToString(),
                FinanceAmount = tu.FinanceAmount,
                FinanceDescription = tu.FinanceDescription,
                FinancePayDate = tu.FinancePayDate.ToString(),
                FinanceStatus = tu.FinanceStatus,
                LastUpdate = tu.LastUpdate.ToString()
            }).ToList();
            //throw new NotImplementedException();
        }
    }
}
