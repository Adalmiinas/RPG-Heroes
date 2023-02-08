using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Items
{
    internal class Item
    {
        public string name { get; set; }   
        public int rqlevel { get; set; }
        public Slots slot { get; set; }   

        public Item(string name, int rqlevel, Slots slot) { 
            this.name = name;
            this.rqlevel = rqlevel; 
            this.slot = slot;
        }   
    }
}
