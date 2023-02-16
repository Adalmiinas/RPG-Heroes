using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Heroes.Heroes.Exceptions;
using RPG_Heroes.Items;

namespace RPG_Heroes.Heroes.HeroClasses
{
    public class Mage : Hero
    {

        public Mage(string name) : base(name, 1, "Mage",
            new WeaponType[] { WeaponType.staff, WeaponType.wand }, new ArmorType[] { ArmorType.cloth },
            new HeroAttribute(1, 1, 8))
        {
        }

        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 1;
            LevelAttributes.Dexterity += 1;
            LevelAttributes.Intelligence += 5;
        }

        public override decimal CalculateDamage()
        {

            Weapon weaponItem = (Weapon)equipment[Slot.Weapon];
            decimal charDam = LevelAttributes.Intelligence;
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
