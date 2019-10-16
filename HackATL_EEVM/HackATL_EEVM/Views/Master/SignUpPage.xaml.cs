using HackATL_EEVM.FirebaseAuth;
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
            string token = await auth.Login(txtEmail.Text, txtPassword.Text);
            if(token != "")
            {
                await Navigation.PushAsync(new Views.MainTab());

            }
            else
            {
                ShowError();
            }
            
            
        }
        async private void ShowError()
        {
            await DisplayAlert("Authentication Failed", "E-mail or password are incorrect. Try again!", "OK");
        }
    }
}