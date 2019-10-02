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
    public class LoginUserViewModel
    {
        private readonly UserService _userService = new UserService();
    
        

        public string Username { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var response = await _userService.LoginUserAsync(Username, Password);
                    var accessToken = response.Token;
                    var firstName = response.FirstName;
                    var lastName = response.LastName;
                    var userName = response.Username;
                    var role = response.Role;

                    Settings.AccessToken = accessToken;
                    Settings.Firstname = firstName;
                    Settings.Lastname = lastName;                    
                    Settings.Role = role;
                   
                    
                });
            }
        }
        public LoginUserViewModel()
        {
            Username = Settings.Username;
            Password = Settings.Password;
            
            
        }

        
    }
}
