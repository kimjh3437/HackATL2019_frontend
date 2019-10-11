using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using HackATL_EEVM.Views.Master.MaserMenuNav;

namespace HackATL_EEVM.Views.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMenuPage : ContentPage
    {
        public MasterMenuPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }
        private void ImgExit_Tapped(object sender, EventArgs e)
        {
            Utilities.Common.MasterPage.IsPresented = false;
        }

        
        async void viewProfileTapped(object sender, EventArgs e)
        {
            try
            {
                var page = new ProfileView();
                await Navigation.PushAsync(new Xamarin.Forms.NavigationPage(page));

            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", "error occurred","OK");
            }
            
        }
    }
}