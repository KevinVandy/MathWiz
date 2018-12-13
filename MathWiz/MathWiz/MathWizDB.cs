using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    //Class for inserting, updating, or deleting from the database
    public static class MathWizDB
    {
        readonly static SqlConnection conn = MathWizConn.GetMathWizConnection();
        
        //MARK Inserting Accounts
        public static void InsertAdmin(Admin newAdmin)
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void InsertParent(Parent newParent)
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

        public static void InsertTeacher(Teacher newTeacher)
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
                conn.Open();
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void InsertStudent(Student newStudent, int parentID, int klassID)
        {
            string insertStatement = "INSERT INTO students (ParentID, KlassID, Username, FirstName, LastName, PasswordHash) " +
                "VALUES(@ParentID, @KlassID, @Username, @FirstName, @LastName, @Password)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@ParentID", parentID);
            Cmd.Parameters.AddWithValue("@KlassID", klassID);
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        //End Inserting Accounts
        
        //MARK Inserting Klass and Test Stuff
        public static void InsertKlass(Klass newKlass, int teacherID)
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static int InsertTest(int klassID, Test test, string testType, decimal passThreshold, int minLevel, int maxLevel)
        {
            test.Id = 0;

            //Everything besides TestType can be null
            string insertStatement = "INSERT INTO tests (KlassID, TestType, TimeLimit, RandomlyGenerated, PassThreshHold, MinLevel, MaxLevel)"
                                   + " OUTPUT INSERTED.Id" //get the last inserted ID
                                   + " VALUES(@KlassID, @Type, @TimeLimit, @RNG, @PassThreshold, @MinLevel, @MaxLevel)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@KlassID", klassID);
            Cmd.Parameters.AddWithValue("@Type", testType);
            Cmd.Parameters.AddWithValue("@TimeLimit", test.TimeLimit);
            Cmd.Parameters.AddWithValue("@RNG", test.RandomlyGenerated);
            Cmd.Parameters.AddWithValue("@PassThreshold", passThreshold);
            Cmd.Parameters.AddWithValue("@MinLevel", minLevel);
            Cmd.Parameters.AddWithValue("@MaxLevel", maxLevel);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                test.Id = Convert.ToInt32(Cmd.ExecuteScalar());

                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                //now insert the questions in the test
                for (int i = 0; i < test.Questions.Count; i++)
                {
                    test.Questions[i].Id = MathWizDB.InsertQuestion(test.Questions[i], test.Id);
                }

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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return test.Id;
        }

        public static int InsertQuestion(Question question, int testID)
        {
            question.Id = 0;

            string insertStatement = "INSERT INTO questions (TestID, MasteryLevel, QuestionText, CorrectAnswer, TimeLimit, Weight, RandomlyGenerated)"
                + " OUTPUT INSERTED.Id" //get the last inserted ID
                + " VALUES(@TestID, @MasteryLevel, @QuestionText, @CorrectAnswer, @TimeLimit, @Weight, @RNG)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TestID", testID);
            Cmd.Parameters.AddWithValue("@MasteryLevel", question.MasteryLevel);
            Cmd.Parameters.AddWithValue("@QuestionText", question.QuestionText);
            Cmd.Parameters.AddWithValue("@CorrectAnswer", question.CorrectAnswer);
            Cmd.Parameters.AddWithValue("@TimeLimit", question.TimeLimit);
            Cmd.Parameters.AddWithValue("@Weight", question.Weight);
            Cmd.Parameters.AddWithValue("@RNG", question.RandomlyGenerated);

            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                question.Id = Convert.ToInt32(Cmd.ExecuteScalar());
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return question.Id;
        }

        public static int InsertGradedTest(GradedTest gradedTest, int studentID, int testID, string testType, int? recommendedLevel = 0, int? attempts = 1, bool? passed = true)
        {
            gradedTest.Id = 0;

            string insertStatement = "INSERT INTO graded_tests"
                                   + " (StudentID, TestID, TestType, Score, TimeTakenToComplete, DateTaken, Feedback, NumberAttempts, Passed, RecommendedLevel)"
                                   + " OUTPUT INSERTED.ID" //get the last inserted ID
                                   + " VALUES(@StudentID, @TestID, @TestType, @Score, @Time, @DateTaken, @Feedback, @Attempts, @Passed, @RecommendLevel)";

            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            Cmd.Parameters.AddWithValue("@StudentID", studentID);
            Cmd.Parameters.AddWithValue("@TestID", testID);
            Cmd.Parameters.AddWithValue("@TestType", testType);
            Cmd.Parameters.AddWithValue("@Score", gradedTest.Score);
            Cmd.Parameters.AddWithValue("@Time", gradedTest.TimeTakenToComplete);
            Cmd.Parameters.AddWithValue("@DateTaken", gradedTest.DateTaken);
            Cmd.Parameters.AddWithValue("@Feedback", gradedTest.Feedback);
            Cmd.Parameters.AddWithValue("@Attempts", attempts);
            Cmd.Parameters.AddWithValue("@Passed", passed);
            Cmd.Parameters.AddWithValue("@RecommendLevel", recommendedLevel);
            
            try
            {
                // Open the connection
                conn.Open();

                // execute the query
                gradedTest.Id = Convert.ToInt32(Cmd.ExecuteScalar());

                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                //after inserting the graded test, insert the graded questions too
                foreach (GradedQuestion q in gradedTest.CorrectlyAnsweredQuestions)
                {
                    InsertGradedQuestion(q, gradedTest.Id);
                }

                foreach (GradedQuestion q in gradedTest.WronglyAnsweredQuestions)
                {
                    InsertGradedQuestion(q, gradedTest.Id);
                }
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return gradedTest.Id;
        }

        public static void InsertGradedQuestion(GradedQuestion gradedQuestion, int gradedTestID)
        {
            string insertStatement = "INSERT INTO graded_questions (GradedTestID, QuestionID, StudentAnswer, Correct, TimeTakenToAnswer) " +
                "VALUES(@TestID, @QuestionID, @StudentAnswer, @Correct, @Time)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TestID", gradedTestID);
            Cmd.Parameters.AddWithValue("@QuestionID", gradedQuestion.Question.Id);
            Cmd.Parameters.AddWithValue("@StudentAnswer", gradedQuestion.StudentAnswer);
            Cmd.Parameters.AddWithValue("@Correct", gradedQuestion.Correct);
            Cmd.Parameters.AddWithValue("@Time", gradedQuestion.TimeTakenToAnswer);

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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        //END inserting klass and test stuff

        public static void UpdatePassword(string userType, string username, string passwordHash)
        {
            string insertStatement = "UPDATE";

            switch (userType) //need this case structure because you can't bind values to a table name, and I want to do it the safe way without {}
            {
                case "admin":
                    insertStatement += " admins ";
                    break;

                case "teacher":
                    insertStatement += " teachers ";
                    break;

                case "parent":
                    insertStatement += " parents ";
                    break;

                case "student":
                    insertStatement += " students ";
                    break;

            }

            insertStatement += "SET PasswordHash = @passwordHash WHERE Username = @username";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);
            Cmd.Parameters.AddWithValue("@username", username);
            Cmd.Parameters.AddWithValue("@passwordHash", passwordHash);
            
            try
            {
                conn.Open();
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void UpdateMasteryLevel(string username, int newML)
        {
            string insertStatement = "UPDATE students SET MasteryLevel = @newML WHERE Username = @username";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);
            Cmd.Parameters.AddWithValue("@username", username);
            Cmd.Parameters.AddWithValue("@newML", newML);

            try
            {
                conn.Open();
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void DeleteUser(string userType, int id, string username) //very important to get this command and security right
        {
            string insertStatement = "";

            switch (userType) //need this case structure because you can't bind values to a table name, and I want to do it the safe way without {}
            {
                case "admin":
                    insertStatement = "DELETE FROM admins ";
                    break;

                case "teacher":
                    insertStatement = "DELETE FROM teachers ";
                    break;

                case "parent":
                    insertStatement = "DELETE FROM parents ";
                    break;

                case "student":
                    insertStatement = "DELETE FROM students ";
                    break;
            }

            insertStatement += "Where Id = @id AND Username = @username"; //Keep this WHERE statement here at all costs!!!
            
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);
            Cmd.Parameters.AddWithValue("@id", id);
            Cmd.Parameters.AddWithValue("@username", username);

            try
            {
                conn.Open();
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void DeleteGradedTest(int studentID)
        {
            string deleteStatement = "DELETE FROM graded_tests WHERE StudentID = @studentID";
            SqlCommand Cmd = new SqlCommand(deleteStatement, conn);
            Cmd.Parameters.AddWithValue("@studentID", studentID);
            try
            {
                conn.Open();
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void DeleteGradedTestWithTestID(int testID)
        {
            string deleteStatement = "DELETE FROM graded_tests WHERE TestID = @testID";
            SqlCommand Cmd = new SqlCommand(deleteStatement, conn);
            Cmd.Parameters.AddWithValue("@testID", testID);
            try
            {
                conn.Open();
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void DeleteNormalTest(int testID)
        {
            string deleteStatement = "DELETE FROM tests WHERE Id = @testID";
            SqlCommand Cmd = new SqlCommand(deleteStatement, conn);
            Cmd.Parameters.AddWithValue("@testID", testID);
            try
            {
                conn.Open();
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void DeleteNormalQuestions(int testID)
        {
            string deleteStatement = "DELETE FROM questions WHERE TestID = @testID";
            SqlCommand Cmd = new SqlCommand(deleteStatement, conn);
            Cmd.Parameters.AddWithValue("@TestID", testID);
            try
            {
                conn.Open();
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static void DeleteGradedQuestions(int gradedTestID)
        {
            string deleteStatement = "DELETE FROM graded_questions WHERE GradedTestID = @gradedTestID";
            SqlCommand Cmd = new SqlCommand(deleteStatement, conn);
            Cmd.Parameters.AddWithValue("@gradedTestID", gradedTestID);
            try
            {
                conn.Open();
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
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
