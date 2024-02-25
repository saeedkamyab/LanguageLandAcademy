namespace ManagmentSystem.Application.Contract.AbsentPresent.ViewModels
{
    public class GetAllAbPreItems
    {
        public int Id { get; set; }

        public string CreationDate { get; set; }

        public bool Status { get; set; }

        public DateTime DayDate { get; set; }

        public string Description { get; set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }
    }
}
