using HackATL_EEVM.Models;
using HackATL_EEVM.Services;
using HackATL_EEVM.Views.AdminPages.Admin_children.AdminNavPAges;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackATL_EEVM.ViewModels.Admin_related
{
    public class AgendaAdminViewModel : BaseViewModel
    {
        public Item item { get; set; }
        public Command AddItem { get; set; }
      
        public AgendaAdminViewModel()
        {
            item = new Item { };
            //AddItem = new Command(() => ExecuteAddItem(item));
            MessagingCenter.Subscribe<Admin_agenda_Add, Item>(this, "AddItem", async (obj, item) =>
            {
                
                var newItem = item as Item;
                await DataStore.AddItemAsync(newItem);
                
            });
            
            //async Task ExecuteAddItem(Item item)
            //{
            //    await FirebaseItem.AddAgenda(item);

            //}
        }

    }
}
