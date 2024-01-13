using ManagmentSystem.Application.Contract.Tuition.Interface;
using ManagmentSystem.Application.Contract.Tuition.ViewModels;
using ManagmentSystem.Domain.TuitionAgg;
using ManagmentSystem.Domain.TuitionAgg.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.TuitionApp
{
    public class TuitionApplication : ITuitionApplication
    {
        private readonly ITuitionRepository _tuRep;

        public TuitionApplication(ITuitionRepository tuitionRepository)
        {
            _tuRep = tuitionRepository;
        }

        public OperationResult CreateTuition(CreateTuition createTuition)
        {
           var operation= new OperationResult();
            var tuition=new Tuition(createTuition.FinanceAmount,createTuition.FinanceStatus,
                createTuition.FinanceDescription);
            _tuRep.Create(tuition);
            _tuRep.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult EditTuition(EditTuition editTuition)
        {
            var operation = new OperationResult();
            var tuition = _tuRep.Get(editTuition.Id);
            if (tuition == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            tuition.Edit(editTuition.FinanceAmount, editTuition.FinanceStatus,editTuition.FinanceDescription);
            _tuRep.SaveChanges();
            return operation.Succeeded();
        }

        public List<GetAllTuitions> GetAllTuitions()
        {
            return _tuRep.GetAllTuitions();
        }

      
    }
}
