using ManagmentSystem.Domain.HomeworksExams;
using ManagmentSystem.Domain.TermClassAgg;
using ZeroFramework.Domain;

namespace ManagmentSystem.Domain.LevelAgg
{
    public class Level : EntityBase<int>
    {


        public string Name { get; private set; }

        public int Type { get; private set; }

        public double Fee { get; private set; }

        public string Description { get; private set; }

        //-----------------------------------------------------------------------

        public List<TermClass> TermClasses { get; private set; }
        public List<HomeworkExam> HomeworkExams { get; private set; }


        //========================================================================
        //public Level()
        //{
        //    TermClasses = new List<TermClass>();
        //}

        public Level(string name, int type,double fee, string description)
        {
            Name = name;
            Type = type;
            Fee = fee;
            Description = description;
        }


        public void Edit(string name, int type,double fee, string description)
        {
            Name = name;
            Type = type;
            Fee = fee;
            Description = description;
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
