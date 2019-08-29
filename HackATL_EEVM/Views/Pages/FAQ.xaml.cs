using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FAQ : ContentPage
    {
        public FAQ()
        {
            InitializeComponent();
        }
        async void Button_About(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HackATL_EEVM.Views.Pages.FAQ_children.FAQ_abouthackatl());

        }
        async void Button_General(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HackATL_EEVM.Views.Pages.FAQ_children.FAQ_general());

        }
        async void Button_Question(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HackATL_EEVM.Views.Pages.FAQ_children.FAQ_question());

        }
        async void Button_Live(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HackATL_EEVM.Views.Pages.FAQ_children.FAQ_livechat());

        }
    }
}