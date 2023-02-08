using Assignment_1.Heroes;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");

            Boolean cont = true;
            IDictionary<int, Hero> character = new Dictionary<int, Hero>();


            while(cont) {
                Console.WriteLine("You can use these commands: \n " +
                "hero - create a new hero \n" +
                "level - level up your character \n" +
                "bye - stop the program");
                String command = Console.ReadLine();

                switch (command)
                {
                    case "hero":
                        Console.WriteLine("Enter your character name:");
                        string name = Console.ReadLine();

                        Mage mage = new Mage(name);
                        mage.LevelUp();
                        character.Add(1, mage);

                        Console.WriteLine("Calling mage " + mage.Level);
                        break;

                    case "level":
                       
                        Console.WriteLine("Character level is " + character[1]);
                        break;
                    case "bye":
                        cont = false;
                        break;
                }
            }
        }
    }
} 