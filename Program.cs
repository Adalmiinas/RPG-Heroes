using Assignment_1.Heroes;
using Assignment_1.Heroes.Exceptions;
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
            weapons.Add(2, new Weapon("Bouncy Bow", 3, Slot.Weapon, WeaponType.bow, 4));
            weapons.Add(3, new Weapon("Dangerous Dagger", 1, Slot.Weapon, WeaponType.dagger, 5));
            weapons.Add(4, new Weapon("Hard Hammer", 5, Slot.Weapon, WeaponType.hammer, 9));
            weapons.Add(5, new Weapon("Tippy Staff", 2, Slot.Weapon, WeaponType.staff, 11));
            weapons.Add(6, new Weapon("Swift Sword", 4, Slot.Weapon, WeaponType.sword, 28));
            weapons.Add(7, new Weapon("Windy Wand", 2, Slot.Weapon, WeaponType.wand, 17));

            Dictionary<int, Armor> armors = new Dictionary<int, Armor>();
            armors.Add(1, new Armor("Clingy Cloth", 1, Slot.Body, ArmorType.cloth, new HeroAttribute(1,2,1)));
            armors.Add(2, new Armor("Lousy Leather", 3, Slot.Body, ArmorType.leather, new HeroAttribute(1, 2, 1)));
            armors.Add(3, new Armor("Minumum Mail", 2, Slot.Body, ArmorType.mail, new HeroAttribute(1, 2, 1)));
            armors.Add(4, new Armor("Pretty Plate", 4, Slot.Body, ArmorType.plate, new HeroAttribute(1, 2, 1)));

            while (cont) {
                Console.WriteLine(" \n" +
                  "You can use these commands: \n" +
                "hero - create a new hero \n" +
                "level - level up your character \n" +
                "equip - get a armor or weapon \n"+ 
                "display - details of your Hero \n" +
                "bye - stop the program " + "\n");
                String command = Console.ReadLine();
                

                switch (command)
                {
                    case "hero":
                        Console.WriteLine("Select your hero type: mage/ranger/rogue/warrior");
                        string heroSelection = Console.ReadLine();
                        switch (heroSelection)
                        {
                            case "mage":
                                Console.WriteLine("Enter your heros name:");
                                string name1 = Console.ReadLine();

                                Mage mage = new Mage(name1);

                                currentHero.Add(1, mage);

                                Console.WriteLine("You have made a Mage hero with a name " + currentHero[1].Name);
                                break;

                            case "ranger":
                                Console.WriteLine("Enter your heros name:");
                                string name2 = Console.ReadLine();

                                Ranger ranger = new Ranger(name2);

                                currentHero.Add(1, ranger);

                                Console.WriteLine("You have made a Ranger hero with a name " + currentHero[1].Name);
                                break;

                            case "rogue":
                                Console.WriteLine("Enter your heros name:");
                                string name3 = Console.ReadLine();

                                Rogue rogue = new Rogue(name3);

                                currentHero.Add(1, rogue);

                                Console.WriteLine("You have made a Rogue hero with a name " + currentHero[1].Name);
                                break;

                            case "warrior":
                                Console.WriteLine("Enter your heros name:");
                                string name4 = Console.ReadLine();

                                Warrior warrior = new Warrior(name4);

                                currentHero.Add(1, warrior);

                                Console.WriteLine("You have made a Warrior hero with a name " + currentHero[1].Name);
                                break;

                            default:
                                Console.WriteLine("Not a valid hero name!");
                                break;

                        }
                        break;

                    case "level":
                        if(currentHero.Count == 0)
                        {
                            Console.WriteLine("You have to create a hero first!");
                        }
                        else
                        {
                            
                            currentHero[1].LevelUp();
                            Console.WriteLine("Your hero " + currentHero[1].Name + " is at level " + currentHero[1].Level + ".");
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
                                catch (InvalidArmorException ex)
                                {
                                    Console.WriteLine(ex.Message);
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
                                catch (InvalidWeaponException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                break;

                            default:
                                Console.WriteLine("Not a valid command!");
                                break;
                        }
                        break;

                    case "display":
                        if (currentHero.Count == 0)
                        {
                            Console.WriteLine("You have to make a hero first!");
                        }
                        else
                        {
                            Console.WriteLine(currentHero[1].Display());
                        }
                        break;
                    case "bye":
                        cont = false;
                        break;

                    default:
                        Console.WriteLine("Not a valid command! Try again \n ");
                     
                        break;
                }
            }
        }
    }
} 