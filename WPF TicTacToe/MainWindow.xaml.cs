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

namespace WPF_TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool PlayerTurn = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTopLeft_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgTopLeft.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnTopLeft.IsEnabled = false;
                PlayerTurn = false;
            }
            else
            {
                ImgTopLeft.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnTopLeft.IsEnabled = false;
                PlayerTurn = true;
            }
        }

        private void btnMidLeft_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgMidLeft.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnMidLeft.IsEnabled = false;
                PlayerTurn = false;
            }
            else
            {
                ImgMidLeft.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnMidLeft.IsEnabled = false;
                PlayerTurn = true;
            }
        }
        
        private void btnBotLeft_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgBotLeft.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnBotLeft.IsEnabled = false;
                PlayerTurn = false;
            }
            else
            {
                ImgBotLeft.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnBotLeft.IsEnabled = false;
                PlayerTurn = true;
            }
        }
    }
}
