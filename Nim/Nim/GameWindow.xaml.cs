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
        private int pileNumberSelected = 0;

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

                        pileObject.MouseLeftButtonUp += pileObject_Click;

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

                        pileObject.MouseLeftButtonUp += pileObject_Click;

                        Pile_4.Children.Add(pileObject);
                        Grid.SetRow(pileObject, i);
                    }

                    break;

                case Difficulty.Medium:

                    for (int i = 0; i < 7; i++)
                    {
                        if (i < 2)
                        {
                            Pile_1.RowDefinitions.Add(new RowDefinition());
                        }
                        
                        if (i < 5)
                        {
                            Pile_2.RowDefinitions.Add(new RowDefinition());
                        }

                        Pile_4.RowDefinitions.Add(new RowDefinition());
                    }

                    for (int i = 0; i < 2; i++)
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

                        pileObject.MouseLeftButtonUp += pileObject_Click;

                        Pile_1.Children.Add(pileObject);
                        Grid.SetRow(pileObject, i);
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        string name = "_p2o" + i;

                        Rectangle pileObject = new Rectangle()
                        {
                            Name = name,
                            Height = 20,
                            Width = 20,
                            Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0)),
                            Margin = new Thickness(5)
                        };

                        pileObject.MouseLeftButtonUp += pileObject_Click;

                        Pile_2.Children.Add(pileObject);
                        Grid.SetRow(pileObject, i);
                    }

                    for (int i = 0; i < 7; i++)
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

                        pileObject.MouseLeftButtonUp += pileObject_Click;

                        Pile_4.Children.Add(pileObject);
                        Grid.SetRow(pileObject, i);
                    }

                    break;

                case Difficulty.Hard:

                    for (int i = 0; i < 9; i++)
                    {
                        if (i < 2)
                        {
                            Pile_1.RowDefinitions.Add(new RowDefinition());
                        }

                        if (i < 3)
                        {
                            Pile_2.RowDefinitions.Add(new RowDefinition());
                        }

                        if (i < 8)
                        {
                            Pile_3.RowDefinitions.Add(new RowDefinition());
                        }

                        Pile_4.RowDefinitions.Add(new RowDefinition());
                    }

                    for (int i = 0; i < 2; i++)
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

                        pileObject.MouseLeftButtonUp += pileObject_Click;

                        Pile_1.Children.Add(pileObject);
                        Grid.SetRow(pileObject, i);
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        string name = "_p2o" + i;

                        Rectangle pileObject = new Rectangle()
                        {
                            Name = name,
                            Height = 20,
                            Width = 20,
                            Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0)),
                            Margin = new Thickness(5)
                        };

                        pileObject.MouseLeftButtonUp += pileObject_Click;

                        Pile_2.Children.Add(pileObject);
                        Grid.SetRow(pileObject, i);
                    }

                    for (int i = 0; i < 8; i++)
                    {
                        string name = "_p3o" + i;

                        Rectangle pileObject = new Rectangle()
                        {
                            Name = name,
                            Height = 20,
                            Width = 20,
                            Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0)),
                            Margin = new Thickness(5)
                        };

                        pileObject.MouseLeftButtonUp += pileObject_Click;

                        Pile_3.Children.Add(pileObject);
                        Grid.SetRow(pileObject, i);
                    }

                    for (int i = 0; i < 9; i++)
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

                        pileObject.MouseLeftButtonUp += pileObject_Click;

                        Pile_4.Children.Add(pileObject);
                        Grid.SetRow(pileObject, i);
                    }

                    break;

                default:

                    throw new Exception("Code Error");
            }
        }

        private void pileObject_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = sender as Rectangle;

            string name = rectangle.Name;

            int pileNumber = name[2] - 48;

            if (pileNumberSelected == 0)
            {
                pileNumberSelected = pileNumber;
            }

            if (pileNumber == pileNumberSelected)
            {
                switch (pileNumber)
                {
                    case 1:

                        Pile_1.Children.Remove(rectangle);

                        break;

                    case 2:

                        Pile_2.Children.Remove(rectangle);

                        break;

                    case 3:

                        Pile_3.Children.Remove(rectangle);

                        break;

                    case 4:

                        Pile_4.Children.Remove(rectangle);

                        break;

                    default:

                        break;
                }
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
