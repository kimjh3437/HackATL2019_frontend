using HackATL_EEVM.FirebaseAuth;
using HackATL_EEVM.Helpers_token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        IFirebaseAuthenticator auth;
        public SignUpPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuthenticator>();
            
        }
        async void ImgSignUp_Tapped(object sender, EventArgs e)
        {
            
            try
            {
                
                string token = await auth.Login(txtEmail.Text, txtPassword.Text);
                if (token != "")
                {
                    Settings.AccessToken = token;
                    Settings.Username = txtEmail.Text;
                    Settings.Password = txtPassword.Text;
                    await Navigation.PushAsync(new Views.MainTab());

                }
                else
                {
                    ShowError();
                }

            }
            catch (Exception ex)
            {
                ShowError2();
            }
 
        }
        
        async private void ShowError()
        {
            await DisplayAlert("Authentication Failed", "E-mail or password is incorrect. Try again!", "OK");
        }

        async private void ShowError2()
        {
            await DisplayAlert("Invalid Info entered", "E-mail or password is incorrect. Try again!", "OK");
        }
    }
}