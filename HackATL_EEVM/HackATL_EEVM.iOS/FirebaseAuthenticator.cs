using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
using Foundation;
using HackATL_EEVM.FirebaseAuth;
using UIKit;

namespace HackATL_EEVM.iOS
{
    public class FirebaseAuthenticator : IFirebaseAuthenticator
    {
        public async Task<string> Login(string email, string password)
        {
            try
            {
                var user = await Auth.DefaultInstance.SignInWithPasswordAsync(email, password);
                return await user.User.GetIdTokenAsync();
            }
            catch (Exception e)
            {
                return "";
            }

        }
        public bool SignUp(string email, string password)
        {
            try
            {
                //var user1 = await FirebaseAuth.GetInstance();
                Auth.DefaultInstance.CreateUserAsync(email, password);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}