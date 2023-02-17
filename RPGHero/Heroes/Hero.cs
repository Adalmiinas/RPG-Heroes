using RPG_Heroes.Heroes.Exceptions;
using RPG_Heroes.Items;
using System.Diagnostics;
using System.Text;

namespace RPG_Heroes.Heroes
{
    public class Hero
    {
        //Name of the hero
        public string Name { get; set; }

        //Level of the hero
        public int Level { get; set; }

        //Heros Class
        public string CharacterClass { get; set; }

        //Heros valid weapon types
        public WeaponType[] ValidWeaponType { get;  set;}

        //Heros valid armor types
        public ArmorType[] ValidArmorTypes { get; set; }

        //Heros attributes
        public HeroAttribute LevelAttributes { get; set; }

        //Heros equitment
        public Dictionary<Slot, Item?> equipment { get; set; } 

        public Hero(string name, int level, string CharacterClass, WeaponType [] ValidW, ArmorType [] ValidA, HeroAttribute LevelAttributes)
        {
            this.Name = name;
            this.Level = level;
            this.CharacterClass = CharacterClass;
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

        //Equip armor for the hero
        public void EquipArmor(Armor armor)
        {
            //Throw exception if heros level is not high enough for it 
            if (armor.RqLevel > Level) throw new InvalidArmorException("Your level is not high enough!");

            //Throw exeption if hero tries to equip invalid armor type
            if (ValidArmorTypes.Contains(armor.Type))
            {
                //Delete the previous armors attributes if there is any
                if (equipment[Slot.Body] != null)
                {
                    Armor previousArmor = (Armor)equipment[Slot.Body];
                    this.LevelAttributes.Strength -= previousArmor.ArmorAtribute.Strength;
                    this.LevelAttributes.Dexterity -= previousArmor.ArmorAtribute.Dexterity;
                    this.LevelAttributes.Intelligence -= previousArmor.ArmorAtribute.Intelligence;

                }
                equipment[armor.SlotPlace] = armor;
                CalculateAttributes();
                Console.WriteLine("You have equiped a armor: " + armor.Type);
            }
            else
            {
                throw new InvalidArmorException("Your hero cannot equip this type of armor.");
            }

        }//Equip weapon for the hero
        public void EquipWeapon(Weapon weapon)
        {
            //Throw exception if heros level is not high enough for it 
            if (weapon.RqLevel > Level) throw new InvalidWeaponException("Your level is not high enough!");
            
            //Throw exception if hero tries to equip invalid weapon type
            if (ValidWeaponType.Contains(weapon.Type))
            {
                equipment[weapon.SlotPlace] = weapon;
                Console.WriteLine("You have equiped a weapon: " + weapon.Type);
            }
            else
            {
                throw new InvalidWeaponException("Your hero cannot equip this type of weapon.");
            }
        }

        //Display all info about the hero
        public virtual string Display()
        {
            StringBuilder displayStats= new StringBuilder();

            displayStats.Append(" \n");
            displayStats.Append("YOUR HERO \n");
            displayStats.Append("Name: " + Name + "\n");
            displayStats.Append("Class: " + CharacterClass + "\n");
            displayStats.Append("Total strength: " + this.LevelAttributes.Strength + "\n");
            displayStats.Append("Total dexterity: " + this.LevelAttributes.Dexterity + "\n");
            displayStats.Append("Total intelligence: " + this.LevelAttributes.Intelligence + "\n");
            displayStats.Append("Level: " + Level + "\n");
            displayStats.Append("Damage: " + CalculateDamage() + "\n");

            return displayStats.ToString();

        }

        //Calculate the attributes again if armor is added
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
    }
}
