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
        public int[] WinCheck = { 0, 0, 0, 0, 0, 0, 0, 0, 0};

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
                WinCheck[0] = 1;
            }
            else
            {
                ImgTopLeft.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnTopLeft.IsEnabled = false;
                PlayerTurn = true;
                WinCheck[0] = 2;
            }

            WinChecker();
        }

        private void btnMidLeft_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgMidLeft.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnMidLeft.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[1] = 1;
            }
            else
            {
                ImgMidLeft.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnMidLeft.IsEnabled = false;
                PlayerTurn = true;
                WinCheck[1] = 2;
            }

            WinChecker();
        }
        
        private void btnBotLeft_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgBotLeft.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnBotLeft.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[2] = 1;
            }
            else
            {
                ImgBotLeft.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnBotLeft.IsEnabled = false;
                PlayerTurn = true;
                WinCheck[2] = 2;
            }

            WinChecker();
        }

        private void btnMidTop_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgMidTop.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnMidTop.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[3] = 1;
            }
            else
            {
                ImgMidTop.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnMidTop.IsEnabled = false;
                PlayerTurn = true;
                WinCheck[3] = 2;

            }

            WinChecker();
        }

        private void btnMid_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgMid.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnMid.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[4] = 1;

            }
            else
            {
                ImgMid.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnMid.IsEnabled = false;
                PlayerTurn = true;
                WinCheck[4] = 2;
            }

            WinChecker();
        }

        private void btnMidBot_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgMidBot.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnMidBot.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[5] = 1;

            }
            else
            {
                ImgMidBot.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnMidBot.IsEnabled = false;
                PlayerTurn = true;
                WinCheck[5] = 2;
            }

            WinChecker();
        }

        private void btnRightTop_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgRightTop.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnRightTop.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[6] = 1;
            }
            else
            {
                ImgRightTop.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnRightTop.IsEnabled = false;
                PlayerTurn = true;
                WinCheck[6] = 2;
            }

            WinChecker();
        }

        private void btnRightMid_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgRightMid.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnRightMid.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[7] = 1;
            }
            else
            {
                ImgRightMid.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnRightMid.IsEnabled = false;
                PlayerTurn = true;
                WinCheck[7] = 2;
            }

            WinChecker();
        }

        private void btnRightBot_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgRightBot.Source = new BitmapImage(new Uri("Images/Circle.jpg", UriKind.Relative));
                btnRightBot.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[8] = 1;
            }
            else
            {
                ImgRightBot.Source = new BitmapImage(new Uri("Images/download.png", UriKind.Relative));
                btnRightBot.IsEnabled = false;
                PlayerTurn = true;
                WinCheck[8] = 2;
            }

            WinChecker();
        }

        private void WinChecker()
        {
            if (WinCheck[0] == 1 && WinCheck[1] == 1 && WinCheck[2] == 1 || WinCheck[3] == 1 && WinCheck[4] == 1 && WinCheck[5] == 1 || WinCheck[6] == 1 && WinCheck[7] == 1 && WinCheck[8] == 1 ||
                WinCheck[0] == 1 && WinCheck[4] == 1 && WinCheck[8] == 1 || WinCheck[2] == 1 && WinCheck[4] == 1 && WinCheck[6] == 1 ||
                WinCheck[0] == 1 && WinCheck[3] == 1 && WinCheck[6] == 1 || WinCheck[1] == 1 && WinCheck[4] == 1 && WinCheck[7] == 1 || WinCheck[2] == 1 && WinCheck[5] == 1 && WinCheck[8] == 1)
            {
                txtWin.Text = "Player 1 Wins";
            }
            else if (WinCheck[0] == 2 && WinCheck[1] == 2 && WinCheck[2] == 2 || WinCheck[3] == 2 && WinCheck[4] == 2 && WinCheck[5] == 2 || WinCheck[6] == 2 && WinCheck[7] == 2 && WinCheck[8] == 2 ||
                WinCheck[0] == 2 && WinCheck[4] == 2 && WinCheck[8] == 2 || WinCheck[2] == 2 && WinCheck[4] == 2 && WinCheck[6] == 2 ||
                WinCheck[0] == 2 && WinCheck[3] == 2 && WinCheck[6] == 2 || WinCheck[1] == 2 && WinCheck[4] == 2 && WinCheck[7] == 2 || WinCheck[2] == 2 && WinCheck[5] == 2 && WinCheck[8] == 2)
            {
                txtWin.Text = "Player 2 Wins";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnBotLeft.IsEnabled = true;
        }
    }
}
