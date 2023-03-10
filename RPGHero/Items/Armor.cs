using RPG_Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_Heroes.Items
{
    public class Armor: Item
    {
        //Type of armor
        public ArmorType Type { get; set; }

        //Armors attributes that increase heros attributes
        public HeroAttribute ArmorAtribute { get; set; }    

        public Armor(String name, int rqlevel, Slot slot, ArmorType armor, HeroAttribute armorAtribute) : base(name, rqlevel, slot)
        {
            this.Type = armor;
            this.ArmorAtribute = armorAtribute;
        }
    }
}
