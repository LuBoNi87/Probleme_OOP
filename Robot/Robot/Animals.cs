using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Animals:Target
    {     
        public override string ToString()
        {
            return "Animal";
        }
        public Animals()
        {
           Health = random.Next(2,4)*50;
        }
    }
}
