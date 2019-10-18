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
    public partial class RoomView : ContentView
    {
        List<DummyData> dummyDatas = new List<DummyData>();
        public RoomView()
        {
            InitializeComponent();
            dummyDatas.Clear();
            dummyDatas.Add(new DummyData() { Id = 1, gbs = "Currently not avaliable", booking = "No Upcoming Booking" });
            
            lstRomms.FlowItemsSource = dummyDatas.ToList();
            lstRomms.HeightRequest = dummyDatas.Count() * 60;
        }
        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }

        private void imgFour_Clicked(object sender, EventArgs e)
        {
            if (!imgFour.Source.ToString().Contains("Selected"))
            {
                imgFour.Source = "FourSelected.png";
                imgSix.Source = "Six.png";
                imgEight.Source = "Eight.png";
                imgTen.Source = "Ten.png";
                imgCustom.Source = "Custom.png";
            }
            else
            {
                imgFour.Source = "four.png";
            }
        }

        private void imgSix_Clicked(object sender, EventArgs e)
        {
            if (!imgSix.Source.ToString().Contains("Selected"))
            {
                imgSix.Source = "SixSelected.png";
                imgFour.Source = "four.png";
                imgEight.Source = "Eight.png";
                imgTen.Source = "Ten.png";
                imgCustom.Source = "Custom.png";
            }
            else
            {
                imgSix.Source = "Six.png";
            }
        }

        private void imgEight_Clicked(object sender, EventArgs e)
        {
            if (!imgEight.Source.ToString().Contains("Selected"))
            {
                imgEight.Source = "EightSelected.png";
                imgFour.Source = "four.png";
                imgSix.Source = "Six.png";
                imgTen.Source = "Ten.png";
                imgCustom.Source = "Custom.png";
            }
            else
            {
                imgEight.Source = "Eight.png";
            }
        }

        private void imgTen_Clicked(object sender, EventArgs e)
        {
            if (!imgTen.Source.ToString().Contains("Selected"))
            {
                imgTen.Source = "TenSelected.png";
                imgFour.Source = "four.png";
                imgSix.Source = "Six.png";
                imgEight.Source = "Eight.png";
                imgCustom.Source = "Custom.png";
            }
            else
            {
                imgTen.Source = "Ten.png";
            }
        }

        private void imgCustom_Clicked(object sender, EventArgs e)
        {
            if (!imgCustom.Source.ToString().Contains("Selected"))
            {
                imgCustom.Source = "CustomSelected.png";
                imgFour.Source = "four.png";
                imgSix.Source = "Six.png";
                imgEight.Source = "Eight.png";
                imgTen.Source = "Ten.png";
            }
            else
            {
                imgCustom.Source = "Custom.png";
            }
        }

        private void imgHalf_Clicked(object sender, EventArgs e)
        {
            if (!imgHalf.Source.ToString().Contains("Selected"))
            {
                imgHalf.Source = "HalfSelected.png";
                imgOne.Source = "One.png";
                imgThree.Source = "Three.png";
                imgSixH.Source = "Six.png";
                imgCustomH.Source = "Custom.png";
            }
            else
            {
                imgHalf.Source = "Half.png";
            }
        }

        private void imgOne_Clicked(object sender, EventArgs e)
        {
            if (!imgOne.Source.ToString().Contains("Selected"))
            {
                imgOne.Source = "OneSelected.png";
                imgHalf.Source = "Half.png";
                imgThree.Source = "Three.png";
                imgSixH.Source = "Six.png";
                imgCustomH.Source = "Custom.png";
            }
            else
            {
                imgOne.Source = "One.png";
            }
        }

        private void imgThree_Clicked(object sender, EventArgs e)
        {
            if (!imgThree.Source.ToString().Contains("Selected"))
            {
                imgThree.Source = "ThreeSelected.png";
                imgHalf.Source = "Half.png";
                imgOne.Source = "One.png";
                imgSixH.Source = "Six.png";
                imgCustomH.Source = "Custom.png";
            }
            else
            {
                imgThree.Source = "Three.png";
            }
        }

        private void imgSixH_Clicked(object sender, EventArgs e)
        {
            if (!imgSixH.Source.ToString().Contains("Selected"))
            {
                imgSixH.Source = "SixSelected.png";
                imgHalf.Source = "Half.png";
                imgOne.Source = "One.png";
                imgThree.Source = "Three.png";
                imgCustomH.Source = "Custom.png";
            }
            else
            {
                imgSixH.Source = "Six.png";
            }
        }

        private void imgCustomH_Clicked(object sender, EventArgs e)
        {
            if (!imgCustomH.Source.ToString().Contains("Selected"))
            {
                imgCustomH.Source = "CustomSelected.png";
                imgHalf.Source = "Half.png";
                imgOne.Source = "One.png";
                imgThree.Source = "Three.png";
                imgSixH.Source = "Six.png";
            }
            else
            {
                imgCustomH.Source = "Custom.png";
            }
        }

        private void imgBookNow_Clicked(object sender, EventArgs e)
        {
            var rs = (Image)sender;
            var mImages = rs.BindingContext as DummyData;
            foreach (var item in dummyDatas)
            {
                if (item.Id == mImages.Id)
                {
                    if (mImages.IsBookNow == "BooknowSelected.png")
                    {
                        item.IsBookNow = "Booknow.png";
                    }
                    else
                    {
                        item.IsBookNow = "BooknowSelected.png";
                    }
                }
                else
                {
                    item.IsBookNow = "Booknow.png";
                }
            }
        }

        private void LstRomms_FlowItemTapped(object sender, ItemTappedEventArgs e)
        {
            var roomData = e.Item;
        }
    }
}