using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleApp2.Models;

namespace ConsoleApp2.Services
{
    internal class UserValidator
    {
        public static void ValidateUser(string firstname,string lastname,string email,string password)
        {
            
            ValidateFirstName(firstname);
            ValidateLastName(lastname);
            ValidateEmail(email);
            ValidatePassword(password);
        }

        public static void ValidateFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name is required");
        }

        public static void ValidateLastName(string lastname)
        {
            if (string.IsNullOrWhiteSpace(lastname))
                throw new ArgumentException("Last name is required");
        }

        public static void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Enter a valid email address");
        }

        public static void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                throw new ArgumentException("Password must be more than 6 characters");
        }
    }
}
