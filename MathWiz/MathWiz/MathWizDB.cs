using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    //Class for inserting, updating, or deleting from the database
    public class MathWizDB
    {
        readonly static SqlConnection conn = MathWizConn.GetMathWizConnection();

        private void InsertParent(Parent newParent)
        {
            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand("INSERT INTO parent " + "(Username, FirstName, LastName, PasswordHash) " +
            "VALUES(@Username, @FirstName, @LastName, @Password)", conn);

            // create your parameters
            Cmd.Parameters.AddWithValue("@Username", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@FirstName", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@LastName", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@Password", System.Data.SqlDbType.VarChar);

            // set values to parameters from textboxes
            Cmd.Parameters["@Username"].Value = newParent.Username;
            Cmd.Parameters["@FirstName"].Value = newParent.FirstName;
            Cmd.Parameters["@LastName"].Value = newParent.LastName;
            Cmd.Parameters["@Password"].Value = newParent.Password;

            // open sql connection
            conn.Open();

            // execute the query and return number of rows affected, should be one
            int RowsAffected = Cmd.ExecuteNonQuery();

            // close connection when done
            conn.Close();
        }

        private void InsertStudent(Student newStudent)
        {
            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand("INSERT INTO student " + "(Username, FirstName, LastName, PasswordHash) " +
            "VALUES(@Username, @FirstName, @LastName, @Password)", conn);

            // create your parameters
            Cmd.Parameters.AddWithValue("@Username", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@FirstName", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@LastName", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@Password", System.Data.SqlDbType.VarChar);

            // set values to parameters from textboxes
            Cmd.Parameters["@Username"].Value = newStudent.Username;
            Cmd.Parameters["@FirstName"].Value = newStudent.FirstName;
            Cmd.Parameters["@LastName"].Value = newStudent.LastName;
            Cmd.Parameters["@Password"].Value = newStudent.Password;

            // open sql connection
            conn.Open();

            // execute the query and return number of rows affected, should be one
            int RowsAffected = Cmd.ExecuteNonQuery();

            // close connection when done
            conn.Close();
        }

        private void InsertTeacher(Teacher newTeacher)
        {
            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand("INSERT INTO teacher " + "(Username, FirstName, LastName, PasswordHash) " +
            "VALUES(@Username, @FirstName, @LastName, @Password)", conn);

            // create your parameters
            Cmd.Parameters.AddWithValue("@Username", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@FirstName", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@LastName", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@Password", System.Data.SqlDbType.VarChar);

            // set values to parameters from textboxes
            Cmd.Parameters["@Username"].Value = newTeacher.Username;
            Cmd.Parameters["@FirstName"].Value = newTeacher.FirstName;
            Cmd.Parameters["@LastName"].Value = newTeacher.LastName;
            Cmd.Parameters["@Password"].Value = newTeacher.Password;

            // open sql connection
            conn.Open();

            // execute the query and return number of rows affected, should be one
            int RowsAffected = Cmd.ExecuteNonQuery();

            // close connection when done
            conn.Close();
        }

        private void InsertAdmin(Admin newAdmin)
        {
            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand("INSERT INTO admin " + "(Username, FirstName, LastName, PasswordHash) " +
            "VALUES(@Username, @FirstName, @LastName, @Password)", conn);

            // create your parameters
            Cmd.Parameters.AddWithValue("@Username", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@FirstName", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@LastName", System.Data.SqlDbType.VarChar);
            Cmd.Parameters.AddWithValue("@Password", System.Data.SqlDbType.VarChar);

            // set values to parameters from textboxes
            Cmd.Parameters["@Username"].Value = newAdmin.Username;
            Cmd.Parameters["@FirstName"].Value = newAdmin.FirstName;
            Cmd.Parameters["@LastName"].Value = newAdmin.LastName;
            Cmd.Parameters["@Password"].Value = newAdmin.Password;

            // open sql connection
            conn.Open();

            // execute the query and return number of rows affected, should be one
            int RowsAffected = Cmd.ExecuteNonQuery();

            // close connection when done
            conn.Close();
        }
    }
}
