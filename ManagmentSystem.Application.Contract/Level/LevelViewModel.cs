using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Application.Contract.Level
{
    public class LevelViewModel
    {

        public long Id { get; set; }

        public string CreateDate { get; set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public string LevelName { get; private set; }

        public int LevelType { get; private set; }

        public string LevelDescription { get; private set; }
    }
}
