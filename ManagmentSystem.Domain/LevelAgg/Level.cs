using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain;

namespace ManagmentSystem.Domain.LevelAgg
{
    public class Level:EntityBase<int>
    {
  

        public string LevelName { get; private set; }

        public int LevelType { get; private set; }

        public string LevelDescription { get; private set; }

        public Level(string levelName, int levelType, string levelDescription)
        {
            LevelName = levelName;
            LevelType = levelType;
            LevelDescription = levelDescription;
        }

        public void Edit(string levelName, int levelType, string levelDescription)
        {
            LevelName = levelName;
            LevelType = levelType;
            LevelDescription = levelDescription;
            LastUpdate = DateTime.Now;
        }

        #region Remove & Restore
        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
        #endregion
    }
}
