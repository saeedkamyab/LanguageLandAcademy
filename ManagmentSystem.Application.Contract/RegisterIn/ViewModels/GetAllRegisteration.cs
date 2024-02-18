namespace ManagmentSystem.Application.Contract.RegisterIn.ViewModels
{
    public class GetAllRegisteration
    {
        public long Id { get; set; }

        public string CreationDate { get; set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public long PeopleId { get; set; }

        public int Reading { get; set; }
        public int Writting { get; set; }
        public int Speaking { get; set; }
        public int Listening { get; set; }
        public int MidTerm { get; set; }
        public int Final { get; set; }

        public long TermClassId { get; set; }
    }
}
