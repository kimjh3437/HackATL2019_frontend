using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using HackATL_EEVM.Models;

namespace HackATL_EEVM.Services.Item_realted
{
    public class FirebaseItem 
    {
        FirebaseClient firebase = new FirebaseClient("https://eevmhackatl.firebaseio.com/");

        public async Task<List<Item>> GetAllAgenda()
        {
            var result = (await firebase
                .Child("AgendaEvents")
                
                .OnceAsync<Item>()).Select(item => new Item
                {
                    Id = item.Object.Id,
                    Text = item.Object.Text,
                    Time = item.Object.Time,
                    Location = item.Object.Location,
                    Type = item.Object.Type,
                    Day = item.Object.Day,
                    Description = item.Object.Description
                }).ToList();

            return result;
 
        }
        public async Task AddAgenda(Item item)
        {
            var item_inserted = item;
            await firebase
                .Child("AgendaEvents")
                .PostAsync(item_inserted);
        }

        public async Task<Item> GetAgenda(string Id)
        {
            var allAgenda = await GetAllAgenda();
            await firebase
                .Child("AgendaEvents")
                .OnceAsync<Item>();

            return allAgenda.Where(x => x.Id == Id).FirstOrDefault();
        }

        public async Task UpdateAgenda(string Id, Item item){
            var toUpdateAgenda = (await firebase
                .Child("AgendaEvents")
                .OnceAsync<Item>()).Where(x => x.Object.Id == Id).FirstOrDefault();
            var newItem = item;
            await firebase
                .Child("AgendaEvents")
                .Child(toUpdateAgenda.Key)
                .PutAsync(newItem);
                
        }

        public async Task DeleteAgenda(string Id)
        {
            var toDeleteAgenda = (await firebase
                .Child("AgendaEvents")
                .OnceAsync<Item>()).Where(x => x.Object.Id == Id).FirstOrDefault();
            await firebase.Child("AgendaEvents").Child(toDeleteAgenda.Key).DeleteAsync();
        }
    }
}
