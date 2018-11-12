using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class Grade
    {
        public Test Test { get; set; } //might need to be specific...
        public decimal Score { get; set; }
        public bool Passed { get; set; }
        public TimeSpan TimeTakenToComplete { get; set; }
        public int NumberAttempts { get; set; }
        public List<Question> RightlyAnsweredQuestions { get; set; }
        public List<Question> WronglyAnsweredQuestions { get; set; }
        public string Feedback { get; set; }

        //empty constructor
        public Grade() { }

        //full constructor
        public Grade(Test test, decimal score, bool passed, TimeSpan timeTakenToComplete, int numberAttempts, List<Question> rightlyAnsweredQuestions, List<Question> wronglyAnsweredQuestions, string feedback = "")
        {
            this.Test = test;
            this.Score = score;
            this.Passed = passed;
            this.TimeTakenToComplete = timeTakenToComplete;
            this.NumberAttempts = numberAttempts;
            this.RightlyAnsweredQuestions = rightlyAnsweredQuestions;
            this.WronglyAnsweredQuestions = wronglyAnsweredQuestions;
            this.Feedback = feedback;
        }
    }
}
