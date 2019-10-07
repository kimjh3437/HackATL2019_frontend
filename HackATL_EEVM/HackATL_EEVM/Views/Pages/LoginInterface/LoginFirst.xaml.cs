using HackATL_EEVM.Pages.LoginInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.Pages.LoginInterface
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginFirst : ContentPage
    {
        public LoginFirst()
        {
            InitializeComponent();
        }
        async void signin_transfer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        async void signup_transfer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}