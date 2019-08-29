using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HackATL_EEVM.ViewModels.Livechat_related;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.Pages.FAQ_children.Livechat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class livechat : ContentPage
    {
        public livechat()
        {
            this.BindingContext = new liveChatViewModel();
            InitializeComponent();
        }

        async void Livechat_clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}