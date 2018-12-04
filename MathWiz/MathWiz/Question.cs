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
        public int Id { get; set; }
        public int MasteryLevel { get; set; }
        public string QuestionText { get; set; }
        public List<RadioButton> Choices { get; set; }
        public int CorrectAnswer { get; set; }
        public TimeSpan TimeLimit { get; set; }
        public int Weight { get; set; }
        public bool RandomlyGenerated { get; set; }


        //declare a list of question objects that will later be fed back  to the test
        private static Random rnd = new Random();
        private static List<int> easyRandoms = new List<int>();
        private static List<int> hardRandoms = new List<int>();
        private static List<Question> testQuestions = new List<Question>();
        //empty constructor
        public Question() { }

        //normal constructor randomly generated
        public Question(int masteryLevel, TimeSpan timeLimit, int weight = 1)
        {
            this.MasteryLevel = masteryLevel;
            this.QuestionText = null; //TODO call method to generate question based on masterylevel
            this.Choices = null;
            this.CorrectAnswer = CorrectAnswer; //TODO call method to generate answer based on question (or it will also be set during generation of question)
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
            this.CorrectAnswer = CorrectAnswer;
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
            this.CorrectAnswer = CorrectAnswer;
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
            this.CorrectAnswer = CorrectAnswer;
            this.TimeLimit = timeLimit;
            this.Weight = weight;
            this.RandomlyGenerated = randomlyGenerated;
        }
        /*stuff*/
         private List<Question> GenerateQuestions(int masteryLevel)
        {
            return testQuestions;
        }

        public static List<int> GenerateEasyRandomNumbers(int start, int count)
        {
            easyRandoms = Enumerable.Range(0, 10).OrderBy(x => rnd.Next()).Take(count).ToList();
            return easyRandoms;
        }

        public static List<int> GenerateHardRandomNumbers(int start, int count)
        {
            Random rnd = new Random();
            hardRandoms = Enumerable.Range(10, 99).OrderBy(x => rnd.Next()).Take(count).ToList();
            return hardRandoms;
        }

        /*I was looking at 12 mastery levels
         * 1. simple addition
         * 2. simple subtraction
         * 3. simple mixed add, sub
         * 4. complex addition
         * 5. complex sub
         * 6. complex mixed add, sub
         * 7. simple multiplication
         * 8. simple division
         * 9. simple mixed mult, div
         * 10. advanced mult
         * 11. advanced div
         * 12. advanced mixed mult, div*/

        public static List<Question> GenerateRandomQuestions(int masteryLevel, TimeSpan timeLimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            if(timeLimit == null)
            {
                timeLimit = new TimeSpan(0, 0, 30);
            }
            int caseswitch = masteryLevel;
            switch(masteryLevel)
            {
                case 1:
                    qL = GenerateSimpleAddtionQuestions(timeLimit, NumberOfQuestions);
                    break;
                case 2:
                    qL = GenerateSimpleSubtractionQuestions(timeLimit, NumberOfQuestions);
                    break;
                case 3:
                    qL = GenerateMixedSimpleAdditionSubtraction(timeLimit, NumberOfQuestions);
                    break;
                case 4:
                    qL = GenerateComplexAddition(timeLimit, NumberOfQuestions);
                    break;
                case 5:
                    qL = GenerateComplexSubtraction(timeLimit, NumberOfQuestions);
                    break;
                case 6:
                    qL = GenerateMixedComplexAdditionSubtraction(timeLimit, NumberOfQuestions);
                    break;
                case 7:
                    qL = GenerateSimpleMultiplication(timeLimit, NumberOfQuestions);
                    break;
                case 8:
                    qL = GenerateSimpleDivision(timeLimit, NumberOfQuestions);
                    break;
                case 9:
                    qL = GenerateSimpleMultiplicationDivision(timeLimit, NumberOfQuestions);
                    break;
                case 10:
                    qL = GenerateAdvancedMultiplication(timeLimit, NumberOfQuestions);
                    break;
                case 11:
                    qL = GenerateAdvancedDivision(timeLimit, NumberOfQuestions);
                    break;
                case 12:
                    qL = GenerateAdvnacedMultiplicationDivison(timeLimit, NumberOfQuestions);
                    break;
                default:
                    MessageBox.Show("No known case check that what you passed is within range");
                    break;
                    

            }
            return qL;

        }

        private static List<Question> GenerateAdvnacedMultiplicationDivison(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfromOne = GeneratesAddMultiply(true, true, timelimit);
            List<Question> pullfromOther = GeneratesSubtractDivide(true, true, timelimit);
            int max;
            if (pullfromOne.Count > pullfromOther.Count)
            {
                max = pullfromOther.Count;
            }
            else
            {
                max = pullfromOne.Count;
            }
            var RandomNumbers = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                int oneOrTheOther = rnd.Next(0, 2);
                if (oneOrTheOther == 0)
                {
                    qL.Add(pullfromOne[i]);
                }
                else
                {
                    qL.Add(pullfromOther[i]);
                }

            }
            return qL;
        }

        private static List<Question> GenerateAdvancedDivision(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfrom = GeneratesSubtractDivide(true, true, timelimit);
            var RandomNumbers = Enumerable.Range(0, pullfrom.Count).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                qL.Add(pullfrom[i]);
            }
            return qL;
        }

        private static List<Question> GenerateAdvancedMultiplication(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfrom = GeneratesAddMultiply(true, true, timelimit);
            var RandomNumbers = Enumerable.Range(0, pullfrom.Count).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                qL.Add(pullfrom[i]);
            }
            return qL;
        }

        private static List<Question> GenerateSimpleMultiplicationDivision(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfromOne = GeneratesAddMultiply(false, true, timelimit);
            List<Question> pullfromOther = GeneratesSubtractDivide(false, true, timelimit);
            int max;
            if (pullfromOne.Count > pullfromOther.Count)
            {
                max = pullfromOther.Count;
            }
            else
            {
                max = pullfromOne.Count;
            }
            var RandomNumbers = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                int oneOrTheOther = rnd.Next(0, 2);
                if (oneOrTheOther == 0)
                {
                    qL.Add(pullfromOne[i]);
                }
                else
                {
                    qL.Add(pullfromOther[i]);
                }

            }
            return qL;
        }

        private static List<Question> GenerateSimpleDivision(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfrom = GeneratesSubtractDivide(false, true, timelimit);
            var RandomNumbers = Enumerable.Range(0, pullfrom.Count).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                qL.Add(pullfrom[i]);
            }
            return qL;
        }

        private static List<Question> GenerateSimpleMultiplication(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfrom = GeneratesAddMultiply(false, true, timelimit);
            var RandomNumbers = Enumerable.Range(0, pullfrom.Count).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                qL.Add(pullfrom[i]);
            }
            return qL;
        }

        private static List<Question> GenerateMixedComplexAdditionSubtraction(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfromOne = GeneratesAddMultiply(true, false, timelimit);
            List<Question> pullfromOther = GeneratesSubtractDivide(true, false, timelimit);
            int max;
            if(pullfromOne.Count > pullfromOther.Count)
            {
                max = pullfromOther.Count;
            }
            else
            {
                max = pullfromOne.Count;
            }
            var RandomNumbers = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                int oneOrTheOther = rnd.Next(0, 2);
                if (oneOrTheOther == 0)
                {
                    qL.Add(pullfromOne[i]);
                }
                else
                {
                    qL.Add(pullfromOther[i]);
                }

            }
            return qL;
        }

        private static List<Question> GenerateComplexSubtraction(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfrom = GeneratesSubtractDivide(true, false, timelimit);
            var RandomNumbers = Enumerable.Range(0, pullfrom.Count).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                qL.Add(pullfrom[i]);
            }
            return qL;
        }

        private static List<Question> GenerateComplexAddition(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfrom = GeneratesAddMultiply(true, false, timelimit);
            var RandomNumbers = Enumerable.Range(0, pullfrom.Count).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                qL.Add(pullfrom[i]);
            }
            return qL;
        }

        private static List<Question> GenerateMixedSimpleAdditionSubtraction(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfromOne = GeneratesAddMultiply(false, false, timelimit);
            List<Question> pullfromOther = GeneratesSubtractDivide(false, false, timelimit);
            int max;
            if (pullfromOne.Count > pullfromOther.Count)
            {
                max = pullfromOther.Count;
            }
            else
            {
                max = pullfromOne.Count;
            }
            var RandomNumbers = Enumerable.Range(0, max).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                int oneOrTheOther = rnd.Next(0, 2);
                if(oneOrTheOther == 0)
                {
                    qL.Add(pullfromOne[i]);
                }
                else
                {
                    qL.Add(pullfromOther[i]);
                }

            }
            return qL;
        }

        private static List<Question> GenerateSimpleSubtractionQuestions(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfrom = GeneratesSubtractDivide(false, false, timelimit);
            var RandomNumbers = Enumerable.Range(0, pullfrom.Count).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach (int i in RandomNumbers)
            {
                qL.Add(pullfrom[i]);
            }
            return qL;
        }

        public static List<Question> GenerateSimpleAddtionQuestions(TimeSpan timelimit, int NumberOfQuestions)
        {
            List<Question> qL = new List<Question>();
            List<Question> pullfrom = GeneratesAddMultiply(false, false, timelimit);
            var RandomNumbers = Enumerable.Range(0, pullfrom.Count).OrderBy(x => rnd.Next()).Take(NumberOfQuestions).ToArray();
            foreach(int i in RandomNumbers)
            {
                qL.Add(pullfrom[i]);
            }
            return qL;
        }





        public static List<Question> GeneratesAddMultiply(bool isHard, bool AddFalse_MultiplyTrue, TimeSpan theTime)
        {
            TimeSpan timeLimit = new TimeSpan();
            timeLimit = theTime;
            List<Question> qL = new List<Question>();
            List<int> first = new List<int>();
            List<int> second = new List<int>();
            string testString = "";
            int limit = 10;
            int i;
            int j;
            int lowerBound = 0;
            int control = 0;
            List<int> dontWrite = new List<int>();
            if (isHard == true)
            {
                limit = 20;
                lowerBound = 10;
                int dontwriteint = 11;
                for (i = lowerBound; i < limit; i++)
                {
                    for (j = control; j < limit; j++)
                    {

                        if(j < dontwriteint)
                        {
                            first.Add(i);
                            second.Add(j);
                            testString += i.ToString() + " + " + j.ToString() + ", ";
                        }

                    }
                    dontwriteint++;
                    testString += "\n\n";
                }
            }
            else
            {
                for (i = lowerBound; i < limit; i++)
                {
                    for (j = control; j < limit; j++)
                    {
                        first.Add(i);
                        second.Add(j);
                        testString += i.ToString() + j.ToString() + ", ";
                    }
                    control++;
                }
            }

            string qT;
            int[] answer = new int[500];
            if (AddFalse_MultiplyTrue == false)
            {
                var firstEnumerator = first.GetEnumerator();
                var secondEnumerator = second.GetEnumerator();
                //enumerate through the list
                while (firstEnumerator.MoveNext())
                {
                    int counter = 0;
                    secondEnumerator.MoveNext();
                    qT = firstEnumerator.Current.ToString() + " + " + secondEnumerator.Current.ToString() + " =";
                    answer[counter] = firstEnumerator.Current + secondEnumerator.Current;
                    Question aQuestion = new Question();
                    aQuestion.CorrectAnswer = answer[counter];
                    aQuestion.RandomlyGenerated = true;
                    aQuestion.QuestionText = qT;
                    aQuestion.TimeLimit = timeLimit;
                    qL.Add(aQuestion);
                }


            }
            else
            {
                var firstEnumerator = first.GetEnumerator();
                var secondEnumerator = second.GetEnumerator();
                //enumerate through the list
                while (firstEnumerator.MoveNext())
                {
                    int counter = 0;
                    secondEnumerator.MoveNext();
                    qT = firstEnumerator.Current.ToString() + " x " + secondEnumerator.Current.ToString() + " =";
                    answer[counter] = firstEnumerator.Current * secondEnumerator.Current;

                    Question aQuestion = new Question();
                    aQuestion.CorrectAnswer = answer[counter];
                    aQuestion.RandomlyGenerated = true;
                    aQuestion.QuestionText = qT;
                    aQuestion.TimeLimit = timeLimit;
                    qL.Add(aQuestion);
                }
            }



            return qL;


        }

        public static List<Question> GeneratesSubtractDivide(bool isHard, bool SubtractFalse_DivideTrue, TimeSpan theTime)
        {
            TimeSpan timelimit = new TimeSpan();
            timelimit = theTime;
            List<Question> qL = new List<Question>();
            List<int> first = new List<int>();
            List<int> second = new List<int>();
            string testString = "";
            int limit = 10;
            int i;
            int j;
            int lowerBound = 0;
            int control = 0;
            if (isHard == true)
            {
                limit = 20;
                lowerBound = 10;
                int dontwriteint = 11;
                for (i = lowerBound; i < limit; i++)
                {
                    for (j = control; j < limit; j++)
                    {

                        if (j < dontwriteint)
                        {
                            if( i >= j)
                            {
                                if(j == 0)
                                {

                                }
                                else
                                {
                                    first.Add(i);
                                    second.Add(j);
                                }

                                if (SubtractFalse_DivideTrue == false)
                                {
                                    testString += i.ToString() + " - " + j.ToString() + ", ";
                                }
                                else
                                {
                                    testString += i.ToString() + " / " + j.ToString() + ", ";
                                }
                            }

                        }

                    }
                    dontwriteint++;
                    testString += "\n\n";
                }
            }
            else
            {
                for (i = lowerBound; i < limit; i++)
                {
                    for (j = control; j < limit; j++)
                    {
                        if (i >= j)
                        {
                            if (j == 0)
                            {

                            }
                            else
                            {
                                first.Add(i);
                                second.Add(j);
                            }
                            if (SubtractFalse_DivideTrue == false)
                            {
                                testString += i.ToString() + " - " + j.ToString() + ", ";
                            }
                            else
                            {
                                testString += i.ToString() + " / " + j.ToString() + ", ";
                            }
                        }
                    }
                }
                control++;
            }
            string qT;
            int[] answer = new int[500];
            if(SubtractFalse_DivideTrue == false )
            {
                var firstEnumerator = first.GetEnumerator();
                var secondEnumerator = second.GetEnumerator();
                //enumerate through the list
                while(firstEnumerator.MoveNext())
                {
                    int counter = 0;
                    secondEnumerator.MoveNext();
                    qT = firstEnumerator.Current.ToString() + " - " + secondEnumerator.Current.ToString() + " =";
                    answer[counter] = firstEnumerator.Current - secondEnumerator.Current;
                    Question aQuestion = new Question();
                    aQuestion.CorrectAnswer = answer[counter];
                    aQuestion.RandomlyGenerated = true;
                    aQuestion.QuestionText = qT;
                    aQuestion.TimeLimit = timelimit;
                    qL.Add(aQuestion);
                }
                    
                
            }
            else
            {
                var firstEnumerator = first.GetEnumerator();
                var secondEnumerator = second.GetEnumerator();
                //enumerate through the list
                while (firstEnumerator.MoveNext())
                {
                    int counter = 0;
                    secondEnumerator.MoveNext();
                    qT = firstEnumerator.Current.ToString() + " / " + secondEnumerator.Current.ToString() + " =";
                    answer[counter] = firstEnumerator.Current / secondEnumerator.Current;

                    Question aQuestion = new Question();
                    aQuestion.CorrectAnswer = answer[counter];
                    aQuestion.RandomlyGenerated = true;
                    aQuestion.QuestionText = qT;
                    aQuestion.TimeLimit = timelimit;
                    qL.Add(aQuestion);
                }
            }



            return qL;
        }
    }
}

