using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    class Student : User
    {
        public short MasteryLevel { get; set; }
        //list of grades???

        //empty constructor
        public Student() : base() { }

        //normal constructor
        public Student(string username, string firstName, string lastName, short masteryLevel) : base(username, firstName, lastName)
        {
            this.MasteryLevel = masteryLevel;
        }

        //full constructor
        public Student(string username, string firstName, string lastName, string password, short masteryLevel) : base(username, firstName, lastName, password)
        {
            this.MasteryLevel = masteryLevel;
        }
    }
}
