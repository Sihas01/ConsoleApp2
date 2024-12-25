using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleApp2.Services;

namespace ConsoleApp2.Models
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _passwordHash;

        public User(string firstName, string lastName, string email, string password)
        {
            UserValidator.ValidateUser(firstName, lastName, email, password);

            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _passwordHash = HashPassword(password);
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                UserValidator.ValidateFirstName(value);
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                UserValidator.ValidateLastName(value);
                _lastName = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                UserValidator.ValidateEmail(value);
                _email = value;
            }
        }

        public string PasswordHash
        {
            get { return _passwordHash; }
            set
            {
                UserValidator.ValidatePassword(value);
                _passwordHash = value;
            }
        }

        private string HashPassword(string password)
        {
            using(var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }

        }
    }
}
