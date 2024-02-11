using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.RoomAgg;
using ZeroFramework.Domain;

namespace ManagmentSystem.Domain.TermClassAgg
{
    public class TermClass : EntityBase<long>
    {
        public string StartTime { get; private set; }
        public string EndTime { get; private set; }
        public string Day { get; private set; }
        public string Description { get; private set; }

        //-----------------------------------------------------------
        public int LevelId { get; private set; }
        public Level Level { get; private set; }


        public int RoomId { get; private set; }
        public Room Room { get; private set; }

        public List<PeopleList> PeopleLists { get; private set; }

        //===========================================================
        protected TermClass()
        {

        }

        public TermClass(string startTime, string endTime, string day, 
            string description,int levelId,int roomId, List<PeopleList> peopleLists)
        {
            StartTime = startTime;
            EndTime = endTime;
            Day = day;
            Description = description;
            LevelId = levelId;
            RoomId = roomId;
            PeopleLists = peopleLists;
        }

        public void Edit(string startTime, string endTime, string day, 
            string description, int levelId, int roomId, List<PeopleList> peopleLists)
        {
            StartTime = startTime;
            EndTime = endTime;
            Day = day;
            Description = description;
            LevelId = levelId;
            RoomId = roomId;
            PeopleLists = peopleLists;
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
