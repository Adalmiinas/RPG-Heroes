using RPG_Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Items
{
    public class Weapon : Item
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
