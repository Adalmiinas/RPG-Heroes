using RPG_Heroes.Heroes.Exceptions;
using RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Heroes.HeroClasses
{
    public class Rogue : Hero
    {

        public Rogue(string name) : base(name, 1, "Rogue", 
            new WeaponType[] { WeaponType.dagger, WeaponType.sword }, new ArmorType[] { ArmorType.leather, ArmorType.mail },
            new HeroAttribute(2, 6, 1))
        {
        }

        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 1;
            LevelAttributes.Dexterity += 4;
            LevelAttributes.Intelligence += 1;
        }
        public override decimal CalculateDamage()
        {

            Weapon weaponItem = (Weapon)equipment[Slot.Weapon];
            decimal charDam = LevelAttributes.Dexterity;
            if (weaponItem == null)
            {
                return 1 * (1 + charDam / 100);
            }
            else
            {

                decimal damage = weaponItem.WeaponDamage * (1 + charDam / 100);
                return damage;
            }
        }
    }
}
