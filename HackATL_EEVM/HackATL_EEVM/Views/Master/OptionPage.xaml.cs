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
    public partial class OptionPage : ContentPage
    {
        public OptionPage()
        {
            InitializeComponent();
        }
        private void ImgSignIn_Tapped(object sender, EventArgs e)
        {
            //Utilities.Common.MasterPage.Master = new MasterMenuPage();
            //Utilities.Common.MasterPage.Detail = new NavigationPage(new Views.TabbedPage());
            //Utilities.Common.MasterPage.IsGestureEnabled = false;
            //Utilities.Common.MasterPage.IsPresented = false;

            Navigation.PushAsync(new Views.Master.SignUpPage());
        }
        private void ImgSignup_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}