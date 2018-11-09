using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public class Question
    {
        public short MasteryLevel { get; set; }
        public string QuestionText { get; set; }
        public List<RadioButton> Choices { get; set; }
        public string RightAnswer { get; set; }
        public string StudentAnswer { get; set; }
        public short Weight { get; set; }
        public bool RandomlyGenerated { get; set; }


        //empty constructor
        public Question() { }

        //normal randomly generated generated
        public Question(short masteryLevel, short weight = 1)
        {
            this.MasteryLevel = masteryLevel;
            this.QuestionText = null; //TODO call method to generate question based on masterylevel
            this.Choices = null;
            this.RightAnswer = null; //TODO call method to generate answer based on question (or it will also be set during generation of question)
            this.StudentAnswer = null;
            this.Weight = weight;
            this.RandomlyGenerated = true;
        }

        //normal custom constructor no choices
        public Question(short masteryLevel, string questionText, string rightAnswer, string studentAnswer, short weight = 1)
        {
            this.MasteryLevel = masteryLevel;
            this.QuestionText = questionText;
            this.Choices = null;
            this.RightAnswer = rightAnswer;
            this.StudentAnswer = studentAnswer;
            this.Weight = weight;
            this.RandomlyGenerated = false;
        }

        //normal custom constructor with choices
        public Question(short masteryLevel, string questionText, List<RadioButton> choices, string rightAnswer, string studentAnswer, short weight = 1)
        {
            this.MasteryLevel = masteryLevel;
            this.QuestionText = questionText;
            this.Choices = choices;
            this.RightAnswer = rightAnswer;
            this.StudentAnswer = studentAnswer;
            this.Weight = weight;
            this.RandomlyGenerated = false;
        }

        //full constructor
        public Question(short masteryLevel, string questionText, List<RadioButton> choices, string rightAnswer, string studentAnswer, short weight, bool randomlyGenerated)
        {
            this.MasteryLevel = masteryLevel;
            this.QuestionText = questionText;
            this.Choices = choices;
            this.RightAnswer = rightAnswer;
            this.StudentAnswer = studentAnswer;
            this.Weight = weight;
            this.RandomlyGenerated = randomlyGenerated;
        }

    }
}
