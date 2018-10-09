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
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        GameLogic game = new GameLogic();

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if (AI.IsChecked == true)
            {
                game.opponentType = Opponent.AI;
            }
            else
            {
                game.opponentType = Opponent.Human;
            }

            if (Easy.IsChecked == true)
            {
                game.difficulty = Difficulty.Easy;
            }
            else if (Medium.IsChecked == true)
            {
                game.difficulty = Difficulty.Medium;
            }
            else
            {
                game.difficulty = Difficulty.Hard;
            }

            GameWindow window = new GameWindow();

            window.game = game;

            window.difficultyDisplay1.Content = ((bool)(Easy.IsChecked) ? "Easy" : ((bool)(Medium.IsChecked) ? "Medium" : "Hard"));

            window.Setup();

            window.Show();
            this.Close();
        }
    }
}
