using HackATL_EEVM.Helpers_token;
using HackATL_EEVM.Models;
using HackATL_EEVM.Services;
using HackATL_EEVM.ViewModels;
using HackATL_EEVM.Views;
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
        
        UserViewModel viewModel;       
        UserService _userService = new UserService();

        public LoginPage()
        {
            
            InitializeComponent();
            viewModel = new UserViewModel();
            Settings.Username = emailEntry.Text;
            Settings.Password = passwordEntry.Text;

            
        }
        async void signin_transfer(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new SignUpPage());
        }
        private async void Login_clicked(object sender, EventArgs e)
        {

            Navigation.InsertPageBefore(new MainMasterDetail(), Navigation.NavigationStack.First());
            await Navigation.PopToRootAsync();

        }


        
       
  
        
        



    }
}