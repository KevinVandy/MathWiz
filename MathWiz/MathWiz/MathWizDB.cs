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
            string insertStatement = "INSERT INTO parent (Username, FirstName, LastName, PasswordHash) " +
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
            string insertStatement = "INSERT INTO student (Username, FirstName, LastName, PasswordHash) " +
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
            string insertStatement = "INSERT INTO teacher (Username, FirstName, LastName, PasswordHash) " +
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
            string insertStatement = "INSERT INTO admin (Username, FirstName, LastName, PasswordHash) " +
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

        private void InsertMasteryTest(MasteryTest newTest)
        {
            string insertStatement = "INSERT INTO mastery_test (TimeLimit, RandomlyGenerated, PassThreshold) " +
                "VALUES(@TimeLimit, @RNG, @PassThreshold)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TimeLimit", newTest.TimeLimit);
            Cmd.Parameters.AddWithValue("@RNG", newTest.RandomlyGenerated);
            Cmd.Parameters.AddWithValue("@PassThreshold", newTest.PassThreshhold);

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

        private void InsertPlacementTest(PlacementTest newTest)
        {
            string insertStatement = "INSERT INTO placement_test (TimeLimit, RandomlyGenerated, MinLevel, MaxLevel) " +
                "VALUES(@TimeLimit, @RNG, @Min, @Max)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TimeLimit", newTest.TimeLimit);
            Cmd.Parameters.AddWithValue("@RNG", newTest.RandomlyGenerated);
            Cmd.Parameters.AddWithValue("@Min", newTest.MinLevel);
            Cmd.Parameters.AddWithValue("@Max", newTest.MaxLevel);

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

        private void InsertPracticeTest(PracticeTest newTest)
        {
            string insertStatement = "INSERT INTO placement_test (TimeLimit, RandomlyGenerated, MinLevel, MaxLevel) " +
                "VALUES(@TimeLimit, @RNG, @Min, @Max)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            Cmd.Parameters.AddWithValue("@TimeLimit", newTest.TimeLimit);
            Cmd.Parameters.AddWithValue("@RNG", newTest.RandomlyGenerated);
            Cmd.Parameters.AddWithValue("@Min", newTest.MinLevel);
            Cmd.Parameters.AddWithValue("@Max", newTest.MaxLevel);

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

        private void InsertQuestion(Question newQuestion, Test aTest)
        {
            string insertStatement = "INSERT INTO question (TestID, MasteryLevel, QuestionText, CorrectAnswer, TimeLimit, Weight, RandomlyGenerated) " +
                "VALUES(@TestID, @MasteryLevel, @QuestionText, @CorrectAnswer, @TimeLimit, @Weight, @RNG)";

            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand(insertStatement, conn);

            // create your parameters and add values from object
            // Where am I grabbing TestID, None of our Tests have ID properties
            // - Ryan
            Cmd.Parameters.AddWithValue("@TestID", newQuestion);
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
    }
}
