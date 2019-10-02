using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.AdminPages.Admin_children.AdminNavPAges
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Admin_agenda_Remove : ContentPage
    {
        public Admin_agenda_Remove()
        {
            InitializeComponent();
        }

        async void Remove_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }
    }
}