using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Board
    {
        int noplayers;
        int [] pieces;

        public Board(int nopieces) { 
            noplayers = nopieces;
            pieces = new int [nopieces];
            for (int i = 0; i < nopieces; i++)
            {
                pieces[i] = 0;
            }
        }

        bool moveTo(int piece, int dest) {
            if (dest >= 0 && dest < 41 && piece >= 0 && piece < noplayers)
            {
                pieces[piece] = dest;
                return true;
            }
            return false;
        }

        bool moveAmount(int piece, int amount) { 
            if (piece >= 0 && piece < noplayers)
            {
                pieces[piece] += amount;
                if (pieces[piece] >= 40)
                {
                    pieces[piece] -= 40;
                }
                return true;
            }
            return false;
        }

        int getPosition(int piece) {
            if (piece >= 0 && piece < noplayers) { 
                return pieces[piece];
            }
            return -1;
        }
    }
}
