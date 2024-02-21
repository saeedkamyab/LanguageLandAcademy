using ManagmentSystem.Application.Contract.Level.ViewModels;
using ManagmentSystem.Application.Contract.RegisterIn.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.Contract.RegisterIn.Interface
{
    public interface IRegisterInApplication
    {
        List<GetAllRegisteration> GetAllRegisteration();

        List<GetAllRegisteration>GetAllReByTcId(long tcId);

        RegisterationViewModel GetRegistrationItemDetail(long id);

        OperationResult AddRegistration(AddRegisteration entity);
       
        OperationResult AddRegistrationRange(List<AddRegisteration> entity);

        OperationResult EditRegistration(EditRegisteration entity);

        OperationResult PhysicalDeleteRegistration(long id);

        OperationResult DeleteRegistration(int id);

        OperationResult RestoreRegistration(int id);

        void SaveAllChanges();
    }
}
