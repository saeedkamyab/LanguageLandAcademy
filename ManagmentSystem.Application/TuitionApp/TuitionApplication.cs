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

        public OperationResult CreateTuition(CreateRoom createTuition)
        {
            var operation = new OperationResult();
            var tuition = new Tuition(createTuition.TuitionAmount,
                createTuition.TuitionDescription,createTuition.TuitionOwner);
            _tuRep.Create(tuition);
            _tuRep.SaveChanges();
            return operation.Succeeded();
        }

        public OperationResult EditTuition(EditRoom editTuition)
        {
            var operation = new OperationResult();
            var tuition = _tuRep.Get(editTuition.Id);
            if (tuition == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            tuition.Edit(editTuition.TuitionAmount, editTuition.TuitionStatus, editTuition.TuitionDescription);
            _tuRep.SaveChanges();
            return operation.Succeeded();
        }

        public List<AllTuitions> GetAllTuitions()
        {
            return _tuRep.GetAllTuitions();
        }

        public OperationResult PayTuition(long Id)
        {
            OperationResult result = new OperationResult();
            var tui = _tuRep.Get(Id);
            if (tui == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            tui.Pay();
            _tuRep.SaveChanges();
            return result.Succeeded();
        }

        public OperationResult RemoveTuition(long Id)
        {
            OperationResult result = new OperationResult();
            var tui = _tuRep.Get(Id);
            if (tui == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            tui.Remove();
            _tuRep.SaveChanges();
            return result.Succeeded();
        }

        public OperationResult RestoreTuition(long Id)
        {
            OperationResult result = new OperationResult();
            var tui = _tuRep.Get(Id);
            if (tui == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            tui.Restore();
            _tuRep.SaveChanges();
            return result.Succeeded();
        }
    }
}
