using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class Parent : User
    {
        public List<Student> Children { get; set; }

        //empty constructor
        public Parent() : base() { }

        //normal constructor
        public Parent(string username, string firstName, string lastName, List<Student> children) : base(username, firstName, lastName) //no password
        {
            this.Children = children;
        }

        //full constructor
        public Parent(string username, string firstName, string lastName, string password, List<Student> children) : base(username, firstName, lastName, password)
        {
            this.Children = children;
        }
    }
}