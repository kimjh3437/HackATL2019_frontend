using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Application = Xamarin.Forms.Application;

namespace HackATL_EEVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : Xamarin.Forms.TabbedPage
    {
        public Main()
        {
            
            InitializeComponent();
            new NavigationPage(new Home());
            new NavigationPage(new Agenda());
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

        }
        async void OnLogoutButtonClicked(object sender, EventArgs e)

        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new HackATL_EEVM.Pages.LoginInterface.LoginPage(), this);
            await Navigation.PopAsync();

        }
    }
}