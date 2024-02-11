using ManagmentSystem.Application.Contract.Room.ViewModels;
using ZeroFramework.Domain.BaseInterface;

namespace ManagmentSystem.Domain.RoomAgg.Interface
{
    public interface IRoomRepository: IBaseRepository<int, Room>
    {
        List<AllRooms> GetAllRooms();
    }
}
