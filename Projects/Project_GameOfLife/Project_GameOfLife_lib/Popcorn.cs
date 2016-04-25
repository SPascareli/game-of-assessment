using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GameOfLife_lib
{
    public class Popcorn
    {
        public int popcornAmount;
        public string popcornType;

        public Popcorn(int amount, string type)
        {
            this.popcornAmount = amount;
            this.popcornType = type;
        }

        public string tellMe()
        {
            return "The popcorn is of type " + popcornType + " and has the amount of " + popcornAmount;
        }
    }
}
