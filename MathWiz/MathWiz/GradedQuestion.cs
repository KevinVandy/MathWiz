using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class GradedQuestion //notice, this does not extend off Grade or Question, instead it has a question as a property
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public string StudentAnswer { get; set; }
        public bool Correct { get; set; } //could change to decimal score if we want to possibly give partial credit
        public TimeSpan TimeTakenToAnswer { get; set; }

        //empty constructor
        public GradedQuestion() { }

        //full constructor
        public GradedQuestion(Question question, string studentAnswer, bool correct, TimeSpan timeTakenToAnswer)
        {
            this.Question = question;
            this.StudentAnswer = studentAnswer;
            this.Correct = correct;
            this.TimeTakenToAnswer = timeTakenToAnswer;
        }
    }
}
