using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Items
{
    public class Item
    {
        public string Name { get; set; }   
        public int RqLevel { get; set; }
        public Slot SlotPlace { get; set; }   

        public Item(string name, int rqlevel, Slot slot) { 
            this.Name = name;
            this.RqLevel = rqlevel; 
            this.SlotPlace = slot;
        }   
    }
}
