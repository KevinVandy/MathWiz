using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public partial class frmCreatePlacementTest : Form
    {
        int klassID;

        public frmCreatePlacementTest(int kID)
        {
            InitializeComponent();
            klassID = kID;
        }

        private void frmCreatePlacementTest_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateTest_Click(object sender, EventArgs e)
        {
            Int64 aNumber = 0;

            //if form validation is good then
            if(ValidateForm())
            {
                //set values to build the test object based on which test is selected
                int min = 1;
                int max = 12;
                List<Question> qL = new List<Question>();
                TimeSpan time = TimeSpan.Parse(mskTime.Text);
                                                    
                //Placement Test
                PlacementTest PlacementTest = new PlacementTest(qL, time, min, max);
                MathWizDB.InsertPlacementTest(PlacementTest, klassID);
                aNumber = MathWizDA.GetLastInsertedRecord("test", "id");
                //need to resolve the how to create questions
                 this.Close();
                 PlacementTest.Questions = Question.GenerateRandomQuestions(PlacementTest.MaxLevel, PlacementTest.TimeLimit, 10);
                 foreach (Question q in PlacementTest.Questions)
                 {
                     MathWizDB.InsertTestQuestionPlacement(PlacementTest, q, aNumber);
                 }
                 MessageBox.Show("Your new randomly generated Placement test has been created");
                }
            else
            {
                MessageBox.Show("A placement test has already been created for this class.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    //validation methods for the form based on which test is selected
    private bool ValidateForm()
        {
               if(Validation.IsMaskPresent(mskTime) && MathWizDA.FindPlacementTest(klassID) == false )
                {
                        return true;
                }

                return false;
            }

        
    }
        
}
