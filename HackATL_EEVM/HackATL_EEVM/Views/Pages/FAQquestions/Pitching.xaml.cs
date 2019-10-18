using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.Pages.FAQquestions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pitching : ContentPage
    {
        public Pitching()
        {
            InitializeComponent();
        }

        private void Evaluation_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://docs.google.com/document/d/1vwUUmiveHR28omNtMCTamAme5QfLeUVLcR9rsWN6SyQ/edit?usp=sharing"));

        }

        private void Prizes_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Prizes!", "There will be amazing prizes! In the past, we have had combined cash prizes of up to $5,000 and lots of in-kind perks for the winning teams. Stay tuned ;)", "Close");

        }

        private void Teams_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Information", "8 Teams will make it to the final round. Teams will be notified by 1 PM","Close");

        }
    }
}