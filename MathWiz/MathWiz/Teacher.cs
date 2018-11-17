using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class Teacher : User
    {
        public List<Klass> Klasses { get; set; }

        //empty constructor
        public Teacher() : base() { }

        //normal constructor
        public Teacher(string username, string firstName, string lastName, List<Klass> klasses = null) : base(username, firstName, lastName) //no password
        {
            this.Klasses = klasses;
        }

        //full constructor
        public Teacher(string username, string firstName, string lastName, string password, List<Klass> klasses = null) : base(username, firstName, lastName, password)
        {
            this.Klasses = klasses;
        }
    }
}
