using System;

using HackATL_EEVM.Models;

namespace HackATL_EEVM.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Time = item?.Time;
            Location = item?.Location;
            Type = item?.Type;
            Day = item?.Day;
            Description = item?.Description;


            Item = item;
        }
    }
}
