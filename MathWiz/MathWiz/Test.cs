using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public abstract class Test
    {
        public List<Question> Questions { get; set; }
        public TimeSpan TimeLimit { get; set; }

        //empty constructor
        public Test() { }

        //full constructor
        public Test(List<Question> questions, TimeSpan timeLimit)
        {
            this.Questions = questions;
            this.TimeLimit = timeLimit;
        }

        //methods for all tests
    }
}
