
namespace ManagmentSystem.Domain.TermClassAgg
{
    public class Person
    {
        public long Id { get; private set; }

        public long AccountId { get; private set; }

        public long TermClassId { get; private set; }
        //-------------------------------------------------

        public TermClass TermClass { get; private set; }

        //=================================================
        public Person(long accountId)
        {
            AccountId = accountId;
        }

    }
}
