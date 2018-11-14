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
    //Class for reading (selecting) information from the database
    public class MathWizDA
    {
        readonly static SqlConnection conn = MathWizConn.GetMathWizConnection();

        //Begin Find Users Methods - used for finding out which type of user is logging in
        public static bool FindAdmin(string username)
        {
            string query = "SELECT Username FROM admins WHERE Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@Username", username);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read() && reader.HasRows) //if true, this means that it found a record with the username
                {
                    reader.Close();
                    conn.Close();
                    return true;
                }
                reader.Close();
            }
            catch(SqlException ex)
            { 
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return false;
        }

        public static bool FindTeacher(string username)
        {
            string query = "SELECT Username FROM teachers WHERE Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@Username", username);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read() && reader.HasRows) //if true, this means that it found a record with the username
                {
                    reader.Close();
                    conn.Close();
                    return true;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return false;
        }

        public static bool FindParent(string username)
        {
            string query = "SELECT Username FROM parents WHERE Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@Username", username);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read() && reader.HasRows) //if true, this means that it found a record with the username
                {
                    reader.Close();
                    return true;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return false;
        }

        public static bool FindStudent(string username)
        {
            string query = "SELECT Username FROM students WHERE Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@Username", username);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read() && reader.HasRows) //if true, this means that it found a record with the username
                {
                    reader.Close();
                    conn.Close();
                    return true;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return false;
        }
        //End Find Users Methods

        //Begin SELECT Users Methods
        public static Admin SelectAdmin(string username)
        {
            //make the object that will eventually get returned
            Admin admin = new Admin();
            
            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM admins Where Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    admin.Username = Convert.ToString(reader["Username"]);
                    admin.FirstName = Convert.ToString(reader["FirstName"]);
                    admin.LastName = Convert.ToString(reader["LastName"]);
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return admin;
        }

        public static Teacher SelectTeacher(string username)
        {
            //make the object that will eventually get returned
            Teacher teacher = new Teacher();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM teachers Where Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    teacher.Username = Convert.ToString(reader["Username"]);
                    teacher.FirstName = Convert.ToString(reader["FirstName"]);
                    teacher.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return teacher;
        }

        public static Student SelectStudent(string username)
        {
            //make the object that will eventually get returned
            Student student = new Student();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM students Where Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    student.Username = Convert.ToString(reader["Username"]);
                    student.FirstName = Convert.ToString(reader["FirstName"]);
                    student.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return student;
        }

        public static Parent SelectParent(string username)
        {
            //make the object that will eventually get returned
            Parent parent = new Parent();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM parents Where Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    parent.Username = Convert.ToString(reader["Username"]);
                    parent.FirstName = Convert.ToString(reader["FirstName"]);
                    parent.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return parent;
        }
        //End SELECT Users Methods

        public static PracticeTest SelectPracTest(int id)
        {
            //make the object that will eventually get returned
            PracticeTest pracTest = new PracticeTest();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM PracticeTest WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    //pracTest.Username = Convert.ToString(reader["Username"]);
                    //pracTest.FirstName = Convert.ToString(reader["FirstName"]);
                    //pracTest.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return pracTest;
        }

        public static PlacementTest SelectPlaceTest(int id)
        {
            //make the object that will eventually get returned
            PlacementTest placeTest = new PlacementTest();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM PlacementTests WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    //placeTest.Username = Convert.ToString(reader["Username"]);
                    //placeTest.FirstName = Convert.ToString(reader["FirstName"]);
                    //placeTest.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return placeTest;
        }

        public static MasteryTest SelectMastTest(int id)
        {
            //make the object that will eventually get returned
            MasteryTest mastTest = new MasteryTest();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM MasteryTests WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    //mastTest.Username = Convert.ToString(reader["Username"]);
                    //mastTest.FirstName = Convert.ToString(reader["FirstName"]);
                    //mastTest.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return mastTest;
        }

        public static Question SelectQuestion(int id)
        {
            //make the object that will eventually get returned
            Question question = new Question();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM Questions WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    //question.Username = Convert.ToString(reader["Username"]);
                    //question.FirstName = Convert.ToString(reader["FirstName"]);
                    //question.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return question;
        }

        public static GradedPracticeTest SelectGradePrac(int id)
        {
            //make the object that will eventually get returned
            GradedPracticeTest gradePrac = new GradedPracticeTest();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM GradedPracticeTests WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    //gradePrac.Username = Convert.ToString(reader["Username"]);
                    //gradePrac.FirstName = Convert.ToString(reader["FirstName"]);
                    //gradePrac.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return gradePrac;
        }

        public static GradedPlacementTest SelectGradePlace(int id)
        {
            //make the object that will eventually get returned
            GradedPlacementTest gradePlace = new GradedPlacementTest();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM GradedPlacementTests WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    //gradePlace.Username = Convert.ToString(reader["Username"]);
                    //gradePlace.FirstName = Convert.ToString(reader["FirstName"]);
                    //gradePlace.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return gradePlace;
        }

        public static GradedMasteryTest SelectGradeMaster(int id)
        {
            //make the object that will eventually get returned
            GradedMasteryTest gradeMaster = new GradedMasteryTest();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM GradedMasteryTests WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    //gradeMaster.Username = Convert.ToString(reader["Username"]);
                    //gradeMaster.FirstName = Convert.ToString(reader["FirstName"]);
                    //gradeMaster.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return gradeMaster;
        }

        public static GradedQuestion SelectGradeQuestions(int id)
        {
            //make the object that will eventually get returned
            GradedQuestion gradeQuestion = new GradedQuestion();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM GradedQuestions WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    //gradeQuestion.Username = Convert.ToString(reader["Username"]);
                    //gradeQuestion.FirstName = Convert.ToString(reader["FirstName"]);
                    //gradeQuestion.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return gradeQuestion;
        }

        public static Klass SelectKlass(int id)
        {
            //make the object that will eventually get returned
            Klass klass = new Klass();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM Klasses WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            //try the select command
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) //use 'if' if you are selecting 1 record, but use 'while' if selecting more than 1 record
                {
                    //might need to change table names after the real database is made
                    //klass.Username = Convert.ToString(reader["Username"]);
                    //klass.FirstName = Convert.ToString(reader["FirstName"]);
                    //klass.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database SQL Exception\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Generic Exception.\n\n" + ex.ToString(), "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return klass;
        }
    }
}
