
namespace ManagmentSystem.Application.Contract.TermClass.ViewModels
{
    public class CreateTermClass
    {
        public string StartTime { get; set; }
       
        public string EndTime { get; set; }
       
        public string Day { get; set; }
       
        public string Description { get; set; }

        public List<long> People { get; set; }

        public int LevelId { get;  set; }

        public int RoomId { get; set; }
    }
}