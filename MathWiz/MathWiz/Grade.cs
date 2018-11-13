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
        public List<GradedQuestion> RightlyAnsweredQuestions { get; set; }
        public List<GradedQuestion> WronglyAnsweredQuestions { get; set; }
        public string Feedback { get; set; }

        //empty constructor
        public Grade() { }

        //full constructor
        public Grade(decimal score, TimeSpan timeTakenToComplete, DateTime dateTaken, List<GradedQuestion> rightlyAnsweredQuestions, List<GradedQuestion> wronglyAnsweredQuestions, string feedback = "")
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
