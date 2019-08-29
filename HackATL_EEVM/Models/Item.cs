using SQLite;
using System;

namespace HackATL_EEVM.Models
{
    public class Item
    {
        [PrimaryKey]
        public string Id { get; set; }
       
        public string Text { get; set; }
      
        public string Time { get; set; }
        
        public string Location { get; set; }
       
        public string Type { get; set; }
        
        public string Day { get; set; }
        
        public string Description { get; set; }

        
    }
}