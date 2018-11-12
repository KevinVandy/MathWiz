using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class Grade
    {
        public Test Test { get; set; }
        public decimal ScorePercentage { get; set; }
        public bool Passed { get; set; }
        public TimeSpan TimeTakenToComplete { get; set; }
        public int NumberAttempts { get; set; }
        public List<Question> WronglyAnsweredQuestions { get; set; }
        public List<Question> RightlyAnsweredQuestions { get; set; }


    }
}
