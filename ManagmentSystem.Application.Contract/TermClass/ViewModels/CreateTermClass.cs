
namespace ManagmentSystem.Application.Contract.Tuition.ViewModels
{
    public class CreateTermClass
    {
        public string StartTime { get; set; }
       
        public string EndTime { get; set; }
       
        public string Day { get; set; }
       
        public string Description { get; set; }

        public List<long> PeopleLists { get; set; }

        public int LevelId { get; private set; }

        public int RoomId { get; private set; }
    }
}