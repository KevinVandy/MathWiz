using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class PlacementTest : Test
    {
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }

        //empty constructor
        public PlacementTest() : base() { }

        //full constructor
        public PlacementTest(List<Question> questions, TimeSpan timeLimit, int minLevel, int maxLevel) : base()
        {
            this.MinLevel = minLevel;
            this.MaxLevel = maxLevel;
        }
    }
}
