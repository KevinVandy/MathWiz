using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class GradedPracticeTest : Grade
    {
        PracticeTest PracticeTest { get; set; }

        //empty constructor
        public GradedPracticeTest() { }

        //full constructor
        public GradedPracticeTest(PracticeTest practiceTest, decimal score, TimeSpan timeTakenToComplete, DateTime dateTaken, List<Question> rightlyAnsweredQuestions, List<Question> wronglyAnsweredQuestions, string feedback = "") : base(score, timeTakenToComplete, dateTaken, rightlyAnsweredQuestions, wronglyAnsweredQuestions, feedback)
        {
            this.PracticeTest = practiceTest;
        }
    }
}
