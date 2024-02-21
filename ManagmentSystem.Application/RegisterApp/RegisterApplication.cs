using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Application.Contract.RegisterIn.Interface;
using ManagmentSystem.Application.Contract.RegisterIn.ViewModels;
using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.LevelAgg.Interface;
using ManagmentSystem.Domain.RegisterInAgg;
using ManagmentSystem.Domain.RegisterInAgg.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.RegisterApp
{
    public class RegisterApplication : IRegisterInApplication
    {
        private readonly IRegisterRepository _ReRepository;

        public RegisterApplication(IRegisterRepository reRepository)
        {
            _ReRepository = reRepository;
        }

        public OperationResult AddRegistration(AddRegisteration entity)
        {
            var result = new OperationResult();
            var register = new Register(entity.PeopleId, entity.TermClassId);
            _ReRepository.Create(register);
            _ReRepository.SaveChanges();
            return result.Succeeded();
        }
        public OperationResult AddRegistrationRange(List<AddRegisteration> entity)
        {
            var result = new OperationResult();
          
            List<Register> reg=new List<Register>();
          
            foreach (var item in entity)
            {
                reg.Add(new Register(item.PeopleId, item.TermClassId));
            }
            
            _ReRepository.CreateRange(reg);
            _ReRepository.SaveChanges();
            return result.Succeeded();
        }
        public OperationResult EditRegistration(EditRegisteration entity)
        {
            var operation = new OperationResult();
            var register = _ReRepository.Get(entity.Id);
            if (register == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            register.Edit(entity.Reading, entity.Writting,
                entity.Speaking, entity.Listening,
                entity.MidTerm, entity.Final, entity.TermClassId);

            _ReRepository.SaveChanges();
            return operation.Succeeded();
        }

        public List<GetAllRegisteration> GetAllRegisteration()
        {
            return _ReRepository.GetAllRegisteration();
        }

        public RegisterationViewModel GetRegistrationItemDetail(long id)
        {
            return _ReRepository.GetRegisterationItemDetails(id);
        }

        public OperationResult RestoreRegistration(int id)
        {
            OperationResult result = new OperationResult();
            var register = _ReRepository.Get(id);
            if (register == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            register.Restore();
            _ReRepository.SaveChanges();
            return result.Succeeded();
        }

        public OperationResult DeleteRegistration(int id)
        {
            OperationResult result = new OperationResult();
            var register = _ReRepository.Get(id);
            if (register == null)
                return result.Failed(ApplicationMessages.RecordNotFound);
            register.Remove();
            _ReRepository.SaveChanges();
            return result.Succeeded();
        }

        public List<GetAllRegisteration> GetAllReByTcId(long tcId)
        {
            return _ReRepository.GetReByTcId(tcId);
        }

        public OperationResult PhysicalDeleteRegistration(long id)
        {
            OperationResult result = new OperationResult();
            var register = _ReRepository.GetRegisterationItemDetails(id);
            if (register == null)
                return result.Failed(ApplicationMessages.RecordNotFound);


            var entity = new Register(register.Id, register.PeopleId, register.TermClassId);
            _ReRepository.Delete(entity);
            _ReRepository.SaveChanges();
            return result.Succeeded();


        }

        public void SaveAllChanges()
        {
            _ReRepository.SaveChanges();
        }


    }
}
