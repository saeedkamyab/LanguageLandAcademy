using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain.BaseInterface;

namespace ManagmentSystem.Domain.HomeworksExams.Interface
{
    public interface IHomeworkExamRepository : IBaseRepository<int, HomeworkExam>
    {
    }
}
