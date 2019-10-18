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
    public partial class beforeArrive : ContentPage
    {
        public beforeArrive()
        {
            InitializeComponent();
        }

        private void Parking_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Information", "If you choose to drive, please park in the Law School parking Deck. Parking is free after 4PM here. Another Option is Fishburne Parking Deck(15 Fishburne Ln, Atlanta, GA 30307).This parking deck is located right behind the Goizueta Business School.Parking is free after 5PM and on weekends.", "Close");



        }

        private void WhattoPack_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Please be aware", "Laptop and charger, Notepad and stationery,  Phone charger", "Close");


        }

        private void WhatNottoPack_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Please be aware", "No Prototype. Alcohol or drugs, it an airplane won't allow it we won't either", "Close");

        }

        private void WhereToSleep_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Several Rooms", "W525 is our huge sleeping room! Get comfy yall!", "Close");

        }

        private void ShowerWhere_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("BottomFloor", "Bottom floor of Business School has shower facility open for everyone", "Close");

        }
    }
}