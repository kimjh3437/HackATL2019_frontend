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

        
        private void viewProfileTapped(object sender, EventArgs e)
        {          
           
                var page = new Xamarin.Forms.NavigationPage(new ProfileView());
                Utilities.Common.MasterPage.Master = page;
                Xamarin.Forms.NavigationPage.SetHasNavigationBar(page,false);
                Utilities.Common.MasterPage.IsPresented = false;
   
        }
    }
}