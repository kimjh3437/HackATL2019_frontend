using HackATL_EEVM.Models;
using HackATL_EEVM.Services;
using HackATL_EEVM.Views.AdminPages.Admin_children.AdminNavPAges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.AdminPages.Admin_children
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Admin_agenda : ContentPage
    {
        
        public Admin_agenda()
        {
            InitializeComponent();
           
        }

       
        async void Add_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Admin_agenda_Add());

        }
        async void Remove_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Admin_agenda_Remove());

        }

        async void Edit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Admin_agenda_Update());

        }

        public async void View_Clicked(object sender, EventArgs e)
        {

        }


    }
}