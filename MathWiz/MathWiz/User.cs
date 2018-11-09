using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    class User
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; } //TODO work on security, private

        //empty constructor
        public User() { }
        
        //normal constructor
        public User(string username, string firstName, string lastName)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = null;
        }

        //full constructor
        public User(string username, string firstName, string lastName, string password)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = new PasswordHash(password).ToString(); //probably not secure, but this will get it working
        }
    }
}
