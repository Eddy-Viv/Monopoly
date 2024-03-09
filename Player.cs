using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public abstract class Player
    {
        protected int money;

        int getMoney() { 
            return money;
        }
    }

    public class HumanPlayer : Player {

        public HumanPlayer() { 
            money = 1500;
        }
    
    }

    public class AIPlayer: Player {

        public AIPlayer() { 
            money = 1500;
        }
    }
}
