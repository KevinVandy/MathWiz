using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    //Class for inserting, updating, or deleting from the database
    public class MathWizDB
    {
        readonly static SqlConnection conn = MathWizConn.GetMathWizConnection();

        private void InsertParent(Parent newParent)
        {
            string insertStatement = "INSERT INTO parents (Username, FirstName, LastName, PasswordHash) " +
                "VALUES(@Username, @FirstName, @LastName, @Password)";
      
            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@Username", newParent.Username);
            Cmd.Parameters.AddWithValue("@FirstName", newParent.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", newParent.LastName);
            Cmd.Parameters.AddWithValue("@Password", newParent.Password);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        private void InsertStudent(Student newStudent)
        {
            string insertStatement = "INSERT INTO students (Username, FirstName, LastName, PasswordHash) " +
                "VALUES(@Username, @FirstName, @LastName, @Password)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@Username", newStudent.Username);
            Cmd.Parameters.AddWithValue("@FirstName", newStudent.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", newStudent.LastName);
            Cmd.Parameters.AddWithValue("@Password", newStudent.Password);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        private void InsertTeacher(Teacher newTeacher)
        {
            string insertStatement = "INSERT INTO teachers (Username, FirstName, LastName, PasswordHash) " +
                "VALUES(@Username, @FirstName, @LastName, @Password)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@Username", newTeacher.Username);
            Cmd.Parameters.AddWithValue("@FirstName", newTeacher.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", newTeacher.LastName);
            Cmd.Parameters.AddWithValue("@Password", newTeacher.Password);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        private void InsertAdmin(Admin newAdmin)
        {
            string insertStatement = "INSERT INTO admins (Username, FirstName, LastName, PasswordHash) " +
                "VALUES(@Username, @FirstName, @LastName, @Password)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@Username", newAdmin.Username);
            Cmd.Parameters.AddWithValue("@FirstName", newAdmin.FirstName);
            Cmd.Parameters.AddWithValue("@LastName", newAdmin.LastName);
            Cmd.Parameters.AddWithValue("@Password", newAdmin.Password);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        private void InsertQuestion(Question newQuestion, int testID)
        {
            string insertStatement = "INSERT INTO questions (TestID, MasteryLevel, QuestionText, CorrectAnswer, TimeLimit, Weight, RandomlyGenerated) " +
                "VALUES(@TestID, @MasteryLevel, @QuestionText, @CorrectAnswer, @TimeLimit, @Weight, @RNG)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TestID", testID);
            Cmd.Parameters.AddWithValue("@MasteryLevel", newQuestion.MasteryLevel);
            Cmd.Parameters.AddWithValue("@QuestionText", newQuestion.QuestionText);
            Cmd.Parameters.AddWithValue("@CorrectAnswer", newQuestion.CorrectAnswer);
            Cmd.Parameters.AddWithValue("@TimeLimit", newQuestion.TimeLimit);
            Cmd.Parameters.AddWithValue("@Weight", newQuestion.Weight);
            Cmd.Parameters.AddWithValue("@RNG", newQuestion.RandomlyGenerated);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        private void InsertKlass(Klass newKlass, int teacherID)
        {
            string insertStatement = "INSERT INTO klasses (TeacherID, KlassName) " +
                "VALUES(@TeacherID, @KlassName)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TeacherID", teacherID);
            Cmd.Parameters.AddWithValue("@KlassName", newKlass.KlassName);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        private void InsertTest(Test newTest, string testType, decimal passThreshold, int minLevel, int maxLevel)
        {
            //Everything besides TestType can be null
            string insertStatement = "INSERT INTO tests (TestType, TimeLimit, RandomlyGenerated, PassThreshHold, MinLevel, MaxLevel) " +
                "VALUES(@Type, @TimeLimit, @RNG, @PassThreshold, @MinLevel, @MaxLevel)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@Type", testType);
            Cmd.Parameters.AddWithValue("@TimeLimit", newTest.TimeLimit);
            Cmd.Parameters.AddWithValue("@RNG", newTest.RandomlyGenerated);
            Cmd.Parameters.AddWithValue("@PassThreshold", passThreshold);
            Cmd.Parameters.AddWithValue("@MinLevel", minLevel);
            Cmd.Parameters.AddWithValue("@MaxLevel", maxLevel);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        private void InsertGradedQuestion(GradedQuestion newQuestion, int questionID, int gradedTestID)
        {
            string insertStatement = "INSERT INTO graded_questions (GradedTestID, QuestionID, StudentAnswer, Correct, TimeTakenToAnswer) " +
                "VALUES(@TestID, @QuestionID, @StudentAnswer, @Correct, @Time)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TestID", gradedTestID);
            Cmd.Parameters.AddWithValue("@QuestionID", questionID);
            Cmd.Parameters.AddWithValue("@StudentAnswer", newQuestion.StudentAnswer);
            Cmd.Parameters.AddWithValue("@Correct", newQuestion.Correct);
            Cmd.Parameters.AddWithValue("@Time", newQuestion.TimeTakenToAnswer);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }

        private void InsertGradedTest(GradedTest newTest, int studentID, int testID, int attempts, byte passed, int recommendedLevel)
        {
            // StudentID, TestID, and Score must be present
            // Everything else can be null
            string insertStatement = "INSERT INTO graded_tests (StudentID, TestID, Score, TimeTakenToComplete, DateTaken, Feedback, NumberAttempts, Passed, RecommendedLevel) " +
                "VALUES(@StudentID, @TestID, @Score, @Time, @DateTaken, @Feedback, @Attempts, @Passed, @RecommendLevel)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@StudentID", studentID);
            Cmd.Parameters.AddWithValue("@TestID", testID);
            Cmd.Parameters.AddWithValue("@Score", newTest.Score);
            Cmd.Parameters.AddWithValue("@Time", newTest.TimeTakenToComplete);
            Cmd.Parameters.AddWithValue("@DateTaken", newTest.DateTaken);
            Cmd.Parameters.AddWithValue("@Feedback", newTest.Feedback);
            Cmd.Parameters.AddWithValue("@Attempts", attempts);
            Cmd.Parameters.AddWithValue("@Passed", passed);
            Cmd.Parameters.AddWithValue("@RecommendLevel", recommendedLevel);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // always close the connection
                conn.Close();
            }
        }
    }
}
