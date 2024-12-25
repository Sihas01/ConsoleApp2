using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Models;
using ConsoleApp2.View;

namespace ConsoleApp2.Controllers
{
    internal class UserController
    {
        public readonly IUserView _userView;
        public readonly UserModel _userModel;

        public UserController(IUserView userView, UserModel userModel)
        {
            _userView = userView;
            _userModel = userModel;
        }

        public void CreateUser()
        {
            try
            {
                string firstname = _userView.FirstName;
                string lastname = _userView.LastName;
                string email = _userView.Email;
                string password = _userView.Password;

                bool success = _userModel.CreateUser(firstname, lastname, email, password);
                if (success)
                {
                    _userView.ShowMessage("User created successfully");
                }
                else
                {
                    _userView.ShowMessage("Faild to create user");
                }
            }
            catch (ArgumentException ex)
            {
                _userView.ShowMessage(ex.Message);
            }
            catch (Exception e)
            {
                _userView.ShowMessage(e.Message);
            }
        }
    }
}
