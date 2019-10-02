using HackATL_EEVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace HackATL_EEVM.Database
{
  
    public class MyITemController 
    {
        public ObservableCollection<Item>Itemlist { get; set; }
        public List<Item>listitem { get; set; }
        
        

        static object locker = new object();
        SQLiteConnection database;
        IEnumerable<Item> list;

        public IEnumerable<Item> List
        {
            get
            {
                if (list == null)
                    list = GetMyItem();
                return list;
            }
        }
        

        public MyITemController()
        {
            listitem = new List<Item>();
            
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<User>();
            Itemlist = new ObservableCollection<Item>();
            

            /*
            MessagingCenter.Subscribe<HackATL_EEVM.Views.Pages.Agenda_children.Agenda_childrenDays.Agenda_agendaFRI, Item>(this, "Addtothelist", (sender, Itemlist) =>
            {
                var listed = Itemlist as Item;
               
                App.MyItemController.SaveMyItem(listed);


            });
            MessagingCenter.Subscribe<HackATL_EEVM.Views.Pages.Agenda_children.Agenda_childrenDays.Agenda_agendaPRE, Item>(this, "Addtothelist", (sender, Itemlist) =>
            {
                var listed = Itemlist as Item;               
                App.MyItemController.SaveMyItem(listed);

            });
            MessagingCenter.Subscribe<HackATL_EEVM.Views.Pages.Agenda_children.Agenda_childrenDays.Agenda_agendaSAT, Item>(this, "Addtothelist", (sender, Itemlist) =>
            {
                var listed = Itemlist as Item;                
                App.MyItemController.SaveMyItem(listed);

            });
            MessagingCenter.Subscribe<HackATL_EEVM.Views.Pages.Agenda_children.Agenda_childrenDays.Agenda_agendaSUN, Item>(this, "Addtothelist", (sender, Itemlist) =>
            {
                var listed = Itemlist as Item;              
                App.MyItemController.SaveMyItem(listed);

            });
            */
            

        }



        public IEnumerable<Item> GetMyItem()
        {

            var table = (from i in database.Table<Item>() select i);
            
            foreach(var item in table)
            {
                listitem.Add(new Item()
                {
                    Text = item.Text,
                    Time = item.Time,
                    Location = item.Location,
                    Type = item.Type,
                    Day = item.Day,
                    Description = item.Description

                }); 
            }
            return listitem;
        }   
            /*lock (locker) {
                if (database.Table<Item>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    var result = database.Table<Item>().First();
                    return result;
                    



                }
            }
        }
        */
        

        public int SaveMyItem(Item item)
        {
            lock (locker)
            {
               return database.Insert(item);
            }
        }

         public int DeleteMyItem(string id)
         {
            lock (locker)
            {
                return database.Delete<Item>(id);
            }
         }
        public void refresher()
        {
            Itemlist.Clear();
            var table = (from i in database.Table<Item>() select i);

            foreach (var item in table)
            {
                Itemlist.Add(new Item()
                {
                    Text = item.Text,
                    Time = item.Time,
                    Location = item.Location,
                    Type = item.Type,
                    Day = item.Day,
                    Description = item.Description

                });
            }
        }

    }
}
