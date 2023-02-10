using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_1.Items;

namespace Assignment_1.Heroes
{
    internal class Mage : Hero
    {  

        public Mage (string name): base( name, 1, new WeaponType[] {WeaponType.staff, WeaponType.wand}, new ArmorType[] { ArmorType.cloth }, new HeroAttribute(1, 1, 8))
        { 
        }

        public override void LevelUp()
        {
            this.Level += 1;
            this.LevelAttributes.Strength += 1;
            this.LevelAttributes.Dexterity += 1;
            this.LevelAttributes.Intelligence += 5;
        }

        public override void EquipArmor(Armor armor)
        {
            if (ValidArmorTypes.Contains(armor.Type))
            {
                equiment[armor.SlotPlace] = armor;
            }
            else
            {
                Console.WriteLine("Cannot equip this type of armor.");
            }
        }

        public override void EquipWeapon(Weapon weapon)
        {
            if (ValidWeaponType.Contains(weapon.Type))
            {
                equiment[weapon.SlotPlace] = weapon;
            }
            else
            {
                Console.WriteLine("Cannot equip this type of armor.");
            }
        }
    }
}
