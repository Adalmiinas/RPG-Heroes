using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Items
{
    public class Item
    {
        //Name of the weapon or armor
        public string Name { get; set; }   

        //Level required to equip the weapon or armor
        public int RqLevel { get; set; }

        //Place where item is saved for the character
        public Slot SlotPlace { get; set; }   

        public Item(string name, int rqlevel, Slot slot) { 
            this.Name = name;
            this.RqLevel = rqlevel; 
            this.SlotPlace = slot;
        }   
    }
}
