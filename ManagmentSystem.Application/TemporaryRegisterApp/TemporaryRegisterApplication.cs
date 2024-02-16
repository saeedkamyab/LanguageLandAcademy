using ManagmentSystem.Application.Contract.TemporaryRegister.Interface;
using ManagmentSystem.Application.Contract.TemporaryRegister.ViewModels;
using ManagmentSystem.Domain.TemporaryRegisterAgg;
using ManagmentSystem.Domain.TemporaryRegisterAgg.Interface;
using ManagmentSystem.Domain.TuitionAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.TemporaryRegisterApp
{
    public class TemporaryRegisterApplication : ITemporaryRegisterApplication
    {
        private readonly ITemporaryRegisterRepository _teRegisterRepository;

        public TemporaryRegisterApplication(ITemporaryRegisterRepository teRegisterRepository)
        {
            _teRegisterRepository = teRegisterRepository;
        }
        public List<AllTemporaryRegister> GetAllTeRegister()
        {
            return _teRegisterRepository.GetAllTeRegister();
        }
        public OperationResult CreateTeRegister(CreateTemporaryRegister entity)
        {
            var operation = new OperationResult();
            var teRegister = new TemporaryRegister(entity.FullName,entity.PhoneNumbers,entity.Description);
            _teRegisterRepository.Create(teRegister);
            _teRegisterRepository.SaveChanges();
            return operation.Succeeded();
        }
        public OperationResult UpdateTeRegister(EditTemporaryRegister entity)
        {
            var operation = new OperationResult();
            var teRegister = _teRegisterRepository.Get(entity.Id);
            if (teRegister == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            teRegister.Edit(entity.FullName,entity.PhoneNumbers,entity.Description);
            _teRegisterRepository.SaveChanges();
            return operation.Succeeded();
        }
        public OperationResult DeleteTeRegister(int id)
        {
            OperationResult result = new OperationResult();
            var teRegister = _teRegisterRepository.Get(id);
            if (teRegister == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            teRegister.Remove();
            _teRegisterRepository.SaveChanges();
            return result.Succeeded();
        }
        public OperationResult RestoreTeRegister(int id)
        {
            OperationResult result = new OperationResult();
            var teRegister = _teRegisterRepository.Get(id);
            if (teRegister == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            teRegister.Restore();
            _teRegisterRepository.SaveChanges();
            return result.Succeeded();
        }

        public EditTemporaryRegister GetTeRegisterItemDetail(int id)
        {
            return _teRegisterRepository.GetDetails(id);
        }
    }
}
