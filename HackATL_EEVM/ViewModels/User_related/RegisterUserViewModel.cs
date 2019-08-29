using HackATL_EEVM.Helpers_token;
using HackATL_EEVM.Models.BindingModels;
using HackATL_EEVM.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackATL_EEVM.ViewModels.User_related
{
    public class RegisterUserViewModel
    {
        private readonly UserService _userService = new UserService();
       
        public string username { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Message { get; set; }
        
        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var response = await _userService.RegisterUserAsync(username, password, FirstName, LastName);
                    
                    //var accessToken = response.Token;
                    //var firstName = response.FirstName;
                    //var lastName = response.LastName;
                    //var userName = response.Username;
                    //var role = response.Role;

                    //Settings.AccessToken = accessToken;
                    //Settings.Firstname = firstName;
                    //Settings.Lastname = lastName;
                    //Settings.Role = role;

                    if (response)
                    {
                        Message = "Success :)";
                    }
                    else
                    {
                        Message = "Please try again :(";
                    }
                });
            }
            
        }
        public RegisterUserViewModel()
        {
            FirstName = Settings.Firstname;
            LastName = Settings.Lastname;
            username = Settings.Username;
            password = Settings.Password;


        }
    }
}
