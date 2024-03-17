using ManagmentSystem.Domain.LevelAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain;

namespace ManagmentSystem.Domain.HomeworksExams
{
    public class HomeworkExam : EntityBase<int>
    {
        public string Question { get; private set; }

        public string OptionA { get; private set; }

        public string OptionB { get; private set; }

        public string OptionC { get; private set; }

        public string OptionD { get; private set; }

        public string CorrectAnswer { get; private set; }

        public int Session { get; private set; }

        public string Description { get; private set; }

        public int LevelId { get; private set; }
        public Level Level { get; private set; }


        #region Constructor
    
        public HomeworkExam(string question, string optionA, string optionB, string optionC, string optionD,
            string correctAnswer, int session, string description, int levelId)
        {
            Question = question;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            OptionD = optionD;
            CorrectAnswer = correctAnswer;
            Session = session;
            Description = description;
            LevelId = levelId;
        }
        #endregion

        #region Edit
        public void Edit(string question, string optionA, string optionB, string optionC, string optionD,
            string correctAnswer, int session, string description)
        {
            Question = question;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            OptionD = optionD;
            CorrectAnswer = correctAnswer;
            Session = session;
            Description = description;
            LastUpdate = DateTime.Now;
        }
        #endregion

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
