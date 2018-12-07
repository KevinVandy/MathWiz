using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class GradedPlacementTest : GradedTest
    {
        public PlacementTest PlacementTest { get; set; }
        public int RecommendedLevel { get; set; }

        //empty constructor
        public GradedPlacementTest() { }

        //full constructor
        public GradedPlacementTest(PlacementTest placementTest, int recommendedLevel, decimal score, TimeSpan timeTakenToComplete, DateTime dateTaken, List<GradedQuestion> rightlyAnsweredQuestions, List<GradedQuestion> wronglyAnsweredQuestions, string feedback = "") : base(score, timeTakenToComplete, dateTaken, rightlyAnsweredQuestions, wronglyAnsweredQuestions, feedback)
        {
            this.PlacementTest = placementTest;
            this.RecommendedLevel = recommendedLevel;
        }
    }
}
