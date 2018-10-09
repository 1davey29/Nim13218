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
            Pile_1.Children.Clear();
            Pile_2.Children.Clear();
            Pile_3.Children.Clear();
            Pile_4.Children.Clear();
            Pile_1.RowDefinitions.Clear();
            Pile_2.RowDefinitions.Clear();
            Pile_3.RowDefinitions.Clear();
            Pile_4.RowDefinitions.Clear();

            switch (game.difficulty)
            {
                case Difficulty.Easy:

                    for (int i = 0; i < 3; i++)
                    {
                        Pile_1.RowDefinitions.Add(new RowDefinition());
                        Pile_4.RowDefinitions.Add(new RowDefinition());
                    }

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
                        Grid.SetRow(pileObject, i);
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        string name = "_p4o" + i;

                        Rectangle pileObject = new Rectangle()
                        {
                            Name = name,
                            Height = 20,
                            Width = 20,
                            Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0)),
                            Margin = new Thickness(5)
                        };

                        Pile_4.Children.Add(pileObject);
                        Grid.SetRow(pileObject, i);
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

            window.game = new GameLogic();

            window.game.difficulty = this.game.difficulty;
            window.game.opponentType = this.game.opponentType;
            window.game.PlayerOneName = this.game.PlayerOneName;
            window.game.PlayerTwoName = this.game.PlayerTwoName;

            window.difficultyDisplay1.Content = ((this.game.difficulty == Difficulty.Easy)
                ? Difficulty.Easy : (this.game.difficulty == Difficulty.Medium)
                ? Difficulty.Medium : Difficulty.Hard);

            window.Show();
            this.Close();
        }
    }
}
