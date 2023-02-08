using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Heroes
{
    internal class Mage : Hero
    {  

        public Mage (string name): base( name, 1, new HeroAttribute(1, 1, 8))
        { 
        }

        public void LevelUp()
        {
            this.Level += 1;
            this.LevelAttributes.Strength += 1;
            this.LevelAttributes.Dexterity+= 1;
            this.LevelAttributes.Intelligence += 5;
        }
    }
}
