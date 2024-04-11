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

namespace Monopoly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        readonly Random rnd;

        DiceDisplay dicedisplay;
        Playerdisplay playerdisplay;

        SettingsWindow settingswindow;

        public MainWindow()
        {
            //System.Diagnostics.Debug.WriteLine("hello i am in the debug console");

            InitializeComponent();
            rnd = new Random();
            settingswindow = new SettingsWindow();
            settingswindow.Closing += Settingswindow_Closing;
            settingswindow.Show();

            dicedisplay = new DiceDisplay();
            playerdisplay = new Playerdisplay();
            updateDice();


        }

        private void Settingswindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            List <SettingsPlayer> tlist = settingswindow.getPlayers();

            playerdisplay = new Playerdisplay(tlist.Count);

            for (int i = 0; i < tlist.Count; i++) { 
                playerdisplay.setPlayer(i, tlist[i].name, tlist[i].ishuman);
            }
            
            this.Show();
            refreshTile(0);
        }

        void Dice_Click(object sender, MouseButtonEventArgs e)
        {
            ((App)Application.Current).rollDice();
            dicedisplay.setDice(1, ((App)Application.Current).getDice(1));
            dicedisplay.setDice(2, ((App)Application.Current).getDice(2));
            updateDice();
            refreshPlayerDisplay();
        }

        void updateDice() { 
            for (int i = 1; i <= 2; i++) {
                for (int j = 1; j <= 7; j++) { 
                    string dotname = "Dot_" + i.ToString() + "_" + j.ToString();
                    if (dicedisplay.dot(i, j)) { 
                        if (FindName(dotname) != null) { 
                            ((Ellipse)FindName(dotname)).Fill = System.Windows.Media.Brushes.Black;
                        }
                    } else {
                        if (FindName(dotname) != null)
                        {
                            ((Ellipse)FindName(dotname)).Fill = System.Windows.Media.Brushes.Transparent;
                        }
                    }
                }
            }
        }

        private void KEN_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.KEN());
        }

        private void WHR_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.WHR());
        }

        private void ANG_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.ANG());
        }

        private void EUS_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.EUS());
        }

        private void PEN_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.PEN());
        }

        private void PAL_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.PAL());
        }

        private void WHH_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.WHH());
        }

        private void NOR_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.NOR());
        }

        private void BOW_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.BOW());
        }

        private void MAR_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.MAR());
        }

        private void VIN_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.VIN());
        }

        private void STR_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.STR());
        }

        private void FLE_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.FLE());
        }

        private void TRA_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.TRA());
        }

        private void LEI_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.LEI());
        }

        private void COV_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.COV());
        }

        private void PIC_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.PIC());
        }

        private void REG_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.REG());
        }

        private void OXF_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.OXF());
        }

        private void BON_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.BON());
        }

        private void PAR_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.PAR());
        }

        private void MAY_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.MAY());
        }

        private void KIS_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.KIS());
        }

        private void MAS_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.MAS());
        }

        private void FES_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.FES());
        }

        private void LIS_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.LIS());
        }

        private void WAU_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.WAU());
        }

        private void ELU_Mouseover(object sender, MouseEventArgs e)
        {
            PropertyCardView.Children.Clear();
            PropertyCardView.Children.Add(new UserControls.ELU());
        }

        public void refreshPlayerDisplay() {
      
            for (int i = 0; i < 41; i++)
            {
                refreshTile(i);
            }
        }

        void refreshTile(int tileno) {
            if (tileno >= 0 && tileno < 41)
            {

                string ttilename;

                List<int> tplayersatthistile;

                tplayersatthistile = playerdisplay.getPlayersAtPosition(tileno);

                ttilename = "Tile" + tileno.ToString();
                Grid ttile = (Grid)FindName(ttilename);

                for (int i = 0; i < ((Grid)FindName(ttilename)).Children.Count; i++)
                {
                    if (ttile.Children[i].Uid == ttilename + "G")
                    {
                        ttile.Children.RemoveAt(i);
                    }
                }

                Grid tsubgrid = new Grid();
                tsubgrid.Uid = ttilename + "G";
                if (tplayersatthistile.Count() > 0)
                {
                    int rows = (int)Math.Ceiling(Math.Sqrt((double)tplayersatthistile.Count()));
                    int cols = (int)Math.Ceiling((double)tplayersatthistile.Count() / rows);

                    for (int i = 0; i < rows; i++) { 
                        RowDefinition trow = new RowDefinition();
                        trow.Height = new GridLength(1, GridUnitType.Star);
                        tsubgrid.RowDefinitions.Add(trow);
                    }

                    for (int i = 0; i < cols; i++)
                    {
                        ColumnDefinition tcol = new ColumnDefinition();
                        tcol.Width = new GridLength(1, GridUnitType.Star);
                        tsubgrid.ColumnDefinitions.Add(tcol);
                    }

                    int columns = tsubgrid.ColumnDefinitions.Count();
                    for (int j = 0; j < tplayersatthistile.Count(); j++)
                    {
                        Ellipse playertoken = new Ellipse();
                        playertoken.Fill = playerdisplay.getPlayerColour(tplayersatthistile[j]);
                        playertoken.Stretch = System.Windows.Media.Stretch.Uniform;
                        playertoken.MinWidth = 30;
                        playertoken.MinHeight = 30;
                        playertoken.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                        playertoken.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                        Grid.SetColumn(playertoken, j % columns);
                        Grid.SetRow(playertoken, j / columns);
                        tsubgrid.Children.Add(playertoken);
                    }
                }
                ttile.Children.Add(tsubgrid);
            }
        }

        public void movePlayer(int playerno, int dest) { 
            int currentplayerpos = playerdisplay.getPlayerPosition(playerno);
            playerdisplay.movePlayer(playerno, dest);
            refreshTile(currentplayerpos);
            refreshTile(dest);
        }
    }

    public class DiceDisplay { 
        int dice1;
        int dice2;

        public DiceDisplay() { 
            dice1 = 1;
            dice2 = 1;
        }

        public void setDice(int diceno, int value) { 
            if (value > 0 && value <= 6) { 
                switch (diceno) { 
                    case 1:
                        dice1 = value;
                        break;
                    case 2:
                        dice2 = value;
                        break;
                    default:
                        return;
                }
            }
        }

        public bool dot(int diceno, int dotref) { 
            int thisdice;
            if (diceno == 1) { 
                thisdice = dice1;
            } else if (diceno == 2) { 
                thisdice = dice2;
            } else { 
                return false;
            }

            switch (thisdice) { 
                case 1:
                    switch (dotref) { 
                        case 4:
                            return true;
                        default:
                            return false;
                    }
                case 2:
                    switch (dotref)
                    {
                        case 1:
                        case 7:
                            return true;
                        default:
                            return false;
                    }
                case 3:
                    switch (dotref)
                    {
                        case 1:
                        case 4:
                        case 7:
                            return true;
                        default:
                            return false;
                    }
                case 4:
                    switch (dotref)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                            return true;
                        default:
                            return false;
                    }
                case 5:
                    switch (dotref)
                    {
                        case 1:
                        case 3:
                        case 4:
                        case 5:
                        case 7:
                            return true;
                        default:
                            return false;
                    }
                case 6:
                    switch (dotref)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 5:
                        case 6:
                        case 7:
                            return true;
                        default:
                            return false;
                    }
                default:
                    return false;
            }
        }
        
    }

    public class Playerdisplay { 
    
        int totalplayers;

        List<string> playernames;

        List<bool> playerishuman;

        List <System.Windows.Media.SolidColorBrush> playercolours;

        List <int> playerpositions;

        List <int> [] playersatposition;

        readonly Random rnd;

        public Playerdisplay() { 
            totalplayers = 0;
        }
        
        public Playerdisplay(int noplayers) {
            rnd = new Random();

            totalplayers = noplayers;

            playernames = new List<string>();
            playerishuman = new List<bool>();

            playercolours = new List<System.Windows.Media.SolidColorBrush>() { 
                System.Windows.Media.Brushes.Blue,
                System.Windows.Media.Brushes.Red,
                System.Windows.Media.Brushes.Green,
                System.Windows.Media.Brushes.Yellow,
                System.Windows.Media.Brushes.Teal,
                System.Windows.Media.Brushes.Purple,
                System.Windows.Media.Brushes.Gray,
                System.Windows.Media.Brushes.Orange
            };
            for (int i = 8; i < noplayers; i++) {
                
                byte R = (byte)rnd.Next();
                byte G = (byte)rnd.Next();
                byte B = (byte)rnd.Next();
                playercolours.Add(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(R,G,B)));
            }



            playerpositions = new List <int> ();
            playersatposition = new List <int> [41];
            for (int i = 0; i < 41; i++) {
                playersatposition[i] = new List<int>();
            }
            for (int i = 0; i < noplayers; i++) {
                playernames.Add("");
                playerishuman.Add(false);
                playerpositions.Add(0);
                playersatposition[0].Add(i);
            }
        }

        public int getPlayerPosition(int no) { 
            if (no >= 0 && no < playerpositions.Count()) { 
                return playerpositions[no];
            } else { 
                return -1;
            }

        }

        public List <int> getPlayersAtPosition(int pos) { 
            if (pos >= 0 && pos < 41) {
                return playersatposition[pos];
            } else { 
                return new List <int> ();
            }
        }

        public System.Windows.Media.SolidColorBrush getPlayerColour(int playerno) {
            if (playerno >= 0 && playerno < totalplayers) { 
                return playercolours[playerno];
            } else { 
                return System.Windows.Media.Brushes.Black;
            }
        }

        public void movePlayer(int playerno, int dest) {
            if (playerno >= 0 && playerno < totalplayers && dest >= 0 && dest < 41) {
                playersatposition[playerpositions[playerno]].Remove(playerno);
                playerpositions[playerno] = dest;
                playersatposition[dest].Add(playerno);
            }
        }

        public void setPlayer(int playerno, string name, bool ishuman) {
            if (playerno >= 0 && playerno < totalplayers)
            {
                playernames[playerno] = name;
                playerishuman[playerno] = ishuman;

            }
        }

    }


}
