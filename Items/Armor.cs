using Assignment_1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_1.Items
{
    internal class Armor
    {
        public ArmorType Type { get; set; }
        public HeroAttribute ArmorAtribute { get; set; }    

        public Armor(ArmorType armor, HeroAttribute armotAtribute) : base()
        {
            this.Type = armor;
            this.ArmorAtribute = armotAtribute;

        }
    }
}
