using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroFramework.Infrastructure
{
    public class PeaopleDto
    {

        public long AccountId { get; set; }

        public PeaopleDto(long accountId)
        {
            AccountId = accountId;
        }
    }
}
