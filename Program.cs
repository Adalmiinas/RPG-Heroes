using Assignment_1.Heroes;
using Assignment_1.Items;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");

            Boolean cont = true;
            Dictionary<int, Hero> currentHero = new Dictionary<int, Hero> ();
            Dictionary<int, Weapon> weapons = new Dictionary<int, Weapon> ();
            weapons.Add(1,new Weapon("Aggressive Axe", 1, Slot.Weapon, WeaponType.axe, 2));
            weapons.Add(2, new Weapon("Bouncy Bow", 1, Slot.Weapon, WeaponType.bow, 4));
            weapons.Add(3, new Weapon("Dangerous Dagger", 1, Slot.Weapon, WeaponType.dagger, 5));
            weapons.Add(4, new Weapon("Hard Hammer", 1, Slot.Weapon, WeaponType.hammer, 9));
            weapons.Add(5, new Weapon("Tippy Staff", 1, Slot.Weapon, WeaponType.staff, 11));
            weapons.Add(6, new Weapon("Swift Sword", 1, Slot.Weapon, WeaponType.sword, 28));
            weapons.Add(7, new Weapon("Windy Wand", 1, Slot.Weapon, WeaponType.wand, 17));

            Dictionary<int, Armor> armors = new Dictionary<int, Armor>();
            armors.Add(1, new Armor("Clingy Cloth", 1, Slot.Body, ArmorType.cloth, new HeroAttribute(1,2,1)));
            armors.Add(2, new Armor("Lousy Leather", 1, Slot.Body, ArmorType.leather, new HeroAttribute(1, 2, 1)));
            armors.Add(3, new Armor("Minumum Mail", 1, Slot.Body, ArmorType.mail, new HeroAttribute(1, 2, 1)));
            armors.Add(4, new Armor("Pretty Plate", 1, Slot.Body, ArmorType.plate, new HeroAttribute(1, 2, 1)));

            while (cont) {
                Console.WriteLine("You can use these commands: \n " +
                "hero - create a new hero \n" +
                "level - level up your character \n" +
                "equip - get a armor or weapon \n"+ 
                "bye - stop the program " + "\n");
                String command = Console.ReadLine();
                

                switch (command)
                {
                    case "hero":
                        Console.WriteLine("Enter your character name:");
                        string name = Console.ReadLine();

                        Mage mage = new Mage(name);
     
                        currentHero.Add(1, mage);

                        Console.WriteLine("Calling mage " + mage.ValidWeaponType[0]);
                        break;

                    case "level":
                        if(currentHero.Count == 0)
                        {
                            Console.WriteLine("You don't have a hero yet");
                        }
                        else
                        {
                            currentHero[1].LevelUp();
                            Console.WriteLine(currentHero[1].Level);

                        }
                        
                        break;

                    case "equip":
                        Console.WriteLine("Do you want weapon or armor? w/a:");
                        string weaponCommand = Console.ReadLine();

                        switch (weaponCommand) 
                        {
                            case "a":
                                Console.WriteLine("Pick out your armor with it's number:");
                                for (int i = 1; i <= armors.Count; i++)
                                {
                                    Console.WriteLine(i + ": " + armors[i].Name + ". The required level is " + armors[i].RqLevel + ".");
                                }
                                int armorNumber = int.Parse(Console.ReadLine());
                                try
                                {
                                    currentHero[1].EquipArmor(armors[armorNumber]);

                                }
                                catch (Exception ex)
                                {

                                }

                                break;

                            case "w":
                                Console.WriteLine("Pick out your armor with it's number:");
                                for (int i = 1; i <= weapons.Count; i++)
                                {
                                    Console.WriteLine(i + ": " + weapons[i].Name + ". The required level is " + weapons[i].RqLevel + ".");
                                }
                                int weaponNumber = int.Parse(Console.ReadLine());
                                try
                                {
                                    currentHero[1].EquipWeapon(weapons[weaponNumber]);

                                }
                                catch (Exception ex)
                                {

                                }
                                break;
                        }
                    
                          

                        break;
                    case "bye":
                        cont = false;
                        break;

                    default:
                        Console.WriteLine("Not a valid command! \n ");
                        break;
                }
            }
        }
    }
} 