using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public abstract class Grade
    {
        public decimal Score { get; set; }
        public TimeSpan TimeTakenToComplete { get; set; }
        public DateTime DateTaken { get; set; }
        public List<Question> RightlyAnsweredQuestions { get; set; }
        public List<Question> WronglyAnsweredQuestions { get; set; }
        public string Feedback { get; set; }

        //empty constructor
        public Grade() { }

        //full constructor
        public Grade(decimal score, TimeSpan timeTakenToComplete, DateTime dateTaken, List<Question> rightlyAnsweredQuestions, List<Question> wronglyAnsweredQuestions, string feedback = "")
        {
            this.Score = score;
            this.TimeTakenToComplete = timeTakenToComplete;
            this.DateTaken = dateTaken;
            this.RightlyAnsweredQuestions = rightlyAnsweredQuestions;
            this.WronglyAnsweredQuestions = wronglyAnsweredQuestions;
            this.Feedback = feedback;
        }
    }
}
