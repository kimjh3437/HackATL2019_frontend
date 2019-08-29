using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Xamarin.Forms.Xaml;

using HackATL_EEVM.Models;
using HackATL_EEVM.Views;
using HackATL_EEVM;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using HackATL_EEVM.Helpers_token;

namespace HackATL_EEVM.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        
        public ObservableCollection<Item> Items { get; set; }

        public ObservableCollection<Item> Items_PRE { get; set; }

        public ObservableCollection<Item> Items_FRI { get; set; }

        public ObservableCollection<Item> Items_SAT { get; set; }

        public ObservableCollection<Item> Items_SUN { get; set; }

        public ObservableCollection<Item> MyItems { get; set; }
        public ObservableCollection<Item> MyItems_agenda { get; set; }
        public List<Item> SavedAgenda { get; set; }
        // used for save added list of agenda in the current application setting

        public string Notification_image;
        public int notcase;


        public ObservableCollection<Item> FRI { get;set; }    
        public Command LoadItemsCommand { get; set; }
        public Command LoadMyItemsCommand { get; set; }



        public ItemsViewModel()
        {

            SavedAgenda = new List<Item>();
            
            Title = "Agenda";
            MyItems = new ObservableCollection<Item>();
            MyItems_agenda = new ObservableCollection<Item>();
            Items = new ObservableCollection<Item>();
            
            Items_PRE = new ObservableCollection<Item>();
            Items_FRI = new ObservableCollection<Item>();
            Items_SAT = new ObservableCollection<Item>();
            Items_SUN = new ObservableCollection<Item>();

            LoadMyItemsCommand = new Command(() =>  ExecuteLoadMyItemsCommand());
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            

            
            MessagingCenter.Subscribe<HackATL_EEVM.Views.Pages.Agenda_children.Agenda_childrenDays.Agenda_agendaFRI, Item>(this, "Addtothelist", (sender, Itemlist) =>
            {
                var listed = Itemlist as Item; 
                MyItems.Add(listed);
                SavedAgenda.Add(listed);
                //DataStore.AddItemAsync(listed);
                //App.MyItemController.SaveMyItem(listed);


            });
            MessagingCenter.Subscribe<HackATL_EEVM.Views.Pages.Agenda_children.Agenda_childrenDays.Agenda_agendaPRE, Item>(this, "Addtothelist", (sender, Itemlist) =>
            {
                var listed = Itemlist as Item;
                MyItems.Add(listed);
                SavedAgenda.Add(listed);
                //DataStore.AddItemAsync(listed);
                //App.MyItemController.SaveMyItem(listed);

            });
            MessagingCenter.Subscribe<HackATL_EEVM.Views.Pages.Agenda_children.Agenda_childrenDays.Agenda_agendaSAT, Item>(this, "Addtothelist", (sender, Itemlist) =>
            {
                var listed = Itemlist as Item;
                MyItems.Add(listed);
                SavedAgenda.Add(listed);
                //DataStore.AddItemAsync(listed);
                //App.MyItemController.SaveMyItem(listed);

            });
            MessagingCenter.Subscribe<HackATL_EEVM.Views.Pages.Agenda_children.Agenda_childrenDays.Agenda_agendaSUN, Item>(this, "Addtothelist", (sender, Itemlist) =>
            {
                var listed = Itemlist as Item;
                MyItems.Add(listed);
                SavedAgenda.Add(listed);
                //DataStore.AddItemAsync(listed);
                //App.MyItemController.SaveMyItem(listed);

            });
            
            

        }
        public string NotificationImage(int number)
        {
            string noti = "";
            if (number == 1)
            {
                noti = "notification.png";

            }
            else if (number == 0)
                noti = "notification2.png";

            return noti;
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {

                Items.Clear();
                Items_FRI.Clear();
                Items_SAT.Clear();
                Items_SUN.Clear();
                Items_PRE.Clear();
                var items = await DataStore.GetItemsAsync(true);
                
                foreach (var item in items)
                {
                    if (item.Day == "FRI")
                    {
                        Items_FRI.Add(item);
                    }
                        
                    if (item.Day == "SAT")
                    {
                        Items_SAT.Add(item);
                    }
                        
                    if (item.Day == "SUN")
                    {
                        Items_SUN.Add(item);
                    }
                        
                    if (item.Day == "PRE")
                    {
                        Items_PRE.Add(item);
                    }
                        
                    
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        void ExecuteLoadMyItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                MyItems.Clear();
                string list = Settings.myAgendaList;
                var list_deserialized = JsonConvert.DeserializeObject<List<Item>>(list);               
                var items = MyItems; 
                foreach (var item in list_deserialized)  //Originally foreach (var item in items) 
                {
                    MyItems.Add(item);
                }
                
                var savedAgenda_srl = JsonConvert.SerializeObject(SavedAgenda);
                Settings.myAgendaList = savedAgenda_srl;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }




    }
}