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
        List <Player> players = new List<Player>();
        int noplayers;

        Board board;

        PropertyList properties;

        Dice dice;

        int turn;

        public Game(int nnoplayers) { 
            if (nnoplayers >= 2)
            {
                noplayers = nnoplayers;
                players.Add(new HumanPlayer());
                for (int i = 1; i < noplayers; i++) { 
                    players.Add(new AIPlayer());
                }

                board = new Board(noplayers);

                properties = new PropertyList();

                dice = new Dice();

                turn = -1;

            }
        }

        public void rollDice() { 
            dice.roll();
        }

        public int getDice(int diceno) { 
            return dice.read(diceno);
        }

        public int getTurn() { 
            return turn;
        }
    }
}
