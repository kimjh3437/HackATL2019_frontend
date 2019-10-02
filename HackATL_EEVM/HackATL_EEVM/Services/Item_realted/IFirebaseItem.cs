using HackATL_EEVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HackATL_EEVM.Services.Item_realted
{
    public interface IFirebaseItem<Item>
    {
        Task<List<Item>> GetAllAgenda();

        Task AddAgenda(Item item);

        Task<Item> GetAgenda(string Id);

        Task UpdateAgenda(string Id, Item item);

        Task DeleteAgenda(string Id);
    }
}
