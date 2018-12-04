using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            //List<Question> qL = new List<Question>();
            //TimeSpan ts = new TimeSpan(10, 0, 0);
            //qL = Question.GenerateSimpleAddtionQuestions(ts, 10);
            //MessageBox.Show(qL.Count().ToString());



        }
    }
}
