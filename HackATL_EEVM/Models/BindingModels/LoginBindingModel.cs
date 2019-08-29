using HackATL_EEVM.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace HackATL_EEVM.Models.BindingModels
{
    public class UserDto
    {

        private readonly UserService _userService = new UserService();
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        
    }
    
}
