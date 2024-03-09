using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Monopoly
{
    class Game
    {
        Board board;

        List <Player> players = new List<Player>();
        int noplayers;

        PropertyList properties;

        Dice dice;

        public Game(int nnoplayers) { 
            if (nnoplayers >= 2)
            {
                noplayers = nnoplayers;
                players.Add(new HumanPlayer());
                for (int i = 1; i < noplayers; i++) { 
                    players.Add(new AIPlayer());
                }

                board = new Board(4);


            }
        }
    }
}
