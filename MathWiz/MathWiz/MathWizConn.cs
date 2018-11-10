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
                return new SqlConnection(@"Data Source = MathWizGroup3.db.2823567.hostedresource.com; Initial Catalog = MathWizGroup3; Persist Security Info = True; User ID = MathWizGroup3; Password: P@ssw@rd");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            
        }
    }
}
