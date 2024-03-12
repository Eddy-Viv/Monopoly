using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{

    public struct LandingInstruction { 
        public readonly int actiontype = -1;
        public readonly string tag = "";
        public bool passedgo = false;
        public LandingInstruction(int iatype, string itag) { 
            actiontype = iatype;
            tag = itag;
            passedgo = false;
        }
    };

    public abstract class Tile
    {
        protected string name;

        protected int position;

        public Tile() { }

        abstract public LandingInstruction onLand();
    }

    public class PropertyTile : Tile { 
        
        private string tag;

        public PropertyTile(string itag) { 
            tag = itag;
        }

        override public LandingInstruction onLand() { return new LandingInstruction(0, tag); }
    }

    public class GoTile : Tile { 
        
        override public LandingInstruction onLand() { return new LandingInstruction(1, ""); }
    }

    public class InJailTile : Tile {
        override public LandingInstruction onLand() { return new LandingInstruction(2, ""); }
    }

    public class VisitingJailTile : Tile {
        override public LandingInstruction onLand() { return new LandingInstruction(3, ""); }
    }

    public class FreeParkTile : Tile {
        override public LandingInstruction onLand() { return new LandingInstruction(4, ""); }
    }

    public class GoToJailTile : Tile {
        override public LandingInstruction onLand() { return new LandingInstruction(5, ""); }
    }

    public class InTaxTile : Tile { 
        override public LandingInstruction onLand() { return new LandingInstruction(6, ""); }
    }

    public class SupTaxTile : Tile {
        override public LandingInstruction onLand() { return new LandingInstruction(7, ""); }
    }

    public class CommChestTile : Tile {
        override public LandingInstruction onLand() { return new LandingInstruction(8, ""); }
    }

    public class ChanceTile : Tile {
        override public LandingInstruction onLand() { return new LandingInstruction(9, ""); }
    }
}
