using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroFramework.Infrastructure
{
    public interface IPeopleExposer
    {
        Dictionary<string, List<PeopleDto>> Expose();
    }
}
