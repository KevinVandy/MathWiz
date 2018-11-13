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
        public PlacementTest(List<Question> questions, TimeSpan timeLimit, bool randomlyGenerated, int minLevel, int maxLevel) : base(questions, timeLimit, randomlyGenerated)
        {
            this.MinLevel = minLevel;
            this.MaxLevel = maxLevel;
        }
    }
}
