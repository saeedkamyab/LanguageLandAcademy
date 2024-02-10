using ManagmentSystem.Domain.TermClassAgg;
using ZeroFramework.Domain;

namespace ManagmentSystem.Domain.LevelAgg
{
    public class Level : EntityBase<int>
    {


        public string LevelName { get; private set; }

        public int LevelType { get; private set; }

        public string LevelDescription { get; private set; }

        //-----------------------------------------------------------------------

        public List<TermClass> TermClasses { get; private set; }


        //========================================================================
        public Level()
        {
            TermClasses = new List<TermClass>();
        }

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

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }

    }
}
