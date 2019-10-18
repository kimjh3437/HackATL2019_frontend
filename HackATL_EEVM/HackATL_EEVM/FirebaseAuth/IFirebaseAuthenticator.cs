using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HackATL_EEVM.FirebaseAuth
{
    public interface IFirebaseAuthenticator
    {
        Task<string> Login(string email, string password);
        bool SignUp(string email, string password);
    }
}
