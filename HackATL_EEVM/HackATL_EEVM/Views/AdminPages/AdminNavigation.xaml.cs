using HackATL_EEVM.Views.AdminPages.Admin_children;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.AdminPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminNavigation : TabbedPage
    {
        public AdminNavigation()
        {
            InitializeComponent();
            new NavigationPage(new Admin_agenda());

        }
        async void clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }

    }
}