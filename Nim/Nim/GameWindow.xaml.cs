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

        public void Setup()
        {
            switch (game.difficulty)
            {
                case Difficulty.Easy:

                    for (int i = 0; i < 3; i++)
                    {
                        string name = "_p1o" + i;

                        Rectangle pileObject = new Rectangle()
                        {
                            Name = name,
                            Height = 20,
                            Width = 20,
                            Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0)),
                            Margin = new Thickness(5)
                        };

                        Pile_1.Children.Add(pileObject);
                    }

                    break;

                case Difficulty.Medium:

                    break;

                case Difficulty.Hard:

                    break;

                default:

                    throw new Exception("Code Error");
            }
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



            window.Show();
            this.Close();
        }
    }
}
