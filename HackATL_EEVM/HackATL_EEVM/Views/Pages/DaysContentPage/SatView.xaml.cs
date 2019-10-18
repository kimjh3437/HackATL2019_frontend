using HackATL_EEVM.Models;
using HackATL_EEVM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackATL_EEVM.Views.Pages.DaysContentPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SatView : ContentView
    {
        List<TypesModel> typesModelsSAT = new List<TypesModel>();
        List<TypesModel> mytypesModelsSat = new List<TypesModel>();
        bool _isAgenda = false;
        public SatView()
        {
            InitializeComponent();
            _isAgenda = false;
            BindData();
        }

        public SatView(bool isAgenda)
        {
            InitializeComponent();
            _isAgenda = isAgenda;
            BindAgendaData();
        }

        public void BindData()
        {
            typesModelsSAT.Clear();
            typesModelsSAT.Add(new TypesModel() { id = 1, Time = "5:00 PM", status = "Check-In", Desc = "Goizuetapre Business School Arches" });
            typesModelsSAT.Add(new TypesModel() { id = 2, Time = "10:00 PM", status = "Check-In", Desc = "Goizuetapree Business School Arches" });
            typesModelsSAT.Add(new TypesModel() { id = 3, Time = "3:00 PM", status = "Check-In", Desc = "Goizuetapreee Business School Arches" });

            flvTypes.FlowItemsSource = typesModelsSAT.ToList();
        }

        public void BindAgendaData()
        {
            typesModelsSAT.Clear();
            typesModelsSAT = Common.mytypesModelSAT.ToList();
            flvTypes.FlowItemsSource = typesModelsSAT.ToList();
        }

        private void BtnAdd_Tapped(object sender, EventArgs e)
        {
            if (!_isAgenda)
            {
                var rs = (Image)sender;
                var mImages = rs.BindingContext as TypesModel;
                foreach (var item in typesModelsSAT)
                {
                    if (item.id == mImages.id)
                    {
                        if (mImages.IsAddImage == "AddSelected.png")
                        {
                            item.IsAddImage = "Add.png";
                        }
                        else
                        {
                            item.IsAddImage = "AddSelected.png";

                        }
                    }
                    else
                    {
                        item.IsAddImage = "Add.png";
                    }
                }

                Common.mytypesModelSAT.Add(mImages);
            }
        }

        private void BtnNotification_Tapped(object sender, EventArgs e)
        {
            if (!_isAgenda)
            {
                var rs = (Image)sender;
                var mImages = rs.BindingContext as TypesModel;
                foreach (var item in typesModelsSAT)
                {
                    if (item.id == mImages.id)
                    {
                        if (mImages.IsNotificationImage == "BellSelected.png")
                        {
                            item.IsNotificationImage = "Bell.png";
                        }
                        else
                        {
                            item.IsNotificationImage = "BellSelected.png";
                        }
                    }
                    else
                    {
                        item.IsNotificationImage = "Bell.png";
                    }
                }
            }
        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

       

        }

        private void FlvTypes_FlowItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Type = e.Item;
        }

        private void FlvTypes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as TypesModel;
            if (item == null)
                return;



        }
    }
}