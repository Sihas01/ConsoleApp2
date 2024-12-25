using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class UserModel
    {
        public bool CreateUser(string firstname,string lastname,string email,string password)
        {
            var user = new User(firstname, lastname, email, password);
            Console.WriteLine("saved");

            return true;
        }
    }
}
