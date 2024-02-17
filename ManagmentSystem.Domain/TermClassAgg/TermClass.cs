using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.RegisterInAgg;
using ZeroFramework.Domain;

namespace ManagmentSystem.Domain.TermClassAgg
{
    public class TermClass : EntityBase<long>
    {
        public string StartTime { get; private set; }
        public string EndTime { get; private set; }
        public string Day { get; private set; }
        public string Room { get; private set; }
        public string StartDate { get; private set; }
        public string EndDate { get; private set; }
        public bool Status { get; private set; }
        public string Description { get; private set; }

        //-----------------------------------------------------------
        public int LevelId { get; private set; }
        public Level Level { get; private set; }

        public List<Register> Registers { get; private set; }
        //===========================================================
        protected TermClass()
        {

        }
        public TermClass(string startTime, string endTime, 
            string day, string room, 
            string startDate, string endDate,
            string description, int levelId)
        {
            StartTime = startTime;
            EndTime = endTime;
            Day = day;
            Room = room;
            StartDate = startDate;
            EndDate = endDate;
            Status = true;
            Description = description;
            LevelId = levelId;
        }

        public void Edit(string startTime, string endTime, 
            string day, string room,
            string startDate, string endDate,
            bool status, string description, int levelId)
        {
            StartTime = startTime;
            EndTime = endTime;
            Day = day;
            Room = room;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            Description = description;
            LevelId = levelId;
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
