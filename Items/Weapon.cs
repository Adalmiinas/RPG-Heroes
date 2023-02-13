using Assignment_1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Items
{
    internal class Weapon : Item
    {
        public WeaponType Type { get; set; }  
        
        public int WeaponDamage { get; set; }

        public Weapon(string name, int rqlevel, Slot slot,
            WeaponType type, int dam) : base(name, rqlevel, slot)
        {
            Type = type;
            WeaponDamage = dam;
        }
    }
}
