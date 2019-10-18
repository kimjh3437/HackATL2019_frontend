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
    public partial class RegisterPage : ContentPage
    {
        IFirebaseAuthenticator auth;
        public RegisterPage()
        {
            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuthenticator>();
        }

        public async void loginInfotapped(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    bool status = auth.SignUp(txtEmail.Text, txtPassword.Text);
                    if (status)
                    {
                        string token = await auth.Login(txtEmail.Text, txtPassword.Text);
                        if (token != "")
                        {
                            await Navigation.PushAsync(new PersonalInfo());

                        }
                        else
                        {
                            ShowError();
                        }

                    }
                    else
                    {
                        await DisplayAlert("Confirm the Password", "Password does not match", "Ok");
                    }
                }

            }
            catch(Exception ex)
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