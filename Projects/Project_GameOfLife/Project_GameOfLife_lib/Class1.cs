using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GameOfLife_lib
{
    public class Class1
    {
        public Popcorn giveMePopcorn(int amount, string type)
        {
            return new Popcorn(amount, type);
        }
    }
}
