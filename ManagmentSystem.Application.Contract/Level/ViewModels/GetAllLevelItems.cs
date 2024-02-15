namespace ManagmentSystem.Application.Contract.Level.ViewModels
{
    public class GetAllLevelItems
    {
        public int Id { get; set; }

        public string CreationDate { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public double Fee { get; set; }

        public string Description { get; set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }
    }
}
