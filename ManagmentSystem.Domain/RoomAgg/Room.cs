using ManagmentSystem.Domain.TermClassAgg;
using ZeroFramework.Domain;
using ZeroFramework.Infrastructure;

namespace ManagmentSystem.Domain.RoomAgg
{
    public class Room : EntityBase<int>
    {

        public string RoomName { get; private set; }

        public string Descriptions { get; private set; }

        //---------------------------------------------------------------------- 
        public List<TermClass> TermClasses { get; private set; }

        //======================================================================
        public Room()
        {
            TermClasses = new List<TermClass>();
        }

        public Room(string roomName, string descriptions)
        {
            RoomName = roomName;
            Descriptions = descriptions;
        }
        public void Edit(string roomName, string descriptions)
        {
            RoomName = roomName;
            Descriptions = descriptions;
        }
        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
