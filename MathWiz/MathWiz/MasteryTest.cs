using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class MasteryTest : Test
    {
        public decimal Grade { get; set; }

        public MasteryTest() : base() { }

        public MasteryTest(List<Question> questions, int timeLimit, decimal grade) : base(questions, timeLimit)
        {
            this.Grade = grade;
        }
    }
}
