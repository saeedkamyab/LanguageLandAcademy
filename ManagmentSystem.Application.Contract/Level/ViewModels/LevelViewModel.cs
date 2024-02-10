namespace ManagmentSystem.Application.Contract.Level.ViewModels
{
    public class LevelViewModel
    {
        public long Id { get; set; }

        public string CreateDate { get; set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public string LevelName { get;  set; }

        public int LevelType { get;  set; }

        public string LevelDescription { get;  set; }
    }
}
