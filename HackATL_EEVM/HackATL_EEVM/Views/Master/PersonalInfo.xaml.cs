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
    public partial class PersonalInfo : ContentPage
    {
        public PersonalInfo()
        {
            InitializeComponent();
        }
        public async void loginInfotapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void finalsignup2_Tabbed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainTab());

        }
    }
}