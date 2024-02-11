namespace ManagmentSystem.Application.Contract.Level.ViewModels
{
    public class GetAllLevelItems
    {
        public int Id { get; set; }

        public string CreationDate { get; set; }

        public string LevelName { get; set; }

        public int LevelType { get; set; }

        public string LevelDescription { get; set; }

        public string LastUpdate { get; set; }
    }
}
