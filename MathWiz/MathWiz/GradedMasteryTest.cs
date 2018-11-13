using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class GradedMasteryTest : Grade
    {
        MasteryTest MasteryTest { get; set; }
        public bool Passed { get; set; }
        public int NumberAttempts { get; set; }

        //empty constructor
        public GradedMasteryTest() { }

        //full constructor
        public GradedMasteryTest(MasteryTest masteryTest, bool passed, int numberAttempts, decimal score, TimeSpan timeTakenToComplete, DateTime dateTaken, List<GradedQuestion> rightlyAnsweredQuestions, List<GradedQuestion> wronglyAnsweredQuestions, string feedback = "") : base(score, timeTakenToComplete, dateTaken, rightlyAnsweredQuestions, wronglyAnsweredQuestions, feedback)
        {
            this.MasteryTest = masteryTest;
            this.Passed = passed;
            this.NumberAttempts = numberAttempts;
        }
    }
}
