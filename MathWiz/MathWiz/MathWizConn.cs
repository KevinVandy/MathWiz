using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public static class MathWizConn
    {
        public static SqlConnection GetMathWizConnection()
        {
            try
            { //this is not working yet
                string connectionString = @"Data Source = MathWizGroup3.db.2823567.e83.hostedresource.net; Initial Catalog = MathWizGroup3; Persist Security Info = True; User ID = MathWizGroup3; Password = P@ssw@rd3;";

                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            
        }
    }
}
