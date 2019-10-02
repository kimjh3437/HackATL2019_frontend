using System;
using System.Collections.Generic;
using System.Text;

namespace HackATL_EEVM.Services.User_related
{
    public class UserManager
    {
        IUserStore<User> userService; 
        public UserManager(IUserStore<User> service)
        {
            userService = service; 
        }
        //public Task<List<User>>


    }
}
