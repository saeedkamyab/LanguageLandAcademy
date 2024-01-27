using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Application.Contract.Level
{
    public class RemoveLevelItem
    {
        public int LevelId { get; set; }

        public string LevelName { get; private set; }

        public int LevelType { get; private set; }

        public string LevelDescription { get; private set; }
    }
}
