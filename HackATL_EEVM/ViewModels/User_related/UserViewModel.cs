using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using HackATL_EEVM.Services;
using System.Windows.Input;

namespace HackATL_EEVM.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        User user;

        UserService _userService = new UserService();

        public static ObservableCollection<User> AllUserList { get; set; }

        public Command LoadUsersCommand { get; set; }

        public Command RegisterUser { get; set; }

        public string Message { get; set; }
        public UserViewModel()
        {
            user = new User();
            AllUserList = new ObservableCollection<User>();
            LoadUsersCommand = new Command(async () => await LoadUser());           
        }


        async Task LoadUser()
        {
            if (IsBusy)
                return;
            IsBusy = true;

            try
            {
                AllUserList.Clear();
                var userList = await UserStore.GetAllUsersAsync();
                foreach(var user in userList)
                {
                    AllUserList.Add(user);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }

        }

    
    }
}
