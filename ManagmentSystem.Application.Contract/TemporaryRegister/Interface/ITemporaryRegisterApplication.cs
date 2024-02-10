using ManagmentSystem.Application.Contract.TemporaryRegister.ViewModels;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.Contract.TemporaryRegister.Interface
{
    public interface ITemporaryRegisterApplication
    {

        List<GetAllTemporaryRegisterItems> GetAllLevels();

        OperationResult CreateLevel(CreateTemporaryRegister entity);

        OperationResult UpdateLevel(EditTemporaryRegister entity);

        OperationResult DeleteLevel(RemoveTemporaryRegister entity);

        OperationResult RestoreLevel(RestoreTemporaryRegister entity);

    }
}
