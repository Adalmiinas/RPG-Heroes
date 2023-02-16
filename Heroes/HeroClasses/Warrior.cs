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
    public class Warrior : Hero
    {

        public Warrior(string name) : base(name, 1, "Warrior",
            new WeaponType[] { WeaponType.axe, WeaponType.hammer, WeaponType.sword }, new ArmorType[] { ArmorType.mail, ArmorType.plate },
            new HeroAttribute(5, 2, 1))
        {
        }

        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes.Strength += 3;
            LevelAttributes.Dexterity += 2;
            LevelAttributes.Intelligence += 1;
        }

        public override decimal CalculateDamage()
        {

            Weapon weaponItem = (Weapon)equipment[Slot.Weapon];
            decimal charDam = LevelAttributes.Strength;
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
