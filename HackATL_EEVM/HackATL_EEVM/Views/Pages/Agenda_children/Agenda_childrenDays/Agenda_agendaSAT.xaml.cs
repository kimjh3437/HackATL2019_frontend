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
using HackATL_EEVM.Services.Item_realted;

namespace HackATL_EEVM.Views.Pages.Agenda_children.Agenda_childrenDays
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Agenda_agendaSAT : ContentPage
    {
        FirebaseItem firebase = new FirebaseItem();
        ItemsViewModel viewModel;

        public Item Itemlist { get; set; }
        public Agenda_agendaSAT()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();

            Itemlist = new Item
            {
                Text = "Name",
                Location = "gbs12",
                Time = "10:00PM",
                Description = "description"
            };

            //ItemsListViewSAT.ItemsSource = viewModel.Items.Where(w => w.Day.Contains("SAT"));
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListViewSAT.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);

            var result = await firebase.GetAllAgenda();
            ItemsListViewSAT.ItemsSource = result.Where(x => x.Day == "SAT" || x.Day == "Saturday");
        }

        private void Addtothelist(object sender, EventArgs e)
        {
            var added = sender as Button;
            Itemlist = added.BindingContext as Item;
            //viewModel.MyItems.Add(Itemlist);

            MessagingCenter.Send(this, "Addtothelist", Itemlist);

        }

        private void NotificationOn(object sender, EventArgs e)
        {

        }
    }
}