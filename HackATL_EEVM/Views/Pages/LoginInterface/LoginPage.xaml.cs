using HackATL_EEVM.Helpers_token;
using HackATL_EEVM.Models;
using HackATL_EEVM.Services;
using HackATL_EEVM.ViewModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Pages.LoginInterface
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        HttpClient client;
        UserViewModel viewModel;
        User user;
        UserService _userService = new UserService();
        string Username_in, Password_in;
        public LoginPage()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{App.AzureBackendUrl}/");
            user = new User();
            InitializeComponent();
            viewModel = new UserViewModel();
            Settings.Username = usernameEntry.Text;
            Settings.Password = passwordEntry.Text;

            
        }
        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new SignUpPage());
        }
        private async void Login_clicked(object sender, EventArgs e)
        {
            if (Settings.Role == "Member")
                await Navigation.PushAsync(new Main());
            else if (Settings.Role == "Admin")
                await Navigation.PushAsync(new Main());
        }


        public async void Lllogin(object sender, EventArgs e)
        {
            //
        }
       
  /*      
        public async void Login(string username, string password)
        {
            
            try
            {
                var response = await client.GetAsync($"api/user/{username}");               
                var user_string = await Task.Run(() =>response.Content.ReadAsStringAsync());
                user = JsonConvert.DeserializeObject<User>(user_string);
                if (user.Username != username)
                {
                    await DisplayAlert("Alert", "User does not exist", "OK");                 
                }
                else
                {
                    if (user.Password != password)
                    {
                        await DisplayAlert("Alert", "You have entered incorrect password", "OK");
                    }
                    else
                    {
                        Application.Current.Properties["Username"] = user.Username;
                        Application.Current.Properties["Password"] = user.Password;
                        Application.Current.Properties["FirstName"] = user.FirstName;
                        Application.Current.Properties["LastName"] = user.LastName;
                        //Application.Current.Properties["PhoneNumber"] = user.Phonenumber;
                        Application.Current.Properties["Logged_On"] = "On";
                        App.IsUserLoggedIn = true;
                        App.profile = user;
                        await Navigation.PushAsync(new Main());


                    }
                }
                    
            }
            catch(Exception ex)
            {
                await DisplayAlert("Alert", ex.Message.ToString(), "OK");
            }
  
        }
        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;
        }

      */ 
        async void ToMain()
        {
            Application.Current.Properties["User"] = user as User;
            App.IsUserLoggedIn = true;
            Navigation.InsertPageBefore(new Main(), this);
            await Navigation.PopAsync();
        }

        



    }
}