using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class SuperHeroes : Target
    {
        public override string ToString()
        {
            return "SuperHero";
        }
        public SuperHeroes ()
        {
            Health = random.Next(7, 9) * 50;
        }
    }
}
