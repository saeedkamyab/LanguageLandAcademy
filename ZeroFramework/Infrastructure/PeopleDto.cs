using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroFramework.Infrastructure
{
    public class PeopleDto
    {

        public long AccountId { get; set; }

        public PeopleDto(long accountId)
        {
            AccountId = accountId;
        }
    }
}
