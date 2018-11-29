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

            easyRandoms = Enumerable.Range(0, 10).OrderBy(x => rnd.Next()).Take(10).ToList();
            return easyRandoms;
        }

        public static List<int> GenerateHardRandomNumbers(int start, int count)
        {
            Random rnd = new Random();
            hardRandoms = Enumerable.Range(10, 10).OrderBy(x => rnd.Next()).Take(10).ToList();
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

        public static List<Question> GenerateRandomQuestions(int masteryLevel, TimeSpan timeLimit, int numberofQuestions)
        {
            List<Question> qL = new List<Question>();
            

            int caseswitch = masteryLevel;
            switch(masteryLevel)
            {
                case 1:
                    qL = GenerateSimpleAddtionQuestions(timeLimit, numberofQuestions);
                    break;
                case 2:
                    qL = GenerateSimpleSubtractionQuestions(timeLimit);
                    break;
                case 3:
                    qL = GenerateMixedSimpleAdditionSubtraction(timeLimit);
                    break;
                case 4:
                    qL = GenerateComplexAddition(timeLimit);
                    break;
                case 5:
                    qL = GenerateComplexSubtraction(timeLimit);
                    break;
                case 6:
                    qL = GenerateMixedComplexAdditionSubtraction(timeLimit);
                    break;
                case 7:
                    qL = GenerateSimpleMultiplication(timeLimit);
                    break;
                case 8:
                    qL = GenerateSimpleDivision(timeLimit);
                    break;
                case 9:
                    qL = GenerateSimpleMultiplicationDivision(timeLimit);
                    break;
                case 10:
                    qL = GenerateAdvancedMultiplication(timeLimit);
                    break;
                case 11:
                    qL = GenerateAdvancedDivision(timeLimit);
                    break;
                case 12:
                    qL = GenerateAdvnacedMultiplicationDivison(timeLimit);
                    break;
                default:
                    MessageBox.Show("No known case check that what you passed is within range");
                    break;
                    

            }
            return qL;

        }

        private static List<Question> GenerateAdvnacedMultiplicationDivison(TimeSpan timelimit)
        {
            GeneratesAddMultiply(true, true);
            throw new NotImplementedException();
        }

        private static List<Question> GenerateAdvancedDivision(TimeSpan timelimit)
        {
            throw new NotImplementedException();
        }

        private static List<Question> GenerateAdvancedMultiplication(TimeSpan timelimit)
        {
            GeneratesAddMultiply(true, true);
            throw new NotImplementedException();
        }

        private static List<Question> GenerateSimpleMultiplicationDivision(TimeSpan timelimit)
        {
            GeneratesAddMultiply(false, true);
            throw new NotImplementedException();
        }

        private static List<Question> GenerateSimpleDivision(TimeSpan timelimit)
        {
            throw new NotImplementedException();
        }

        private static List<Question> GenerateSimpleMultiplication(TimeSpan timelimit)
        {
            GeneratesAddMultiply(false, true);
            throw new NotImplementedException();
        }

        private static List<Question> GenerateMixedComplexAdditionSubtraction(TimeSpan timelimit)
        {
            GeneratesAddMultiply(true, false);
            throw new NotImplementedException();
        }

        private static List<Question> GenerateComplexSubtraction(TimeSpan timelimit)
        {
            throw new NotImplementedException();
        }

        private static List<Question> GenerateComplexAddition(TimeSpan timelimit)
        {
            GeneratesAddMultiply(true, false);
            throw new NotImplementedException();
        }

        private static List<Question> GenerateMixedSimpleAdditionSubtraction(TimeSpan timelimit)
        {
            GeneratesAddMultiply(false, false);
            string questionText;
            List<Question> qL = new List<Question>();
            List<Question> add = new List<Question>();
            List<Question> sub = new List<Question>();
            add = GenerateSimpleAddtionQuestions(timelimit, 10);
            sub = GenerateSimpleSubtractionQuestions(timelimit);

            //List<int> easyAdd = new List<int>();
            //List<int> easyAddSecond = new List<int>();
            //List<int> easySub = new List<int>();
            //List<int> easyTakeFrom = new List<int>();
            //int[] answer = new int[10];
            //easyAdd = GenerateEasyRandomNumbers();
            //easyAddSecond = GenerateEasyRandomNumbers();
            //easySub = GenerateEasyRandomNumbers();

            //var easyEnumerator = easySub.GetEnumerator();
            ////enumerate through the list
            //while (easyEnumerator.MoveNext())
            //{
            //    int counter = 0;
            //    int lower = GetRandomNumberLowerThan(easyEnumerator.Current);
            //    answer[counter] = easyEnumerator.Current - lower;
            //    questionText = easyEnumerator.Current.ToString() + " - " + lower.ToString() + " = ";
            //    Question aQuestion = new Question();
            //    aQuestion.QuestionText = questionText;
            //    aQuestion.CorrectAnswer = answer[counter];
            //    aQuestion.TimeLimit = timelimit;

            //    testQuestions.Add(aQuestion);
            //    //MessageBox.Show("First Number = " + easyEnumerator.Current.ToString() + "\n" +
            //    //                "Second Number =" + lower.ToString() + "\n" + 
            //    //                "Equals = " + answer[counter].ToString() + "\n" +
            //    //                "Text = " + questionText);

            //    counter++;
            //}

            return qL;

        }

        private static List<Question> GenerateSimpleSubtractionQuestions(TimeSpan timelimit)
        {
            string questionText;
            List <Question> qL = new List<Question>();
            List<int> easy = GenerateEasyRandomNumbers(0, 10);
            List<int> takefrom = new List<int>();
            int[] answer = new int[10];
            
            var easyEnumerator = easy.GetEnumerator();
            //enumerate through the list
            while(easyEnumerator.MoveNext())
            {
                int counter = 0;
                int lower = GetRandomNumberLowerThan(easyEnumerator.Current);
                answer[counter] = easyEnumerator.Current - lower;
                questionText = easyEnumerator.Current.ToString() + " - " + lower.ToString() + " = ";
                Question aQuestion = new Question();
                aQuestion.QuestionText = questionText;
                aQuestion.CorrectAnswer = answer[counter];
                aQuestion.TimeLimit = timelimit;
                
                testQuestions.Add(aQuestion);
                //MessageBox.Show("First Number = " + easyEnumerator.Current.ToString() + "\n" +
                //                "Second Number =" + lower.ToString() + "\n" + 
                //                "Equals = " + answer[counter].ToString() + "\n" +
                //                "Text = " + questionText);

                counter++;
            }
            

            return qL;
        }

        public static List<Question> GenerateSimpleAddtionQuestions(TimeSpan timelimit, int NumberOfQuestions)
        {
            GeneratesAddMultiply(false, false);
            string questionText;
            List<int> firstEasy = GenerateEasyRandomNumbers(0, 10);
            List<int> secondEasy = GenerateEasyRandomNumbers(0, 10);
            var firstEasyEnumerator = firstEasy.GetEnumerator();
            int[] answer = new int[10];
            var secondEasyEnumerator = secondEasy.GetEnumerator();
            var answerEnumerator = answer.GetEnumerator();
            //enumerate through the lists
            while(firstEasyEnumerator.MoveNext())
            {
                int counter = 0;
                secondEasyEnumerator.MoveNext();
                answerEnumerator.MoveNext();
                answer[counter] = ((firstEasyEnumerator.Current) + (secondEasyEnumerator.Current));
                questionText = firstEasyEnumerator.Current.ToString() + " + " + secondEasyEnumerator.Current.ToString() + " = ";
                //MessageBox.Show("FirstNumber: " + firstEasyEnumerator.Current.ToString() + "\n" +
                //                "SecondNumber: " + secondEasyEnumerator.Current.ToString() + "\n" +
                //                "Answer: " + answer[counter].ToString() + "\n" +
                //                "theText: " + questionText);
                Question question = new Question();
                question.QuestionText = questionText;
                question.CorrectAnswer = answer[counter];
                question.TimeLimit = timelimit;
                counter++;
                testQuestions.Add(question);
            }

            //foreach(Question q in testQuestions)
            //{
            //    MessageBox.Show(q.QuestionText + q.CorrectAnswer.ToString());
            //}
            return testQuestions;

        }

        private static int GetRandomNumberLowerThan(int upperbound)
        {
            int aNumber = 0;
            aNumber = rnd.Next(upperbound + 1);
            return aNumber;
            
        }



        public static List<Question> GeneratesAddMultiply(bool isHard, bool AddFalse_MultiplyTrue)
        {
            TimeSpan timeLimit = new TimeSpan();
            timeLimit = TimeSpan.FromTicks(5000);
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

        public static List<Question> GeneratesSubtractDivide(bool isHard, bool SubtractFalse_DivideTrue)
        {
            TimeSpan timelimit = new TimeSpan();
            timelimit = TimeSpan.FromTicks(5000);
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

