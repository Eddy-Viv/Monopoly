using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Dice
    {
        int dice1;
        int dice2;

        readonly Random rnd;

        public Dice() { 
            dice1 = 1;
            dice2 = 1;
            rnd = new Random();
        }

        public void roll() { 
            dice1 = (rnd.Next() % 6) + 1;
            dice2 = (rnd.Next() % 6) + 1;
        }

        public int read(int diceno) {
            switch (diceno) { 
                case 1:
                    return dice1;
                case 2:
                    return dice2;
                case 3:
                    return dice1 + dice2;
                default:
                    return 0;
            }
        }
    }
}
