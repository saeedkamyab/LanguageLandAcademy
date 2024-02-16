using ManagmentSystem.Application.Contract.TemporaryRegister.ViewModels;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.Contract.TemporaryRegister.Interface
{
    public interface ITemporaryRegisterApplication
    {

        List<AllTemporaryRegister> GetAllTeRegister();

        EditTemporaryRegister GetTeRegisterItemDetail(int id);

        OperationResult CreateTeRegister(CreateTemporaryRegister entity);

        OperationResult UpdateTeRegister(EditTemporaryRegister entity);

        OperationResult DeleteTeRegister(int id);

        OperationResult RestoreTeRegister(int id);

    }
}
