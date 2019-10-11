using HackATL_EEVM.Models;
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
    public partial class AgendaView : ContentView
    {
        List<DatesClass> mFashion = new List<DatesClass>();

        public AgendaView()
        {
            InitializeComponent();
            img1.Source = "AgendaSelected.png";
            grdFilterMenu.IsVisible = false;
            lblPre.TextColor = Color.FromHex("#FE7061");
            grdMain.Children.Add(new DaysContentPage.PreView());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Utilities.Common.MasterPage.IsGestureEnabled = false;
            Utilities.Common.MasterPage.IsPresented = true;
        }

        private async void Filter_Tapped(object sender, EventArgs e)
        {
            grdFilterMenu.FadeTo(0, 0, Easing.Linear);
            grdFilterMenu.ScaleTo(0.0, 0, Easing.Linear);

            var imageSource = (Image)sender;//get image source here
            var selectedImage = imageSource.Source as FileImageSource;

            if (selectedImage.File == "FilterNotSelected.png")
            {
                imgFilter.Source = "FilterSelected.png";
                grdFilterMenu.IsVisible = true;
                await grdFilterMenu.FadeTo(1, 300, Easing.BounceOut);
                await grdFilterMenu.ScaleTo(1, 500, Easing.BounceOut);
            }
            else
            {
                imgFilter.Source = "FilterNotSelected.png";
                grdFilterMenu.IsVisible = false;
            }
        }

        private void ImgFood_Tapped(object sender, EventArgs e)
        {
            imgFilterButton.Source = "FilterButtonSelected";
            imgUnselectedFilterButton.Source = "FilterButton";
        }

        private void ImgPitches_Tapped(object sender, EventArgs e)
        {
            imgUnselectedFilterButton.Source = "FilterButtonSelected";
            imgFilterButton.Source = "FilterButton";
        }

        private void BtnAgenda_Tapped(object sender, EventArgs e)
        {
            grdMain.Children.Clear();
            UnSelectedAgenda();
            imgFilter.Source = "FilterNotSelected.png";
            grdFilterMenu.IsVisible = false;
            img1.Source = "AgendaSelected.png";
            grdMain.Children.Add(new DaysContentPage.PreView());
        }

        private void BtnMyAgenda_Tapped(object sender, EventArgs e)
        {
            grdMain.Children.Clear();
            UnSelectedAgenda();
            imgFilter.Source = "FilterNotSelected.png";
            grdFilterMenu.IsVisible = false;
            img2.Source = "MyAgendaSelected.png";
            grdMain.Children.Add(new DaysContentPage.PreView(true));
        }

        public void UnSelectedAgenda()
        {
            img1.Source = "AgendaNotSelected.png";
            img2.Source = "MyAgendaNotSelected.png";
        }

        private void BtnPre_Tapped(object sender, EventArgs e)
        {
            textColor();
            lblPre.TextColor = Color.FromHex("#FE7061");
            grdMain.Children.Clear();
            var agenda = img1.Source.ToString().Replace("File: ", "");
            if (agenda == "AgendaSelected.png")
            {
                grdMain.Children.Add(new DaysContentPage.PreView());
            }
            else
            {
                grdMain.Children.Add(new DaysContentPage.PreView(true));
            }
        }

        private void BtnFri_Tapped(object sender, EventArgs e)
        {
            textColor();
            lblFri.TextColor = Color.FromHex("#FE7061");
            grdMain.Children.Clear();
        }

        private void BtnSat_Tapped(object sender, EventArgs e)
        {
            textColor();
            lblSat.TextColor = Color.FromHex("#FE7061");
            grdMain.Children.Clear();
        }

        private void BtnSun_Tapped(object sender, EventArgs e)
        {
            textColor();
            lblSun.TextColor = Color.FromHex("#FE7061");
            grdMain.Children.Clear();
        }

        public void textColor()
        {
            lblPre.TextColor = Color.Black;
            lblFri.TextColor = Color.Black;
            lblSat.TextColor = Color.Black;
            lblSun.TextColor = Color.Black;
        }
    }
}