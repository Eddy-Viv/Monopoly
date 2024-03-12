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
        Dictionary <int, Tile> tiles;

        public Board(int nopieces) { 
            noplayers = nopieces;
            pieces = new int [nopieces];
            for (int i = 0; i < nopieces; i++)
            {
                pieces[i] = 0;
            }

            tiles = new Dictionary<int, Tile>();

            tiles.Add(0, new GoTile());
            tiles.Add(1, new PropertyTile("KEN"));
            tiles.Add(2, new CommChestTile());
            tiles.Add(3, new PropertyTile("WHR"));
            tiles.Add(4, new InTaxTile());
            tiles.Add(5, new PropertyTile("KIS"));
            tiles.Add(6, new PropertyTile("ANG"));
            tiles.Add(7, new ChanceTile());
            tiles.Add(8, new PropertyTile("EUS"));
            tiles.Add(9, new PropertyTile("PEN"));

            tiles.Add(10, new VisitingJailTile());
            tiles.Add(11, new PropertyTile("PAL"));
            tiles.Add(12, new PropertyTile("ELU"));
            tiles.Add(13, new PropertyTile("WHH"));
            tiles.Add(14, new PropertyTile("NOR"));
            tiles.Add(15, new PropertyTile("MAS"));
            tiles.Add(16, new PropertyTile("BOW"));
            tiles.Add(17, new CommChestTile());
            tiles.Add(18, new PropertyTile("MAR"));
            tiles.Add(19, new PropertyTile("VIN"));

            tiles.Add(20, new FreeParkTile());
            tiles.Add(21, new PropertyTile("STR"));
            tiles.Add(22, new ChanceTile());
            tiles.Add(23, new PropertyTile("FLE"));
            tiles.Add(24, new PropertyTile("TRA"));
            tiles.Add(25, new PropertyTile("FES"));
            tiles.Add(26, new PropertyTile("LEI"));
            tiles.Add(27, new PropertyTile("COV"));
            tiles.Add(28, new PropertyTile("WAU"));
            tiles.Add(29, new PropertyTile("PIC"));
            

            tiles.Add(30, new GoToJailTile());
            tiles.Add(31, new PropertyTile("REG"));
            tiles.Add(32, new PropertyTile("OXF"));
            tiles.Add(33, new CommChestTile());
            tiles.Add(34, new PropertyTile("BON"));
            tiles.Add(35, new PropertyTile("LIS"));
            tiles.Add(36, new ChanceTile());
            tiles.Add(37, new PropertyTile("PAR"));
            tiles.Add(38, new SupTaxTile());
            tiles.Add(39, new PropertyTile("MAY"));

            tiles.Add(40, new InJailTile());

        }

        public LandingInstruction moveTo(int piece, int dest) {
            int from = pieces[piece];
            if (dest >= 0 && dest < 41 && piece >= 0 && piece < noplayers)
            {
                pieces[piece] = dest;
                LandingInstruction tli = tiles[dest].onLand();
                if (dest != 40 && dest < from) { 
                    tli.passedgo = true;
                }
                return tli;
            }
            return new LandingInstruction();
        }

        public LandingInstruction moveAmount(int piece, int amount) { 
            if (piece >= 0 && piece < noplayers)
            {
                pieces[piece] += amount;
                bool passedgo = false;
                if (pieces[piece] >= 40)
                {
                    pieces[piece] -= 40;
                    passedgo = true;
                }
                LandingInstruction tli = tiles[pieces[piece]].onLand();
                tli.passedgo = passedgo;
                return tli;
            }
            return new LandingInstruction();
        }

        int getPosition(int piece) {
            if (piece >= 0 && piece < noplayers) { 
                return pieces[piece];
            }
            return -1;
        }
    }
}
