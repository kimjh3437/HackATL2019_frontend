using HackATL_EEVM.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTab : ContentPage
    {
        public MainTab()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            img1.Source = "HomeIcon2.png";
            lbl1.TextColor = Color.FromHex("#FFDA29");
            GrdMain.Children.Add(new HomePage());
        }
        private void BtnHome_Tapped(object sender, EventArgs e)
        {
            UnSelectedTabbed();
            GrdMain.Children.Clear();
            img1.Source = "HomeIcon2.png";
            lbl1.TextColor = Color.FromHex("#FFDA29");
            GrdMain.Children.Add(new HomePage());
        }

        private void BtnAgenda_Tapped(object sender, EventArgs e)
        {
            UnSelectedTabbed();
            GrdMain.Children.Clear();
            img2.Source = "AgendaIcon2.png";
            lbl2.TextColor = Color.FromHex("#FFDA29");
            GrdMain.Children.Add(new AgendaView());
        }

        private void BtnPitch_Tapped(object sender, EventArgs e)
        {
            UnSelectedTabbed();
            GrdMain.Children.Clear();
            img3.Source = "PitchIcon2.png";
            lbl3.TextColor = Color.FromHex("#FFDA29");
            GrdMain.Children.Add(new PitchView());
        }

        private void BtnRooms_Tapped(object sender, EventArgs e)
        {
            UnSelectedTabbed();
            GrdMain.Children.Clear();
            img4.Source = "MapIcon2.png";
            lbl4.TextColor = Color.FromHex("#FFDA29");
            GrdMain.Children.Add(new RoomView());
        }

        private void BtnFAQ_Tapped(object sender, EventArgs e)
        {
            UnSelectedTabbed();
            GrdMain.Children.Clear();
            img5.Source = "FAQIcon2.png";
            lbl5.TextColor = Color.FromHex("#FFDA29");
            GrdMain.Children.Add(new FAQView());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Utilities.Common.MasterPage.IsGestureEnabled = false;
            Utilities.Common.MasterPage.IsPresented = true;
        }
        private void Facebook_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/EmoryEVM/"));
        }

        public void UnSelectedTabbed()
        {
            img1.Source = "HomeIcon.png";
            img2.Source = "AgendaIcon.png";
            img3.Source = "PitchIcon.png";
            img4.Source = "MapIcon.png";
            img5.Source = "FAQIcon.png";

            lbl1.TextColor = Color.FromHex("#FE7061");
            lbl2.TextColor = Color.FromHex("#FE7061");
            lbl3.TextColor = Color.FromHex("#FE7061");
            lbl4.TextColor = Color.FromHex("#FE7061");
            lbl5.TextColor = Color.FromHex("#FE7061");
        }
    }
}