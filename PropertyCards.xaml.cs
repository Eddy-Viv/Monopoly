using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControls
{
    public partial class KEN : PropertyCard
    {
        public KEN()
        {
            InitializeComponent();

            Propertytitle.Text = "OLD KENT ROAD";
            Setcolour.Background = System.Windows.Media.Brushes.Brown;
            Rent.Text = "RENT $2.";
            Rent1house.Text = "$10.";
            Rent2house.Text = "$30.";
            Rent3house.Text = "$90.";
            Rent4house.Text = "$160.";
            Renthotel.Text = "With Hotel $250.";
            Mortgage.Text = "Mortgage Value $30.";
            Buildcost.Text = "Buildings Cost $50.";
        }
    }

    public partial class WHR : PropertyCard
    {
        public WHR()
        {
            InitializeComponent();

            Propertytitle.Text = "WHITECHAPEL ROAD";
            Propertytitle.FontSize = 230;
            Setcolour.Background = System.Windows.Media.Brushes.Brown;
            Rent.Text = "RENT $4.";
            Rent1house.Text = "$20.";
            Rent2house.Text = "$60.";
            Rent3house.Text = "$180.";
            Rent4house.Text = "$320.";
            Renthotel.Text = "With Hotel $450.";
            Mortgage.Text = "Mortgage Value $30.";
            Buildcost.Text = "Buildings Cost $50.";
        }
    }

    public partial class ANG : PropertyCard
    {
        public ANG()
        {
            InitializeComponent();

            Propertytitle.Text = "THE ANGEL, ISLINGTON";
            Propertytitle.FontSize = 210;
            Setcolour.Background = System.Windows.Media.Brushes.LightBlue;
            Rent.Text = "RENT $6.";
            Rent1house.Text = "$30.";
            Rent2house.Text = "$90.";
            Rent3house.Text = "$270.";
            Rent4house.Text = "$400.";
            Renthotel.Text = "With Hotel $550.";
            Mortgage.Text = "Mortgage Value $50.";
            Buildcost.Text = "Buildings Cost $50.";
        }
    }

    public partial class EUS : PropertyCard
    {
        public EUS()
        {
            InitializeComponent();

            Propertytitle.Text = "EUSTON ROAD";
            Setcolour.Background = System.Windows.Media.Brushes.LightBlue;
            Rent.Text = "RENT $6.";
            Rent1house.Text = "$30.";
            Rent2house.Text = "$90.";
            Rent3house.Text = "$270.";
            Rent4house.Text = "$400.";
            Renthotel.Text = "With Hotel $550.";
            Mortgage.Text = "Mortgage Value $50.";
            Buildcost.Text = "Buildings Cost $50.";
        }
    }

    public partial class PEN : PropertyCard
    {
        public PEN()
        {
            InitializeComponent();

            Propertytitle.Text = "PENTONVILLE ROAD";
            Setcolour.Background = System.Windows.Media.Brushes.LightBlue;
            Rent.Text = "RENT $8.";
            Rent1house.Text = "$40.";
            Rent2house.Text = "$100.";
            Rent3house.Text = "$300.";
            Rent4house.Text = "$450.";
            Renthotel.Text = "With Hotel $600.";
            Mortgage.Text = "Mortgage Value $60.";
            Buildcost.Text = "Buildings Cost $50.";
        }
    }

    public partial class PAL : PropertyCard
    {
        public PAL()
        {
            InitializeComponent();

            Propertytitle.Text = "PALL MALL";
            Setcolour.Background = System.Windows.Media.Brushes.HotPink;
            Rent.Text = "RENT $10.";
            Rent1house.Text = "$50.";
            Rent2house.Text = "$150.";
            Rent3house.Text = "$450.";
            Rent4house.Text = "$625.";
            Renthotel.Text = "With Hotel $750.";
            Mortgage.Text = "Mortgage Value $70.";
            Buildcost.Text = "Buildings Cost $100.";
        }
    }

    public partial class WHH : PropertyCard
    {
        public WHH()
        {
            InitializeComponent();

            Propertytitle.Text = "WHITEHALL";
            Setcolour.Background = System.Windows.Media.Brushes.HotPink;
            Rent.Text = "RENT $10.";
            Rent1house.Text = "$50.";
            Rent2house.Text = "$150.";
            Rent3house.Text = "$450.";
            Rent4house.Text = "$625.";
            Renthotel.Text = "With Hotel $750.";
            Mortgage.Text = "Mortgage Value $70.";
            Buildcost.Text = "Buildings Cost $100.";
        }
    }

    public partial class NOR : PropertyCard
    {
        public NOR()
        {
            InitializeComponent();

            Propertytitle.Text = "NORTHUMBERLAND AVENUE";
            Propertytitle.FontSize = 170;
            Setcolour.Background = System.Windows.Media.Brushes.HotPink;
            Rent.Text = "RENT $12.";
            Rent1house.Text = "$60.";
            Rent2house.Text = "$180.";
            Rent3house.Text = "$500.";
            Rent4house.Text = "$700.";
            Renthotel.Text = "With Hotel $900.";
            Mortgage.Text = "Mortgage Value $80.";
            Buildcost.Text = "Buildings Cost $100.";
        }
    }

    public partial class BOW : PropertyCard
    {
        public BOW()
        {
            InitializeComponent();

            Propertytitle.Text = "BOW STREET";
            Setcolour.Background = System.Windows.Media.Brushes.Orange;
            Rent.Text = "RENT $14.";
            Rent1house.Text = "$70.";
            Rent2house.Text = "$200.";
            Rent3house.Text = "$550.";
            Rent4house.Text = "$750.";
            Renthotel.Text = "With Hotel $950.";
            Mortgage.Text = "Mortgage Value $90.";
            Buildcost.Text = "Buildings Cost $100.";
        }
    }

    public partial class MAR : PropertyCard
    {
        public MAR()
        {
            InitializeComponent();

            Propertytitle.Text = "MARLBOROUGH STREET";
            Propertytitle.FontSize = 200;
            Setcolour.Background = System.Windows.Media.Brushes.Orange;
            Rent.Text = "RENT $14.";
            Rent1house.Text = "$70.";
            Rent2house.Text = "$200.";
            Rent3house.Text = "$550.";
            Rent4house.Text = "$750.";
            Renthotel.Text = "With Hotel $950.";
            Mortgage.Text = "Mortgage Value $90.";
            Buildcost.Text = "Buildings Cost $100.";
        }
    }

    public partial class VIN : PropertyCard
    {
        public VIN()
        {
            InitializeComponent();

            Propertytitle.Text = "VINE STREET";
            Setcolour.Background = System.Windows.Media.Brushes.Orange;
            Rent.Text = "RENT $16.";
            Rent1house.Text = "$80.";
            Rent2house.Text = "$220.";
            Rent3house.Text = "$600.";
            Rent4house.Text = "$800.";
            Renthotel.Text = "With Hotel $1000.";
            Mortgage.Text = "Mortgage Value $100.";
            Buildcost.Text = "Buildings Cost $100.";
        }
    }

    public partial class STR : PropertyCard
    {
        public STR()
        {
            InitializeComponent();

            Propertytitle.Text = "STRAND";
            Setcolour.Background = System.Windows.Media.Brushes.Red;
            Rent.Text = "RENT $18.";
            Rent1house.Text = "$90.";
            Rent2house.Text = "$250.";
            Rent3house.Text = "$700.";
            Rent4house.Text = "$875.";
            Renthotel.Text = "With Hotel $1050.";
            Mortgage.Text = "Mortgage Value $110.";
            Buildcost.Text = "Buildings Cost $150.";
        }
    }

    public partial class FLE : PropertyCard
    {
        public FLE()
        {
            InitializeComponent();

            Propertytitle.Text = "FLEET STREET";
            Setcolour.Background = System.Windows.Media.Brushes.Red;
            Rent.Text = "RENT $18.";
            Rent1house.Text = "$90.";
            Rent2house.Text = "$250.";
            Rent3house.Text = "$700.";
            Rent4house.Text = "$875.";
            Renthotel.Text = "With Hotel $1050.";
            Mortgage.Text = "Mortgage Value $110.";
            Buildcost.Text = "Buildings Cost $150.";
        }
    }

    public partial class TRA : PropertyCard
    {
        public TRA()
        {
            InitializeComponent();

            Propertytitle.Text = "TRAFALGAR SQUARE";
            Propertytitle.FontSize = 240;
            Setcolour.Background = System.Windows.Media.Brushes.Red;
            Rent.Text = "RENT $20.";
            Rent1house.Text = "$100.";
            Rent2house.Text = "$300.";
            Rent3house.Text = "$750.";
            Rent4house.Text = "$925.";
            Renthotel.Text = "With Hotel $1100.";
            Mortgage.Text = "Mortgage Value $120.";
            Buildcost.Text = "Buildings Cost $150.";
        }
    }

    public partial class LEI : PropertyCard
    {
        public LEI()
        {
            InitializeComponent();

            Propertytitle.Text = "LEICESTER SQUARE";
            Propertytitle.Foreground = System.Windows.Media.Brushes.Black;
            Setcolour.Background = System.Windows.Media.Brushes.Yellow;
            Rent.Text = "RENT $22.";
            Rent1house.Text = "$110.";
            Rent2house.Text = "$330.";
            Rent3house.Text = "$800.";
            Rent4house.Text = "$975.";
            Renthotel.Text = "With Hotel $1150.";
            Mortgage.Text = "Mortgage Value $130.";
            Buildcost.Text = "Buildings Cost $150.";
        }
    }

    public partial class COV : PropertyCard
    {
        public COV()
        {
            InitializeComponent();

            Propertytitle.Text = "COVENTRY STREET";
            Propertytitle.Foreground = System.Windows.Media.Brushes.Black;
            Setcolour.Background = System.Windows.Media.Brushes.Yellow;
            Rent.Text = "RENT $22.";
            Rent1house.Text = "$110.";
            Rent2house.Text = "$330.";
            Rent3house.Text = "$800.";
            Rent4house.Text = "$975.";
            Renthotel.Text = "With Hotel $1150.";
            Mortgage.Text = "Mortgage Value $130.";
            Buildcost.Text = "Buildings Cost $150.";
        }
    }

    public partial class PIC : PropertyCard
    {
        public PIC()
        {
            InitializeComponent();

            Propertytitle.Text = "PICADILLY";
            Propertytitle.Foreground = System.Windows.Media.Brushes.Black;
            Setcolour.Background = System.Windows.Media.Brushes.Yellow;
            Rent.Text = "RENT $24.";
            Rent1house.Text = "$120.";
            Rent2house.Text = "$360.";
            Rent3house.Text = "$850.";
            Rent4house.Text = "$1025.";
            Renthotel.Text = "With Hotel $1200.";
            Mortgage.Text = "Mortgage Value $140.";
            Buildcost.Text = "Buildings Cost $150.";
        }
    }

    public partial class REG : PropertyCard
    {
        public REG()
        {
            InitializeComponent();

            Propertytitle.Text = "REGENT STREET";
            Setcolour.Background = System.Windows.Media.Brushes.Green;
            Rent.Text = "RENT $26.";
            Rent1house.Text = "$130.";
            Rent2house.Text = "$390.";
            Rent3house.Text = "$900.";
            Rent4house.Text = "$1100.";
            Renthotel.Text = "With Hotel $1275.";
            Mortgage.Text = "Mortgage Value $150.";
            Buildcost.Text = "Buildings Cost $200.";
        }
    }

    public partial class OXF : PropertyCard
    {
        public OXF()
        {
            InitializeComponent();

            Propertytitle.Text = "OXFORD STREET";
            Setcolour.Background = System.Windows.Media.Brushes.Green;
            Rent.Text = "RENT $26.";
            Rent1house.Text = "$130.";
            Rent2house.Text = "$390.";
            Rent3house.Text = "$900.";
            Rent4house.Text = "$1100.";
            Renthotel.Text = "With Hotel $1275.";
            Mortgage.Text = "Mortgage Value $150.";
            Buildcost.Text = "Buildings Cost $200.";
        }
    }

    public partial class BON : PropertyCard
    {
        public BON()
        {
            InitializeComponent();

            Propertytitle.Text = "BOND STREET";
            Setcolour.Background = System.Windows.Media.Brushes.Green;
            Rent.Text = "RENT $28.";
            Rent1house.Text = "$150.";
            Rent2house.Text = "$450.";
            Rent3house.Text = "$1000.";
            Rent4house.Text = "$1200.";
            Renthotel.Text = "With Hotel $1400.";
            Mortgage.Text = "Mortgage Value $160.";
            Buildcost.Text = "Buildings Cost $200.";
        }
    }

    public partial class PAR : PropertyCard
    {
        public PAR()
        {
            InitializeComponent();

            Propertytitle.Text = "PARK LANE";
            Setcolour.Background = System.Windows.Media.Brushes.DarkBlue;
            Rent.Text = "RENT $35.";
            Rent1house.Text = "$175.";
            Rent2house.Text = "$500.";
            Rent3house.Text = "$1100.";
            Rent4house.Text = "$1300.";
            Renthotel.Text = "With Hotel $1500.";
            Mortgage.Text = "Mortgage Value $175.";
            Buildcost.Text = "Buildings Cost $200.";
        }
    }

    public partial class MAY : PropertyCard
    {
        public MAY()
        {
            InitializeComponent();

            Propertytitle.Text = "MAYFAIR";
            Setcolour.Background = System.Windows.Media.Brushes.DarkBlue;
            Rent.Text = "RENT $50.";
            Rent1house.Text = "$200.";
            Rent2house.Text = "$600.";
            Rent3house.Text = "$1400.";
            Rent4house.Text = "$1700.";
            Renthotel.Text = "With Hotel $2000.";
            Mortgage.Text = "Mortgage Value $200.";
            Buildcost.Text = "Buildings Cost $200.";
        }
    }



    public partial class PropertyCard : UserControl { 
        public PropertyCard() { 
            InitializeComponent();
        }
    }
}
