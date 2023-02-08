using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Heroes
{
    internal class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttribute(int s, int d, int i ) {    
            Strength = s;   
            Dexterity = d;  
            Intelligence = i;   
        }  
    }
}
