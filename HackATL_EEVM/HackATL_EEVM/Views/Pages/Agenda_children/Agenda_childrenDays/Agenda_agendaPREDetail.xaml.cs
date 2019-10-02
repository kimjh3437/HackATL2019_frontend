using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HackATL_EEVM.Models;
using HackATL_EEVM.ViewModels;

namespace HackATL_EEVM.Views.Pages.Agenda_children.Agenda_childrenDays
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Agenda_agendaPREDetail : ContentPage
    {
        ItemDetailViewModel viewModel;
        public Agenda_agendaPREDetail(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public Agenda_agendaPREDetail()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 22",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;

        }
    }
}