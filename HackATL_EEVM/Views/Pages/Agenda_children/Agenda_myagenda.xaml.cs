using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HackATL_EEVM.Models;
using HackATL_EEVM.Views;
using HackATL_EEVM.ViewModels;
using System.Collections.ObjectModel;

namespace HackATL_EEVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Agenda_myagenda : ContentPage
    {
        public ObservableCollection<Item>list { get; set; }
        
        ItemsViewModel viewModel;
        public Agenda_myagenda()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();

        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListViewMy.SelectedItem = null;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.MyItems.Count == 0)
                viewModel.LoadMyItemsCommand.Execute(null);
        }
        private void NotificationOn(object sender, EventArgs e)
        {

        }
    }
}