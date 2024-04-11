using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Monopoly
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        Game game;

        App() { 

            game = new Game(4);
        }


        private void ApplicationStartup(object sender, StartupEventArgs e) { 
            MainWindow wnd = new MainWindow();
        }

        public void rollDice() { 
            game.rollDice();
        }

        public int getDice(int diceno) { 
            return game.getDice(diceno);
        }

        public int getTurn() { 
            return game.getTurn();
        }
    }
}
