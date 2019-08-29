using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Input;

namespace HackATL_EEVM
{
    public class User
    {

        public string Id { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
       

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
       
        //public string Phonenumber { get; set; }
        
 
    }
    public class RegisterUserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }

    }
}
