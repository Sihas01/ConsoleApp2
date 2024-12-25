

using ConsoleApp2.Controllers;
using ConsoleApp2.Models;
using ConsoleApp2.View;

IUserView userView = new UserView();
UserModel model = new UserModel();

UserController userController = new UserController(userView, model);

userView.FirstName = "John";
userView.LastName = "Doe";
userView.Email = "john@gmail.com";
userView.Password = "1234567";

userController.CreateUser();