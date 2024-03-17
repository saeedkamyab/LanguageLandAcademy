namespace ManagmentSystem.Application.Contract.HomeworkExams.ViewModels
{
    public class HomeworkExamViewModel
    {
        public long Id { get; set; }

        public string CreationDate { get; set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public string Name { get;  set; }

        public int Type { get;  set; }

        public double Fee { get; set; }

        public string Description { get;  set; }
    }
}
