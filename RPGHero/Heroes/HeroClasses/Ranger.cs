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
    public class Ranger : Hero
    {

        public Ranger(string name) : base(name, 1, "Ranger",
            new WeaponType[] { WeaponType.bow }, new ArmorType[] { ArmorType.leather, ArmorType.mail },
            new HeroAttribute(1, 7, 1))
        {
        }

        //Level up character with it's own values
        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 1;
            LevelAttributes.Dexterity += 5;
            LevelAttributes.Intelligence += 1;
        }

        //Calculate the damage that the hero creates
        //Damage formula 
        //Hero Damage = WeaponDamage * (1+ DamagingAttribute/100) 
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
