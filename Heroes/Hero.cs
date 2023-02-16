using RPG_Heroes.Items;
using System.Diagnostics;
using System.Text;

namespace RPG_Heroes.Heroes
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public WeaponType[] ValidWeaponType { get;  set;}
        public ArmorType[] ValidArmorTypes { get; set; }
        public HeroAttribute LevelAttributes { get; set; }
        public Dictionary<Slot, Item?> equipment { get; set; } 

        public Hero(string name, int level, WeaponType [] ValidW, ArmorType [] ValidA, HeroAttribute LevelAttributes)
        {
            this.Name = name;
            this.Level = level;
            this.LevelAttributes = LevelAttributes;
            this.ValidWeaponType = ValidW;
            this.ValidArmorTypes = ValidA;
            equipment = new Dictionary<Slot, Item?>();
            foreach (Slot i in Enum.GetValues(typeof (Slot)))
            {
                equipment.Add(i, null);
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

        public virtual string Display()
        {
            StringBuilder displayStats= new StringBuilder();

            displayStats.Append(" \n");
            displayStats.Append("Your character: \n");
            displayStats.Append("Name: " + Name + "\n");
            displayStats.Append("Class: " + getHero() + "\n");
            displayStats.Append("Total strength: " + this.LevelAttributes.Strength + "\n");
            displayStats.Append("Total dexterity: " + this.LevelAttributes.Dexterity + "\n");
            displayStats.Append("Total intelligence: " + this.LevelAttributes.Intelligence + "\n");
            displayStats.Append("Level: " + Level + "\n");
            displayStats.Append("Damage: " + CalculateDamage() + "\n");

            return displayStats.ToString();

        }

        public void CalculateAttributes(){
            
            foreach (Item? item in equipment.Values)
            {
                if (item == null || item.SlotPlace == Slot.Weapon)  continue; 
                
                    Armor armor = (Armor)item;
                    this.LevelAttributes.Strength += armor.ArmorAtribute.Strength;
                    this.LevelAttributes.Dexterity += armor.ArmorAtribute.Dexterity;
                    this.LevelAttributes.Intelligence += armor.ArmorAtribute.Intelligence;
                
            }
        }
        public virtual decimal CalculateDamage() 
        {
            return 1;
        }

        public virtual string getHero()
        {
            return "";
        }
    }
}
