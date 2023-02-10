using Assignment_1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_1.Items
{
    internal class Armor: Item
    {
        public ArmorType Type { get; set; }
        public HeroAttribute ArmorAtribute { get; set; }    

        public Armor(String name, int rqlevel, Slot slot, ArmorType armor, HeroAttribute armorAtribute) : base(name, rqlevel, slot)
        {
            this.Type = armor;
            this.ArmorAtribute = armorAtribute;

        }
    }
}
