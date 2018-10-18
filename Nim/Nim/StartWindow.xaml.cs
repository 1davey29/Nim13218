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

namespace Nim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void startButton_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow window = new SettingsWindow();
            window.Show();
            this.Close();
        }

        public void instructionsButton_Click(object sender, RoutedEventArgs e)
        {
            InstructionsWindow window = new InstructionsWindow();
            window.Show();
            this.Close();
        }

        public void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void startButton_MouseEnter(object sender, MouseEventArgs e)
        {
            startButton.Background = Brushes.Yellow;
        }

        public void startButton_MouseLeave(object sender, MouseEventArgs e)
        {
            startButton.Background = Brushes.Cyan;
        }
    }
}
