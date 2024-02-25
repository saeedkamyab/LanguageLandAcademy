namespace ManagmentSystem.Application.Contract.AbsentPresent.ViewModels
{
    public class AbPreViewModel
    {
        public long Id { get; set; }

        public string CreationDate { get; set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public bool Status { get; set; }

        public DateTime DayDate { get; set; }

        public string Description { get;  set; }
    }
}
