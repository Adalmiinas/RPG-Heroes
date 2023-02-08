using System.Diagnostics;

namespace Assignment_1.Heroes
{
    internal class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HeroAttribute LevelAttributes { get; set; }


       
        public Hero(string name, int level, HeroAttribute LevelAttributes)
        {
            this.Name = name;
            this.Level = level;
            this.LevelAttributes = LevelAttributes; 
        }

    }
}
