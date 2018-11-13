using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    class GradedQuestion
    {
        Question Question { get; set; }
        public string StudentAnswer { get; set; }
        public TimeSpan TimeTakenToAnswer { get; set; }
    }
}
