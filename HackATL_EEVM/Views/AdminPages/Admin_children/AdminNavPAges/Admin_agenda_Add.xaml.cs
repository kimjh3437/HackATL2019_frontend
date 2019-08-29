﻿using HackATL_EEVM.Models;
using HackATL_EEVM.Services;
using HackATL_EEVM.ViewModels.Admin_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.AdminPages.Admin_children.AdminNavPAges
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Admin_agenda_Add : ContentPage
    {
        public Item item_new { get; set; }
        public AzureDataStore Adminservice = new AzureDataStore();
        public Admin_agenda_Add()
        {
            InitializeComponent();
            item_new = new Item
            {
                Text = "Sample",
                Time = "Sample",
                Location = "Sample",
                Type = "Sample",
                Day = "Sample",
                Description = "Sample"
            };

        }
        public void AddItem_clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", item_new);
        }

        async void Add_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }
    }
}