using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    /*  Kevin's note:
     *  I thought about this for a while. Should we split questions into multiple classes?
     *  Such as multiple choice questions exending off of the base question class, 
     *  and having randomly generated questions and customized questions be their own classes?
     *  However, I decided against it because it was going to make the Test and Grade classes a lot more complicated
     *  Instead, I have just provided multiple different constructors that will make it act like their own unique objects.
     *  This is an important decision, and if we get it wrong, it could cost a lot of time, so we need to talk it over.
     */

    /*I was looking at 12 mastery levels
     * 1. simple addition
     * 2. simple subtraction
     * 3. simple mixed add, sub
     * 7. simple multiplication
     * 8. simple division
     * 9. mixed mult, div
     * 4. complex addition
     * 5. complex sub
     * 6. complex mixed add, sub
     * 10. advanced mult
     * 11. advanced div
     * 13. advanced mixed mult, div*/


    public class Question
    {
        public int Id { get; set; }
        public int MasteryLevel { get; set; }
        public string QuestionText { get; set; }
        public List<RadioButton> Choices { get; set; }
        public string CorrectAnswer { get; set; }
        public TimeSpan TimeLimit { get; set; }
        public int Weight { get; set; }
        public bool RandomlyGenerated { get; set; }

        Random rnd = new Random();
        //declare a list of question objects that will later be fed back  to the test
        private List<Question> testQuestions = new List<Question>();
        //empty constructor
        public Question() { }

        //normal constructor randomly generated
        public Question(int masteryLevel, TimeSpan timeLimit, int weight = 1)
        {
            this.MasteryLevel = masteryLevel;
            this.QuestionText = null; //TODO call method to generate question based on masterylevel
            this.Choices = null;
            this.CorrectAnswer = null; //TODO call method to generate answer based on question (or it will also be set during generation of question)
            this.TimeLimit = timeLimit;
            this.Weight = weight;
            this.RandomlyGenerated = true;
        }

        //normal custom constructor no choices
        public Question(string questionText, string correctAnswer, TimeSpan timeLimit, int weight = 1)
        {
            this.MasteryLevel = 0; //TODO calculate the mastery level based on the question that was submitted by the teacher
            this.QuestionText = questionText;
            this.Choices = null;
            this.CorrectAnswer = correctAnswer;
            this.TimeLimit = timeLimit;
            this.Weight = weight;
            this.RandomlyGenerated = false;
        }

        //normal custom constructor with choices
        public Question(string questionText, List<RadioButton> choices, string correctAnswer, TimeSpan timeLimit, int weight = 1)
        {
            this.MasteryLevel = 0; //TODO calculate the mastery level based on the question that was submitted by the teacher
            this.QuestionText = questionText;
            this.Choices = choices;
            this.CorrectAnswer = correctAnswer;
            this.TimeLimit = timeLimit;
            this.Weight = weight;
            this.RandomlyGenerated = false;
        }

        //full constructor
        public Question(int masteryLevel, string questionText, List<RadioButton> choices, string correctAnswer, TimeSpan timeLimit, int weight, bool randomlyGenerated)
        {
            this.MasteryLevel = masteryLevel;
            this.QuestionText = questionText;
            this.Choices = choices;
            this.CorrectAnswer = correctAnswer;
            this.TimeLimit = timeLimit;
            this.Weight = weight;
            this.RandomlyGenerated = randomlyGenerated;
        }
        /*stuff*/
         private List<Question> GenerateQuestions(int masteryLevel)
        {
            return testQuestions;
        }

        private int GenerateRandomNumbers(int masteryLevel)
        {
            int aNumber;
            if(masteryLevel <=6 )
            {
                aNumber = rnd.Next(0, 10);
            }
            else
            {
                aNumber = rnd.Next(0, 20);
            }

            return aNumber;
        }

    }
}
