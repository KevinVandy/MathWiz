using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class MasteryTest : Test
    {
        public decimal PassThreshhold { get; set; }

        //empty constructor
        public MasteryTest() : base() { }

        //full constructor
        public MasteryTest(List<Question> questions, TimeSpan timeLimit, decimal passThreshhold) : base(questions, timeLimit)
        {
            this.PassThreshhold = passThreshhold;
        }
    }
}
