using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Target
    {
        public int Health;
        public Planets Planet;
        public Random random = new Random();
        public bool Alive ()
        {
            if ( Health > 0)
            {
                return true;
            }
            return false;
        }
    }
}
