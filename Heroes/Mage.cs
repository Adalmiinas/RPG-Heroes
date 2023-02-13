using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_1.Heroes.Exceptions;
using Assignment_1.Items;

namespace Assignment_1.Heroes
{
    internal class Mage : Hero
    {  

        public Mage (string name): base( name, 1, 
            new WeaponType[] {WeaponType.staff, WeaponType.wand}, new ArmorType[] { ArmorType.cloth }, 
            new HeroAttribute(1, 1, 8))
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
            if (armor.RqLevel > Level) throw new InvalidArmorException("Your level is not high enough!");
            if (ValidArmorTypes.Contains(armor.Type))
            {
                equipment[armor.SlotPlace] = (Armor)armor;
                Console.WriteLine("You have equiped a armor: " + armor.Type);
            }
            else
            {
                throw new InvalidArmorException("Your hero cannot equip this type of armor.");
            }
        }

        public override void EquipWeapon(Weapon weapon)
        {
            if (weapon.RqLevel > Level) throw new InvalidWeaponException("Your level is not high enough!");
            if (ValidWeaponType.Contains(weapon.Type))
            {
                equipment[weapon.SlotPlace] = (Weapon) weapon;
                Console.WriteLine("You have equiped a weapon: " + weapon.Type);
            }
            else
            {
                throw new InvalidWeaponException("Your hero cannot equip this type of weapon.");
            }
        }

        public override decimal CalculateDamage()
        {

            Weapon weaponItem = (Weapon) equipment[Slot.Weapon];
            decimal charDam = LevelAttributes.Intelligence;
            if (weaponItem == null )
            {
                return 1*(1+charDam/100);
            }
            else
            {
                
                decimal damage = weaponItem.WeaponDamage * (1 + charDam/100);
                return damage;
            }            
        }
        public override string getHero()
        {
            return "Mage";
        }
    }
}
