using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class Student : User
    {
        public int MasteryLevel { get; set; }
        public GradedPlacementTest GradedPlacementTest { get; set; }
        public List<GradedPracticeTest> GradedPracticeTests { get; set; }
        public List<GradedMasteryTest> GradedMasteryTests { get; set; }

        //empty constructor
        public Student() : base() { }

        //short constructor - delete this if we don't ever use it
        public Student(string username, string firstName, string lastName, int masteryLevel = 0) : base(username, firstName, lastName)
        {
            this.MasteryLevel = masteryLevel;
        }

        //full constructor
        public Student(string username, string firstName, string lastName, string password, int masteryLevel, GradedPlacementTest gradedPlacementTest, List<GradedPracticeTest> gradedPracticeTests, List<GradedMasteryTest> gradedMasteryTests) : base(username, firstName, lastName, password)
        {
            this.MasteryLevel = masteryLevel;
            this.GradedPlacementTest = gradedPlacementTest;
            this.GradedPracticeTests = gradedPracticeTests;
            this.GradedMasteryTests = gradedMasteryTests;
        }
    }
}
