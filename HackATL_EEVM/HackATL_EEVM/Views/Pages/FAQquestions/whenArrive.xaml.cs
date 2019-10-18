using HackATL_EEVM.Views.Pages.FAQquestions.WhenArriveQs;
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
    public partial class whenArrive : ContentPage
    {
        public whenArrive()
        {
            InitializeComponent();
        }

        private void CheckIn_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Information", "When you arrive at the business school, please look for EEVM Staff in Coral shirts to direct you towards check-in. Please check-in at the registration desk located under the Arches of Emory’s Business School at 4:00 PM on Friday, October 18th. ", "Close");
        }

        private void PlacetEat_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Places", "Emory Village: Chipotle, Starbucks, Romeos, Wagaya Emory Point: Tiny Lizzy's, Boru Boru, Aladdin's Mediterranean Grill, Papi's", "Close");

        }

        private void Wifi_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Instruction", "Guests: Please try registering with the eduroam network first. You should be able to sign up using your university .edu address to gain access.", "Close");
        }
    }
}