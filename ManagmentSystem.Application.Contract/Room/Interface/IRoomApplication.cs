using ManagmentSystem.Application.Contract.Room.ViewModels;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.Contract.Room.Interface
{
    public interface IRoomApplication
    {
        List<GetAllRoomItems> GetAllLevels();

        OperationResult CreateRoom(CreateRoom entity);

        OperationResult UpdateRoom(EditRoom entity);

        OperationResult DeleteRoom(RemoveRoomItem entity);

        OperationResult RestoreRoom(RestoreRoomItem entity);
    }
}
