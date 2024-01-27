using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Application.Contract.Level
{
    public class GetAllLevelItems
    {
        public int LevelId { get; set; }

        public string CreationDate { get; set; }

        public string LevelName { get;  set; }

        public int LevelType { get;  set; }

        public string LevelDescription { get;  set; }

        public  string LastUpdate { get; set; }
    }
}
