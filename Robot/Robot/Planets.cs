using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Planets
    {
        public Target[] Targets;
        public bool ContainsLife()
        {
            for ( int i = 0;  i < Targets.Length; i ++ )
            {
               
                if ( Targets[i].Alive() == true)
                    return true;
            }
            return false;
        }
    }
}
