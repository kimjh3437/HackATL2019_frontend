using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Firebase.Auth;
using HackATL_EEVM.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FirebaseAuthenticator))]
namespace HackATL_EEVM.Droid
{
    
    public class FirebaseAuthenticator : FirebaseAuth.IFirebaseAuthenticator
    {
        public async Task<string> Login(string email, string password)
        {
            try
            {
                var user = await Firebase.Auth.FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (FirebaseAuthInvalidUserException e)
            {
                e.PrintStackTrace();
                return "";
            }
        }
        public bool SignUp(string email, string password)
        {
            try
            {
                //var user1 = await FirebaseAuth.GetInstance();
                Firebase.Auth.FirebaseAuth.Instance.CreateUserWithEmailAndPassword(email, password);

                return true;
            }
            catch (FirebaseAuthInvalidUserException e)
            {
                e.PrintStackTrace();
                return false;
            }
        }
    }
}