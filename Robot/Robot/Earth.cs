using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Earth:Planets
    {
        public Earth ( )
        {
            Targets = new Target[] { new Animals(), new SuperHeroes(), new Humans() };
            
        }
    }
}
