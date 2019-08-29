using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HackATL_EEVM.Views.AdminPages;
using HackATL_EEVM.Views.AdminPages.Admin_children;

namespace HackATL_EEVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new HackATL_EEVM.Pages.LoginInterface.LoginPage(), this);
            await Navigation.PopAsync();

        }

        async void clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdminNavigation());

        }
    }
}