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

        public static Admin SelectAdmin(int id)
        {
            //make the object that will eventually get returned
            Admin admin = new Admin();
            
            //make the query the safe way by binding values to prevent SQL injection
            string query = "SELECT * FROM Admins Where ID = @ID";
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
                    admin.Username = Convert.ToString(reader["Username"]);
                    admin.FirstName = Convert.ToString(reader["FirstName"]);
                    admin.LastName = Convert.ToString(reader["LastName"]);
                    //maybe select password too
                }
                reader.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("There was a problem connecting to the server. Check you internet connection.\n\n" + ex, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Someone dun messed up.\n\n" + ex, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
