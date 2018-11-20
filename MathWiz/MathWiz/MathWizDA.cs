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


        public static Int64 GetLastInsertedRecord(string tablename, string fieldname)
        {  Int64 aNumber = 0;

            string query = "Select @fieldname from @tablename where @fieldname =(select max@fieldname) from @tablename)";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@tablename", tablename);
            selectCommand.Parameters.AddWithValue("@fieldname", fieldname);

            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                if(reader.Read() && reader.HasRows)
                {
                    aNumber = Convert.ToInt64(reader[""]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            return aNumber;

        }
           
            
        
    //Begin Find Users Methods - used for finding out which type of user is logging in
    public static bool FindUsername(string username) //Find out if a username has already been taken in any of the user tables
        {
            string query = "SELECT Username FROM admins WHERE Username = @username " +
                     "UNION SELECT Username FROM teachers WHERE Username = @username " +
                     "UNION SELECT Username FROM parents WHERE Username = @username " +
                     "UNION SELECT Username FROM students WHERE Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

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
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

        public static string FindUserType(string username)
        {
            string userType = "";

            string query = "SELECT 'admin' FROM admins WHERE Username = @username " +
                     "UNION SELECT 'teacher' FROM teachers WHERE Username = @username " +
                     "UNION SELECT 'parent' FROM parents WHERE Username = @username " +
                     "UNION SELECT 'student' FROM students WHERE Username = @username ";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@Username", username);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read() && reader.HasRows)
                {
                    userType = Convert.ToString(reader[""]);
                }
                else //could not find that username in any of the 4 tables
                {
                    userType = "none";
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return userType;
        }

        //SELECT Password - still untested
        public static string SelectPasswordHash(string username)
        {
            string passwordHash = "";

            string query = "SELECT PasswordHash FROM admins WHERE Username = @username " +
                     "UNION SELECT PasswordHash FROM teachers WHERE Username = @username " +
                     "UNION SELECT PasswordHash FROM parents WHERE Username = @username " +
                     "UNION SELECT PasswordHash FROM students WHERE Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    passwordHash = Convert.ToString(reader["PasswordHash"]);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return passwordHash;
        }
    

        //Begin SELECT Single Users Methods
        public static Admin SelectAdmin(string username)
        {
            //make the object that will eventually get returned
            Admin admin = new Admin();
            
            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM admins Where Username = @username";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@username", username);

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    admin.Username = Convert.ToString(reader["Username"]);
                    admin.FirstName = Convert.ToString(reader["FirstName"]);
                    admin.LastName = Convert.ToString(reader["LastName"]);
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    teacher.Id = Convert.ToInt16(reader["Id"]);
                    teacher.Username = Convert.ToString(reader["Username"]);
                    teacher.FirstName = Convert.ToString(reader["FirstName"]);
                    teacher.LastName = Convert.ToString(reader["LastName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    student.Username = Convert.ToString(reader["Username"]);
                    student.FirstName = Convert.ToString(reader["FirstName"]);
                    student.LastName = Convert.ToString(reader["LastName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    parent.Username = Convert.ToString(reader["Username"]);
                    parent.FirstName = Convert.ToString(reader["FirstName"]);
                    parent.LastName = Convert.ToString(reader["LastName"]);
                    parent.Id = Convert.ToInt32(reader["Id"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

        public static List<Student> SelectStudentsViaParent(int parentID)
        {
            List<Student> students = new List<Student>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM students WHERE ParentID = @ParentID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@ParentID", parentID);

            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt16(reader["Id"]);
                    student.Username = Convert.ToString(reader["Username"]);
                    student.FirstName = Convert.ToString(reader["FirstName"]);
                    student.LastName = Convert.ToString(reader["LastName"]);
                    student.MasteryLevel = Convert.ToInt16(reader["MasteryLevel"]);

                    students.Add(student);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return students;
        }
        //End SELECT Single Users Methods

        //Begin SELECT ALL Users Methods
        public static List<Admin> SelectAllAdmins()
        {
            List<Admin> admins = new List<Admin>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM admins";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Admin admin = new Admin();
                    admin.Id = Convert.ToInt16(reader["Id"]);
                    admin.Username = Convert.ToString(reader["Username"]);
                    admin.FirstName = Convert.ToString(reader["FirstName"]);
                    admin.LastName = Convert.ToString(reader["LastName"]);

                    admins.Add(admin);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return admins;
        }

        public static List<Teacher> SelectAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM teachers";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                
                while (reader.Read())
                {
                    Teacher teacher = new Teacher();
                    teacher.Id = Convert.ToInt16(reader["Id"]);
                    teacher.Username = Convert.ToString(reader["Username"]);
                    teacher.FirstName = Convert.ToString(reader["FirstName"]);
                    teacher.LastName = Convert.ToString(reader["LastName"]);

                    teachers.Add(teacher);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return teachers;
        }

        public static List<Parent> SelectAllParents()
        {
            List<Parent> parents = new List<Parent>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM parents";
            SqlCommand selectCommand = new SqlCommand(query, conn);

            
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                
                while (reader.Read()) 
                {
                    Parent parent = new Parent();
                    parent.Id = Convert.ToInt16(reader["Id"]);
                    parent.Username = Convert.ToString(reader["Username"]);
                    parent.FirstName = Convert.ToString(reader["FirstName"]);
                    parent.LastName = Convert.ToString(reader["LastName"]);

                    parents.Add(parent);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return parents;
        }

        public static List<Student> SelectAllStudents()
        {
            List<Student> students = new List<Student>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM students";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                
                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt16(reader["Id"]);
                    student.Username = Convert.ToString(reader["Username"]);
                    student.FirstName = Convert.ToString(reader["FirstName"]);
                    student.LastName = Convert.ToString(reader["LastName"]);
                    student.MasteryLevel = Convert.ToInt16(reader["MasteryLevel"]);

                    students.Add(student);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return students;
        }

        //End SELECT ALL Users Methods

        public static PracticeTest SelectPracTest(int id)
        {
            //make the object that will eventually get returned
            PracticeTest pracTest = new PracticeTest();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM PracticeTest WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    //pracTest.Username = Convert.ToString(reader["Username"]);
                    //pracTest.FirstName = Convert.ToString(reader["FirstName"]);
                    //pracTest.LastName = Convert.ToString(reader["LastName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    //placeTest.Username = Convert.ToString(reader["Username"]);
                    //placeTest.FirstName = Convert.ToString(reader["FirstName"]);
                    //placeTest.LastName = Convert.ToString(reader["LastName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    //mastTest.Username = Convert.ToString(reader["Username"]);
                    //mastTest.FirstName = Convert.ToString(reader["FirstName"]);
                    //mastTest.LastName = Convert.ToString(reader["LastName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    //question.Username = Convert.ToString(reader["Username"]);
                    //question.FirstName = Convert.ToString(reader["FirstName"]);
                    //question.LastName = Convert.ToString(reader["LastName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    //gradePrac.Username = Convert.ToString(reader["Username"]);
                    //gradePrac.FirstName = Convert.ToString(reader["FirstName"]);
                    //gradePrac.LastName = Convert.ToString(reader["LastName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    //gradePlace.Username = Convert.ToString(reader["Username"]);
                    //gradePlace.FirstName = Convert.ToString(reader["FirstName"]);
                    //gradePlace.LastName = Convert.ToString(reader["LastName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    //gradeMaster.Username = Convert.ToString(reader["Username"]);
                    //gradeMaster.FirstName = Convert.ToString(reader["FirstName"]);
                    //gradeMaster.LastName = Convert.ToString(reader["LastName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

        public static GradedQuestion SelectGradeQuestion(int id)
        {
            //make the object that will eventually get returned
            GradedQuestion gradeQuestion = new GradedQuestion();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM GradedQuestions WHERE ID = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@BranchName", id);

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    gradeQuestion.Id = Convert.ToInt16(reader["QuestionID"]);
                    gradeQuestion.StudentAnswer = Convert.ToString(reader["StudentAnswer"]);
                    gradeQuestion.Correct = Convert.ToBoolean(reader["Correct"]);
                    gradeQuestion.TimeTakenToAnswer = TimeSpan.Parse(reader["TimeTakenToAnswer"].ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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
            string query = "SELECT * FROM Klasses WHERE Id = @ID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@Id", id);

            
            try
            {
                conn.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    klass.KlassName = Convert.ToString(reader["KlassName"]);
                    
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
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

        public static List<Student> SelectAllStudentsInKlass(int klassID)
        {
            List<Student> students = new List<Student>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM students WHERE KlassID = @klassID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@klassID", klassID);

            try
            {
                if (conn == null || conn.State == ConnectionState.Closed) //only open the connection if it is not open already to prevent crash
                {
                    conn.Open();
                }
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt16(reader["Id"]);
                    student.Username = Convert.ToString(reader["Username"]);
                    student.FirstName = Convert.ToString(reader["FirstName"]);
                    student.LastName = Convert.ToString(reader["LastName"]);
                    student.MasteryLevel = Convert.ToInt16(reader["MasteryLevel"]);

                    students.Add(student);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return students;
        }

        public static List<Klass> SelectAllKlasses()
        {
            List<Klass> klasses = new List<Klass>();

            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM klasses";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            
            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                Klass klass = new Klass();

                while (reader.Read())
                {
                    klass = new Klass();
                    klass.Id = Convert.ToInt16(reader["Id"]);
                    klass.KlassName = Convert.ToString(reader["KlassName"]);
                    klasses.Add(klass);
                }
                reader.Close();

                klass.Students = SelectAllStudentsInKlass(klass.Id);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return klasses;
        }

        public static List<Klass> SelectAllKlassesByTeacher(int teacherID)
        {
            List<Klass> klasses = new List<Klass>();

            //This is not safe!!!
            string query = $"SELECT * FROM klasses where TeacherID = @teacherID";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@teacherID", teacherID);

            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                Klass klass = new Klass();

                while (reader.Read())
                {
                    klass = new Klass();
                    klass.Id = Convert.ToInt16(reader["Id"]);
                    klass.KlassName = Convert.ToString(reader["KlassName"]);
                    klasses.Add(klass);
                }
                reader.Close();

                foreach(var k in klasses)
                {
                    k.Students = SelectAllStudentsInKlass(klass.Id);
                }
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database SQL Exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Exception.\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open) //only close the connection if it exists and is open to prevent crash
                {
                    conn.Close();
                }
            }
            return klasses;
        }



    }

}
