using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Domain.TermClassAgg
{
    public class PeopleList
    {
        public long PersonId { get; private set; }

        public long AccountId { get; private set; }
        public long TermClassId { get; private set; }
        public TermClass TermClass { get; private set; }

        public PeopleList(long accountId)
        {
            AccountId = accountId;
        }

    }
}
