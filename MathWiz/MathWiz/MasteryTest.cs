using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class MasteryTest : Test
    {
        public int MasteryLevel { get; set; }
        public decimal PassThreshhold { get; set; }

        //empty constructor
        public MasteryTest() : base() { }

        //full constructor
        public MasteryTest(List<Question> questions, TimeSpan timeLimit, bool randomlyGenerated, int masteryLevel, decimal passThreshhold) : base(questions, timeLimit, randomlyGenerated)
        {
            this.PassThreshhold = passThreshhold;
            this.MasteryLevel = masteryLevel;
        }
    }
}
