using HackATL_EEVM.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace HackATL_EEVM.Models.BindingModels
{
    public class UserDto
    {

        private readonly UserService _userService = new UserService();
        [JsonProperty(PropertyName ="Id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "Username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "Firstname")]
        public string Firstname { get; set; }

        [JsonProperty(PropertyName = "Lastname")]
        public string Lastname { get; set; }

        
    }
    
}
