using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HackATL_EEVM.Services
{
    public interface IUserStore<T>
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserAsync(string username);
        Task<bool> RegisterUserAsync(User user);
        Task<bool> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(string username);

       // Task<string> LoginUser(string userName, string password);
    }
}
