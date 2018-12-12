using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public abstract class Test
    {
        public int Id { get; set; }
        public List<Question> Questions { get; set; }
        public TimeSpan TimeLimit { get; set; }
        public bool RandomlyGenerated { get; set; }

        //empty constructor
        public Test()
        {
            this.Questions = new List<Question>();
        }

        //full constructor
        public Test(List<Question> questions, TimeSpan timeLimit, bool randomlyGenerated)
        {
            this.Questions = questions;
            this.TimeLimit = timeLimit;
            this.RandomlyGenerated = randomlyGenerated;
        }

        //methods for all tests
    }
}
