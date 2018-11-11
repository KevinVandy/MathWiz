using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class PracticeTest : Test
    {
        public short MinLevel { get; set; }
        public short MaxLevel { get; set; }

        //empty constructor
        public PracticeTest() : base() { }

        //full constructor
        public PracticeTest(List<Question> questions, TimeSpan timeLimit, short minLevel, short maxLevel) : base(questions, timeLimit)
        {
            this.MinLevel = minLevel;
            this.MaxLevel = maxLevel;
        }
    }
}
