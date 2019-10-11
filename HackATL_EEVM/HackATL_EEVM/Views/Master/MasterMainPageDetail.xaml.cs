using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace HackATL_EEVM.Views.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMainPageDetail : MasterDetailPage
    {
        public MasterMainPageDetail()
        {
            try
            {
                InitializeComponent();
                On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
                Utilities.Common.MasterPage = this;
                Utilities.Common.MasterPage.Master = new MasterMenuPage();
                var page = new Views.Master.OptionPage();
                Utilities.Common.MasterPage.Detail = new Xamarin.Forms.NavigationPage(page);
                Xamarin.Forms.NavigationPage.SetHasNavigationBar(page, false);
                MasterBehavior = MasterBehavior.Popover;
                Utilities.Common.MasterPage.IsGestureEnabled = false;
                Utilities.Common.MasterPage.IsPresented = false;

            }
            catch (Exception ex)
            {
                var exp = ex.Message;
            }
        }     
    }
}