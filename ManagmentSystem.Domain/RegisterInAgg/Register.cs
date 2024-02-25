using ManagmentSystem.Domain.LevelAgg;
using ManagmentSystem.Domain.PresentAbsentAgg;
using ManagmentSystem.Domain.TermClassAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain;

namespace ManagmentSystem.Domain.RegisterInAgg
{
    public class Register : EntityBase<long>
    {
        public long PeopleId {  get;private set; }

        public int Reading { get; private set; }
        public int Writting { get; private set; }
        public int Speaking { get; private set; }
        public int Listening { get; private set; }
        public int MidTerm { get; private set; }
        public int Final { get; private set; }


        public long TermClassId { get; private set; }
        public TermClass TermClass { get; private set; }

        public List<AbsentPresent>absentPresent { get; private set; }

        public Register(long peopleId, long termClassId)
        {
            PeopleId = peopleId;
            TermClassId = termClassId;
        }
        public Register(long id,long peopleId, long termClassId)
        {
            Id= id;
            PeopleId = peopleId;
            TermClassId = termClassId;
        }
        public void Edit(int reading, int writting, int speaking, int listening, int midTerm, int final, long termClassId)
        {
            Reading = reading;
            Writting = writting;
            Speaking = speaking;
            Listening = listening;
            MidTerm = midTerm;
            Final = final;
            TermClassId = termClassId;
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
