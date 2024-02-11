using ManagmentSystem.Application.Contract.Room.Interface;
using ManagmentSystem.Application.Contract.Room.ViewModels;
using ManagmentSystem.Domain.RoomAgg.Interface;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.RoomApp
{
    public class RoomApplication : IRoomApplication
    {
        private readonly IRoomRepository _roomRepository;

        public RoomApplication(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public OperationResult CreateRoom(CreateRoom entity)
        {
            throw new NotImplementedException();
        }

        public OperationResult DeleteRoom(RemoveRoomItem entity)
        {
            throw new NotImplementedException();
        }

        public List<AllRooms> GetAllRooms()
        {
            return _roomRepository.GetAllRooms();
        }

        public OperationResult RestoreRoom(RestoreRoomItem entity)
        {
            throw new NotImplementedException();
        }

        public OperationResult UpdateRoom(EditRoom entity)
        {
            throw new NotImplementedException();
        }
    }
}
