using Assignment_1.Items;
using System.Diagnostics;

namespace Assignment_1.Heroes
{
    internal class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public WeaponType[] ValidWeaponType { get;  set;}
        public ArmorType[] ValidArmorTypes { get; set; }
        public HeroAttribute LevelAttributes { get; set; }

        public Dictionary<Slot, Item> equiment { get; set; } 


       
        public Hero(string name, int level, WeaponType [] ValidW, ArmorType [] ValidA, HeroAttribute LevelAttributes)
        {
            this.Name = name;
            this.Level = level;
            this.LevelAttributes = LevelAttributes;
            this.ValidWeaponType = ValidW;
            this.ValidArmorTypes = ValidA;
            foreach (Slot i in Enum.GetValues(typeof (Slot)))
            {
                equiment?.Add(i, null);
            }
        }

        public virtual void LevelUp()
        {

        }
        public virtual void EquipArmor( Armor armor)
        {

        }
        public virtual void EquipWeapon(Weapon weapon)
        {

        }

        public virtual void Damage()
        {

        }

        public virtual void TotalAttribute()
        {

        }
        public virtual void Display()
        {

        }

    }
}
