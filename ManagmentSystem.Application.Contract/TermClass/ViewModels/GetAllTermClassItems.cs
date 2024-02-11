namespace ManagmentSystem.Application.Contract.TermClass.ViewModels
{
    public class GetAllTermClassItems
    {
        public long Id { get; set; }

        public string CreateDate { get; set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Day { get; set; }

        public string Description { get; set; }
    }
}