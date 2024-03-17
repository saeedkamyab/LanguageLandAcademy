using ManagmentSystem.Domain.LevelAgg.Interface;
using ManagmentSystem.Domain.LevelAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Infrastructure;
using ManagmentSystem.Domain.HomeworksExams;
using ManagmentSystem.Domain.HomeworksExams.Interface;

namespace ManagmentSystem.Infrastructure.EfCore.Repositories
{
    public class HomeworkExamRepository : RepositoryBase<int, HomeworkExam>, IHomeworkExamRepository
    {
        private ManagmentSystemContext _context;

        public HomeworkExamRepository(ManagmentSystemContext context):base(context) 
        {
            _context = context;
        }
    }
}
