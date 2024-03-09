using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Monopoly
{
    
    public class PropertyList { 
        
        Dictionary <string, Property> plist;

        public PropertyList() { 
            plist = new Dictionary<string, Property>();
            plist.Add("KEN", new Property("KEN"));
            plist.Add("WHR", new Property("WHR"));
            plist.Add("ANG", new Property("ANG"));
            plist.Add("EUS", new Property("EUS"));
            plist.Add("PEN", new Property("PEN"));
            plist.Add("PAL", new Property("PAL"));
            plist.Add("WHH", new Property("WHH"));
            plist.Add("NOR", new Property("NOR"));
            plist.Add("BOW", new Property("BOW"));
            plist.Add("MAR", new Property("MAR"));
            plist.Add("VIN", new Property("VIN"));
            plist.Add("STR", new Property("STR"));
            plist.Add("FLE", new Property("FLE"));
            plist.Add("TRA", new Property("TRA"));
            plist.Add("LEI", new Property("LEI"));
            plist.Add("COV", new Property("COV"));
            plist.Add("PIC", new Property("PIC"));
            plist.Add("REG", new Property("REG"));
            plist.Add("OXF", new Property("OXF"));
            plist.Add("BON", new Property("BON"));
            plist.Add("PAR", new Property("PAR"));
            plist.Add("MAY", new Property("MAY"));
            plist.Add("KIS", new StationProperty("KIS"));
            plist.Add("MAS", new StationProperty("MAS"));
            plist.Add("FES", new StationProperty("FES"));
            plist.Add("LIS", new StationProperty("LIS"));
            plist.Add("ELU", new UtilityProperty("ELU"));
            plist.Add("WAU", new UtilityProperty("WAU"));
        }

        public string getName(string itag) { 
            return plist[itag].getName();
        }

        public int getPrice(string itag) { 
            return plist[itag].getPrice();
        }

        public int getRent(string itag, int diceval) {
            int towner = plist[itag].getOwner();
            int tnoinset = 0;
            switch (itag) { 
                case "KEN":
                case "WHR":
                    if (towner == plist["KEN"].getOwner()) { tnoinset++; }
                    if (towner == plist["WHR"].getOwner()) { tnoinset++; }
                    return plist[itag].getRent(diceval, tnoinset);
                case "ANG":
                case "EUS":
                case "PEN":
                    if (towner == plist["ANG"].getOwner()) { tnoinset++; }
                    if (towner == plist["EUS"].getOwner()) { tnoinset++; }
                    if (towner == plist["PEN"].getOwner()) { tnoinset++; }
                    return plist[itag].getRent(diceval, tnoinset);
                case "PAL":
                case "WHH":
                case "NOR":
                    if (towner == plist["PAL"].getOwner()) { tnoinset++; }
                    if (towner == plist["WHH"].getOwner()) { tnoinset++; }
                    if (towner == plist["NOR"].getOwner()) { tnoinset++; }
                    return plist[itag].getRent(diceval, tnoinset);
                case "BOW":
                case "MAR":
                case "VIN":
                    if (towner == plist["BOW"].getOwner()) { tnoinset++; }
                    if (towner == plist["MAR"].getOwner()) { tnoinset++; }
                    if (towner == plist["VIN"].getOwner()) { tnoinset++; }
                    return plist[itag].getRent(diceval, tnoinset);
                case "STR":
                case "FLE":
                case "TRA":
                    if (towner == plist["STR"].getOwner()) { tnoinset++; }
                    if (towner == plist["FLE"].getOwner()) { tnoinset++; }
                    if (towner == plist["TRA"].getOwner()) { tnoinset++; }
                    return plist[itag].getRent(diceval, tnoinset);
                case "LEI":
                case "COV":
                case "PIC":
                    if (towner == plist["LEI"].getOwner()) { tnoinset++; }
                    if (towner == plist["COV"].getOwner()) { tnoinset++; }
                    if (towner == plist["PIC"].getOwner()) { tnoinset++; }
                    return plist[itag].getRent(diceval, tnoinset);
                case "REG":
                case "OXF":
                case "BON":
                    if (towner == plist["REG"].getOwner()) { tnoinset++; }
                    if (towner == plist["OXF"].getOwner()) { tnoinset++; }
                    if (towner == plist["BON"].getOwner()) { tnoinset++; }
                    return plist[itag].getRent(diceval, tnoinset);
                case "PAR":
                case "MAY":
                    if (towner == plist["PAR"].getOwner()) { tnoinset++; }
                    if (towner == plist["MAY"].getOwner()) { tnoinset++; }
                    return plist[itag].getRent(diceval, tnoinset);
                case "KIS":
                case "MAS":
                case "FES":
                case "LIS":
                    if (towner == plist["KIS"].getOwner()) { tnoinset++; }
                    if (towner == plist["MAS"].getOwner()) { tnoinset++; }
                    if (towner == plist["FES"].getOwner()) { tnoinset++; }
                    if (towner == plist["LIS"].getOwner()) { tnoinset++; }
                    return plist[itag].getRent(diceval, tnoinset);
                case "ELU":
                case "WAU":
                    if (towner == plist["ELU"].getOwner()) { tnoinset++; }
                    if (towner == plist["WAU"].getOwner()) { tnoinset++; }
                    return plist[itag].getRent(diceval, tnoinset);
                default:
                    return 0;
            }
        }

        public int getOwner(string itag) { 
            return plist[itag].getOwner();
        }

        public bool getMortgaged(string itag) { 
            return plist[itag].getMortgaged();
        }
    }
    
    
    public class Property
    {
        protected string name;
        protected string tag;
        protected int price;
        protected int [] rentprices;
        private int buildcost {get;}
        private int noinfullset {get;}

        
        protected int owner;

        protected bool mortgaged;

        private int nohouses {get; set;}

        public Property() { }
        public Property(string itag) { 
            rentprices = new int [6];
            tag = itag;
            switch (tag) { 
                case "KEN":
                    name = "Old Kent Road";
                    price = 60;
                    rentprices[0] = 2;
                    rentprices[1] = 10;
                    rentprices[2] = 30;
                    rentprices[3] = 90;
                    rentprices[4] = 160;
                    rentprices[5] = 250;
                    buildcost = 50;
                    noinfullset = 2;
                    break;
                case "WHR":
                    name = "Whitechapel Road";
                    price = 60;
                    rentprices[0] = 4;
                    rentprices[1] = 20;
                    rentprices[2] = 60;
                    rentprices[3] = 180;
                    rentprices[4] = 320;
                    rentprices[5] = 450;
                    buildcost = 50;
                    noinfullset = 2;
                    break;
                case "ANG":
                    name = "The Angel, Islington";
                    price = 100;
                    rentprices[0] = 6;
                    rentprices[1] = 30;
                    rentprices[2] = 90;
                    rentprices[3] = 270;
                    rentprices[4] = 400;
                    rentprices[5] = 550;
                    buildcost = 50;
                    noinfullset = 3;
                    break;
                case "EUS":
                    name = "Euston Road";
                    price = 100;
                    rentprices[0] = 6;
                    rentprices[1] = 30;
                    rentprices[2] = 90;
                    rentprices[3] = 270;
                    rentprices[4] = 480;
                    rentprices[5] = 550;
                    buildcost = 50;
                    noinfullset = 3;
                    break;
                case "PEN":
                    name = "Pentonville Road";
                    price = 120;
                    rentprices[0] = 8;
                    rentprices[1] = 40;
                    rentprices[2] = 100;
                    rentprices[3] = 300;
                    rentprices[4] = 450;
                    rentprices[5] = 600;
                    buildcost = 50;
                    noinfullset = 3;
                    break;
                case "PAL":
                    name = "Pall Mall";
                    price = 140;
                    rentprices[0] = 10;
                    rentprices[1] = 50;
                    rentprices[2] = 150;
                    rentprices[3] = 450;
                    rentprices[4] = 625;
                    rentprices[5] = 750;
                    buildcost = 100;
                    noinfullset = 3;
                    break;
                case "WHH":
                    name = "Whitehall";
                    price = 140;
                    rentprices[0] = 10;
                    rentprices[1] = 50;
                    rentprices[2] = 150;
                    rentprices[3] = 450;
                    rentprices[4] = 625;
                    rentprices[5] = 750;
                    buildcost = 100;
                    noinfullset = 3;
                    break;
                case "NOR":
                    name = "Northumberland Avenue";
                    price = 160;
                    rentprices[0] = 12;
                    rentprices[1] = 60;
                    rentprices[2] = 180;
                    rentprices[3] = 500;
                    rentprices[4] = 700;
                    rentprices[5] = 900;
                    buildcost = 50;
                    noinfullset = 3;
                    break;
                case "BOW":
                    name = "Bow Street";
                    price = 180;
                    rentprices[0] = 14;
                    rentprices[1] = 70;
                    rentprices[2] = 200;
                    rentprices[3] = 550;
                    rentprices[4] = 750;
                    rentprices[5] = 950;
                    buildcost = 100;
                    noinfullset = 3;
                    break;
                case "MAR":
                    name = "Marlborough Street";
                    price = 180;
                    rentprices[0] = 14;
                    rentprices[1] = 70;
                    rentprices[2] = 200;
                    rentprices[3] = 550;
                    rentprices[4] = 750;
                    rentprices[5] = 950;
                    buildcost = 100;
                    noinfullset = 3;
                    break;
                case "VIN":
                    name = "Vine Street";
                    price = 200;
                    rentprices[0] = 16;
                    rentprices[1] = 80;
                    rentprices[2] = 220;
                    rentprices[3] = 600;
                    rentprices[4] = 800;
                    rentprices[5] = 1000;
                    buildcost = 100;
                    noinfullset = 3;
                    break;
                case "STR":
                    name = "Strand";
                    price = 220;
                    rentprices[0] = 18;
                    rentprices[1] = 90;
                    rentprices[2] = 250;
                    rentprices[3] = 700;
                    rentprices[4] = 875;
                    rentprices[5] = 1050;
                    buildcost = 150;
                    noinfullset = 3;
                    break;
                case "FLE":
                    name = "Fleet Street";
                    price = 220;
                    rentprices[0] = 18;
                    rentprices[1] = 90;
                    rentprices[2] = 250;
                    rentprices[3] = 700;
                    rentprices[4] = 875;
                    rentprices[5] = 1050;
                    buildcost = 150;
                    noinfullset = 3;
                    break;
                case "TRA":
                    name = "Trafalgar Square";
                    price = 240;
                    rentprices[0] = 20;
                    rentprices[1] = 100;
                    rentprices[2] = 300;
                    rentprices[3] = 750;
                    rentprices[4] = 925;
                    rentprices[5] = 1100;
                    buildcost = 150;
                    noinfullset = 3;
                    break;
                case "LEI":
                    name = "Leicester Square";
                    price = 260;
                    rentprices[0] = 22;
                    rentprices[1] = 110;
                    rentprices[2] = 330;
                    rentprices[3] = 800;
                    rentprices[4] = 975;
                    rentprices[5] = 1150;
                    buildcost = 150;
                    noinfullset = 3;
                    break;
                case "COV":
                    name = "Coventry Street";
                    price = 260;
                    rentprices[0] = 22;
                    rentprices[1] = 110;
                    rentprices[2] = 330;
                    rentprices[3] = 800;
                    rentprices[4] = 975;
                    rentprices[5] = 1150;
                    buildcost = 150;
                    noinfullset = 3;
                    break;
                case "PIC":
                    name = "Picadilly";
                    price = 280;
                    rentprices[0] = 24;
                    rentprices[1] = 120;
                    rentprices[2] = 360;
                    rentprices[3] = 850;
                    rentprices[4] = 1025;
                    rentprices[5] = 1200;
                    buildcost = 150;
                    noinfullset = 3;
                    break;
                case "REG":
                    name = "Regent Street";
                    price = 300;
                    rentprices[0] = 26;
                    rentprices[1] = 130;
                    rentprices[2] = 390;
                    rentprices[3] = 900;
                    rentprices[4] = 1100;
                    rentprices[5] = 1275;
                    buildcost = 200;
                    noinfullset = 3;
                    break;
                case "OXF":
                    name = "Oxford Street";
                    price = 300;
                    rentprices[0] = 26;
                    rentprices[1] = 130;
                    rentprices[2] = 390;
                    rentprices[3] = 900;
                    rentprices[4] = 1100;
                    rentprices[5] = 1275;
                    buildcost = 200;
                    noinfullset = 3;
                    break;
                case "BON":
                    name = "Bond Street";
                    price = 320;
                    rentprices[0] = 28;
                    rentprices[1] = 150;
                    rentprices[2] = 450;
                    rentprices[3] = 1000;
                    rentprices[4] = 1200;
                    rentprices[5] = 1400;
                    buildcost = 200;
                    noinfullset = 3;
                    break;
                case "PAR":
                    name = "Park Lane";
                    price = 350;
                    rentprices[0] = 35;
                    rentprices[1] = 175;
                    rentprices[2] = 500;
                    rentprices[3] = 1100;
                    rentprices[4] = 1300;
                    rentprices[5] = 1500;
                    buildcost = 200;
                    noinfullset = 2;
                    break;
                case "MAY":
                    name = "Mayfair";
                    price = 400;
                    rentprices[0] = 50;
                    rentprices[1] = 200;
                    rentprices[2] = 600;
                    rentprices[3] = 1400;
                    rentprices[4] = 1700;
                    rentprices[5] = 2000;
                    buildcost = 200;
                    noinfullset = 2;
                    break;
                default:

                    break;
            }
            nohouses = 0;
            owner = -1;
            mortgaged = false;
        }

        public Property(string iname, int iprice, int [] irentprices, int ibuildcost) { 
            
            rentprices = new int [6];
            name = iname;
            price = iprice;
            if (irentprices.Length == 6) { 
                for (int i = 0; i < 6; i++)
                {
                    rentprices[i] = irentprices[i];
                }
            }
            owner = -1;
            mortgaged = false;
            buildcost = ibuildcost;
        }

        public string getName() { 
            return name;
        }

        public int getPrice() { 
            return price;
        }

        public int getOwner() { 
            return owner;
        }

        public bool getMortgaged() { 
            return mortgaged;
        }

        public virtual int getRent(int diceval, int noownedinset) { 
            if (mortgaged) { 
                return 0;
            } else { 
                if (nohouses == 0) { 
                    if (noownedinset == noinfullset) { 
                        return 2 * rentprices[0];
                    } else { 
                        return rentprices[0];
                    }
                } else { 
                    return rentprices[nohouses - 1];
                }
            }
        }
    }

    public class StationProperty : Property {

        public StationProperty(string itag) {
            rentprices = new int[4];
            tag = itag;
            switch (tag) { 
                case "KIS":
                    name = "King's Cross Station";
                    price = 200;
                    rentprices[0] = 25;
                    rentprices[1] = 50;
                    rentprices[2] = 100;
                    rentprices[3] = 200;
                    break;
                case "MAS":
                    name = "Marleybone Station";
                    price = 200;
                    rentprices[0] = 25;
                    rentprices[1] = 50;
                    rentprices[2] = 100;
                    rentprices[3] = 200;
                    break;
                case "FES":
                    name = "Fenchurch Street Station";
                    price = 200;
                    rentprices[0] = 25;
                    rentprices[1] = 50;
                    rentprices[2] = 100;
                    rentprices[3] = 200;
                    break;
                case "LIS":
                    name = "Liverpool Street Station";
                    price = 200;
                    rentprices[0] = 25;
                    rentprices[1] = 50;
                    rentprices[2] = 100;
                    rentprices[3] = 200;
                    break;
                default:

                    break;
            }
            owner = -1;
            mortgaged = false;
        }

        public StationProperty(string iname, int iprice, int[] irentprices)
        {
            rentprices = new int [4];
            name = iname;
            price = iprice;
            if (irentprices.Length == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    rentprices[i] = irentprices[i];
                }
            }
            owner = -1;
            mortgaged = false;
        }

        public override int getRent(int diceval, int noownedinset) { 
            if (mortgaged) { 
                return 0;
            } else { 
                return rentprices[noownedinset - 1];
            }
        }

    }

    public class UtilityProperty : Property { 
        
        public UtilityProperty(string tag) { 
            switch (tag) { 
                case "ELU":
                    name = "Electric Company";
                    price = 150;
                    break;
                case "WAU":
                    name = "Water Works";
                    price = 150;
                    break;
                default:

                    break;
            }
            owner = -1;
            mortgaged = false;
        }

        public UtilityProperty(string iname, int iprice) {
            name = iname;
            price = iprice;
            owner = -1;
            mortgaged = false;
        }
        
        public override int getRent(int diceval, int noownedinset) { 
            if (mortgaged) { 
                return 0;
            } else if (noownedinset == 2) {
                return 10 * diceval;
            } else { 
                return 4 * diceval;
            }
        }
        
    }

}
