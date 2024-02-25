using ManagmentSystem.Domain.RegisterInAgg;
using ZeroFramework.Domain;

namespace ManagmentSystem.Domain.PresentAbsentAgg
{
    public class AbsentPresent : EntityBase<long>
    {
      
        public bool Status { get; private set; }

        public DateTime DayDate { get; private set; }

        public string Description { get; private set; }

        //-----------------------------------------------------------------------

        public long RegisterId { get; private set; }
        public Register Register { get; private set; }


        //========================================================================

        public AbsentPresent(DateTime dayDate, string description, long registerId)
        {
            Status = true;
            DayDate = dayDate;
            Description = description;
            RegisterId = registerId;
        }

        public void Edit(string description)
        {
            Description = description;
            LastUpdate = DateTime.Now;
        }

        public void Absent()
        {
            Status = false;
        }

        public void Present()
        {
            Status = true;
        }

    }
}
