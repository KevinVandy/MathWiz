using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class Klass
    {
        public int Id { get; set; }
        public string KlassName { get; set; }
        public List<Student> Students { get; set; }
        public PlacementTest PlacementTest { get; set; }
        public List<PracticeTest> PracticeTests { get; set; }
        public List<MasteryTest> MasteryTests { get; set; }

        //empty constructor
        public Klass() { }

        //normal constructor
        public Klass(string klassName, List<Student> students)
        {
            this.KlassName = klassName;
            this.Students = students;
            this.PlacementTest = null;
            this.PracticeTests = null;
            this.MasteryTests = null;
        }

        //full constructor
        public Klass(string klassName, List<Student> students, PlacementTest placementTest, List<PracticeTest> practiceTests, List<MasteryTest> masteryTests)
        {
            this.KlassName = klassName;
            this.Students = students;
            this.PlacementTest = placementTest;
            this.PracticeTests = practiceTests;
            this.MasteryTests = masteryTests;
        }

        public override string ToString()
        {
            return this.Id.ToString("0000") + ": " + this.KlassName;
        }
    }
}
