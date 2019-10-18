using HackATL_EEVM.Views.Pages.FAQquestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FAQView : ContentView
    {
        public FAQView()
        {
            InitializeComponent();
        }

        

        private void BeforeArrive_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new beforeArrive());

        }

        private void WhenArrive_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new whenArrive());

        }

        private void PitchingFAQ_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pitching());

        }       

        private void RecommendedTools_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.google.com/document/d/1NeDLdkK_v0xNRv6mK6temgxeoR8dkQNx9daXkUtFDaA/edit#heading=h.mrbrygp7o3lt"));       

        }
    }
}