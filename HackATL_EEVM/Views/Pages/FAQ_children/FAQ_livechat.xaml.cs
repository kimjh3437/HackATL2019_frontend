using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.Pages.FAQ_children
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FAQ_livechat : ContentPage
    {
        public FAQ_livechat()
        {
            InitializeComponent();
        }
        async void Button_Live(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        async void Livechat_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FAQ_livechat());
        }
    }
}