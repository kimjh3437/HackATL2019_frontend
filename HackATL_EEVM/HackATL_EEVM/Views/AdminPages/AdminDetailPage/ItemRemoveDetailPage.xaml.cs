using HackATL_EEVM.Models;
using HackATL_EEVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.AdminPages.AdminDetailPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemRemoveDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public ItemRemoveDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }
        public ItemRemoveDetailPage()
        {
            InitializeComponent();
            var item = new Item
            {
                Text = "Item Sample",
                Description = "This is an item description.",
                Time = "10:00 PM",
                Location = "GBS101",
                Type = "Food",
                Day = "FRI",

            };
            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }

}