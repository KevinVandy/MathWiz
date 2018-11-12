using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class Student : User
    {
        public short MasteryLevel { get; set; }
        public List<Grade> Grades { get; set; }

        //empty constructor
        public Student() : base() { }

        //normal constructor
        public Student(string username, string firstName, string lastName, short masteryLevel, List<Grade> grades = null) : base(username, firstName, lastName)
        {
            this.MasteryLevel = masteryLevel;
            this.Grades = grades;
        }

        //full constructor
        public Student(string username, string firstName, string lastName, string password, short masteryLevel, List<Grade> grades) : base(username, firstName, lastName, password)
        {
            this.MasteryLevel = masteryLevel;
            this.Grades = grades;
        }
    }
}
