using Nim.Logic;
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

namespace Nim
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameLogic game { get; set; }

        public GameWindow()
        {
            InitializeComponent();


        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void restartButton_Click(object sender, RoutedEventArgs e)
        {
            GameWindow window = new GameWindow();

            window.game.difficulty = this.game.difficulty;
            window.game.opponentType = this.game.opponentType;
            window.game.PlayerOneName = this.game.PlayerOneName;
            window.game.PlayerTwoName = this.game.PlayerTwoName;

            window.Show();
            this.Close();
        }
    }
}
