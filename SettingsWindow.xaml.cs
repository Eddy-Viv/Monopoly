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
using System.Windows.Shapes;

namespace Monopoly
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        List <SettingsPlayer> players;
        
        public SettingsWindow()
        {
            players = new List<SettingsPlayer>();
            InitializeComponent();
        }

        private void addPlayer(object sender, RoutedEventArgs e)
        {
            playergrid.RowDefinitions.Add(new RowDefinition());
            int insertionrow = 0;
            for (int i = 0; i < playergrid.Children.Count; i++) { 
                if (((FrameworkElement)playergrid.Children[i]).Name == "addbutton") { 
                    insertionrow = Grid.GetRow(playergrid.Children[i]);
                    Grid.SetRow(playergrid.Children[i], insertionrow + 1);
                }
            }

            Ellipse tplayercolour = new Ellipse();
            Grid.SetRow(tplayercolour, insertionrow);
            tplayercolour.Stretch = System.Windows.Media.Stretch.Uniform;
            tplayercolour.Height = 25;
            tplayercolour.Width = 25;
            tplayercolour.Fill = System.Windows.Media.Brushes.AliceBlue;
            playergrid.Children.Add(tplayercolour);

            TextBox tplayername = new TextBox();
            Grid.SetRow(tplayername, insertionrow);
            Grid.SetColumn(tplayername, 1);
            tplayername.Text = "AI " + insertionrow.ToString();
            playergrid.Children.Add(tplayername);

            ComboBox tplayerstatus = new ComboBox();
            Grid.SetRow(tplayerstatus, insertionrow);
            Grid.SetColumn(tplayerstatus, 2);
            ComboBoxItem tcomboitem = new ComboBoxItem();
            tcomboitem.Content = "Player";
            ComboBoxItem tcomboitem2 = new ComboBoxItem();
            tcomboitem2.Content = "AI";
            tcomboitem2.IsSelected = true;
            tplayerstatus.Items.Add(tcomboitem);
            tplayerstatus.Items.Add(tcomboitem2);
            playergrid.Children.Add(tplayerstatus);

            Button tplayerdelete = new Button();
            Grid.SetRow(tplayerdelete, insertionrow);
            Grid.SetColumn(tplayerdelete, 3);
            tplayerdelete.Content = "Delete";
            tplayerdelete.Click += new RoutedEventHandler(deletePlayer);
            playergrid.Children.Add(tplayerdelete);

            if(playergrid.Children.Count > 32) { 
                addbutton.IsEnabled = false;
            }
        }

        private void deletePlayer(object sender, RoutedEventArgs e)
        {
            int deletionrow = Grid.GetRow((UIElement)sender);
            for (int i = 0; i < playergrid.Children.Count; i++) {
                if (Grid.GetRow(playergrid.Children[i]) == deletionrow) { 
                    playergrid.Children.RemoveAt(i);
                    i--;
                } else if (Grid.GetRow(playergrid.Children[i]) > deletionrow) { 
                    int thisrow = Grid.GetRow(playergrid.Children[i]);
                    Grid.SetRow(playergrid.Children[i], thisrow - 1);
                }
            }
            playergrid.RowDefinitions.RemoveAt(0);
            addbutton.IsEnabled = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }
    }

    public struct SettingsPlayer { 
        public string name;
        public bool ishuman;
    }
}
