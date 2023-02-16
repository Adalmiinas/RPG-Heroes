using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Heroes.Heroes.Exceptions
{
    public class InvalidWeaponException: Exception
    {
        public InvalidWeaponException() { }

        public InvalidWeaponException(string? message) : base(message)
        {
        }
    }
}
