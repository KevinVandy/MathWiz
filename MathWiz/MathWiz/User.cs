using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWiz
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; } //to set a password value, you must go throgh the full constructor OR use the SetNewPassword method for it to be hashed

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
            this.Password = HashPassword(password); //probably not secure, but this will get it working
        }

        //methods for all users
        
        //password info source: https://stackoverflow.com/questions/4181198/how-to-hash-a-password/10402129#10402129, followed the one with over 215 upvotes, though this code is modified
        public string HashPassword(string password)
        {
            //create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            //create base hash from password and salt with 10,000 iterations
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            //combine salt and hash
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            //turn the salted hash into a string before returning it
            return Convert.ToBase64String(hashBytes);
        }

        public bool VerifyPassword(string username, string password)
        {
            //get the password hash from the database
            string passwordHash = MathWizDA.SelectPasswordHash(username);

            //turn the passwordHash string into a byte array again
            byte[] hashBytes = Convert.FromBase64String(passwordHash);

            //extract the salt from the hash byte array --keep numbers the same!!
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            //compute the hash on the password that the user entered -- needs to use the salt that was just extracted!! and the same # of iterations!!
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            //if the hashes do not match, then return false, otherwise return true to verify the password
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i]) //for some reason it needs to check != or else there were false positives 10% of the time
                {
                    return false;
                }
            }
            return true;
        }

        public void SetNewPassword(string username, string password)
        {
            this.Password = HashPassword(password);

        }

        public override string ToString()
        {
            return this.Id.ToString("0000") + ": " + this.FirstName + " " + this.LastName;
        }
    }
}
