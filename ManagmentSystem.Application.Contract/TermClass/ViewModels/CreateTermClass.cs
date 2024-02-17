
namespace ManagmentSystem.Application.Contract.TermClass.ViewModels
{
    public class CreateTermClass
    {
        public string StartTime { get; set; }
       
        public string EndTime { get; set; }
       
        public string Day { get; set; }
       
        public string Description { get; set; }

        public int LevelId { get;  set; }

        public string Room { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public bool Status { get; set; }

    }
}