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

        DiceDisplay dicedisplay;
        Playerdisplay playerdisplay;

        public MainWindow()
        {
            dicedisplay = new DiceDisplay();
            playerdisplay = new Playerdisplay(5);
            InitializeComponent();
            updateDice();
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
            string ttilename;

            List <int> tplayersatthistile;

            
            

            for (int i = 0; i < 41; i++)
            {
                tplayersatthistile = playerdisplay.getPlayersAtPosition(i);

                ttilename = "Tile" + i.ToString();

                for (int j = 0; j < ((Grid)FindName(ttilename)).Children.Count; j++) { 
                    if (((Grid)FindName(ttilename)).Children[j].Uid == ttilename + "G") {
                        ((Grid)FindName(ttilename)).Children.RemoveAt(j);
                    }
                }
                
               // if (FindName(ttilename + "G"). != null) { 
                //        System.Diagnostics.Debug.WriteLine(FindName(ttilename + "G"));
                 //   ((Grid)FindName(ttilename)).Children.Remove((Grid)FindName(ttilename + "G"));
                    

                //}


                Grid tsubgrid = new Grid();
                tsubgrid.Uid = ttilename + "G";
                if (tplayersatthistile.Count() > 0) { 
                    switch (tplayersatthistile.Count()) { 
                        case 0:
                            break;
                        case 1:
                            RowDefinition trow = new RowDefinition();
                            trow.Height = new GridLength(1, GridUnitType.Star);
                            tsubgrid.RowDefinitions.Add(trow);
                            ColumnDefinition tcol = new ColumnDefinition();
                            tcol.Width = new GridLength(1, GridUnitType.Star);
                            tsubgrid.ColumnDefinitions.Add(tcol);
                            break;
                        case 2:
                            ColumnDefinition ttcol = new ColumnDefinition();
                            ttcol.Width = new GridLength(1, GridUnitType.Star);
                            tsubgrid.ColumnDefinitions.Add(ttcol);
                            goto case 1;
                        case 3:
                        case 4:
                            RowDefinition ttrow = new RowDefinition();
                            ttrow.Height = new GridLength(1, GridUnitType.Star);
                            tsubgrid.RowDefinitions.Add(ttrow);
                            goto case 2;
                        case 5:
                        case 6:
                            ColumnDefinition tttcol = new ColumnDefinition();
                            tttcol.Width = new GridLength(1, GridUnitType.Star);
                            tsubgrid.ColumnDefinitions.Add(tttcol);
                            goto case 4;
                        case 7:
                        case 8:
                        case 9:
                            RowDefinition tttrow = new RowDefinition();
                            tttrow.Height = new GridLength(1, GridUnitType.Star);
                            tsubgrid.RowDefinitions.Add(tttrow);
                            goto case 6;
                        default:
                            return;
                    }
                    int columns = tsubgrid.ColumnDefinitions.Count();
                    for (int j = 0; j < tplayersatthistile.Count(); j++) { 
                        Ellipse playertoken = new Ellipse();
                        playertoken.Fill = System.Windows.Media.Brushes.Black;
                        playertoken.Stretch = System.Windows.Media.Stretch.Uniform;
                        //playertoken.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                        //playertoken.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                        Grid.SetColumn(playertoken, j % columns);
                        Grid.SetRow(playertoken, j / columns);
                        tsubgrid.Children.Add(playertoken);
                    }
                }
                System.Diagnostics.Debug.WriteLine(((Grid)FindName(ttilename)).Children.Count);
                ((Grid)FindName(ttilename)).Children.Add(tsubgrid);
                System.Diagnostics.Debug.WriteLine(((Grid)FindName(ttilename)).Children.Count);
            }
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
    
        List <int> playerpositions;

        List <int> [] playersatposition;

        public Playerdisplay(int noplayers) { 
            playerpositions = new List <int> ();
            playersatposition = new List <int> [41];
            for (int i = 0; i < 41; i++) {
                playersatposition[i] = new List<int>();
            }
            for (int i = 0; i < noplayers; i++) {
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


        public void refresh() { 
            string ttilename;
            for (int i = 0; i < 41; i++) { 
                ttilename = "Tile" + i.ToString();
                
            }
        }
    }


}
