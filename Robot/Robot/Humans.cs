using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class Humans:Target
    {
        public override string ToString()
        {
            return "Human";
        }
        public Humans()
        {
           Health = 100;
        }
    }
}
