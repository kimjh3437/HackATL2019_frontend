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
    public partial class FAQ_question : ContentPage
    {
        public FAQ_question()
        {
            InitializeComponent();
        }
        async void Button_Question(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}