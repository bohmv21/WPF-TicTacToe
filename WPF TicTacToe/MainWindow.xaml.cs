using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        public int[] WinCheck = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTopLeft_Click(object sender, RoutedEventArgs e)
        {
            Image button = (Image)((Button)sender).Content;
            string Name = ((Button)sender).Name;
            ArrayConverter(Name);

            if (PlayerTurn == true)
            {
                button.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                ImgTopLeft.Visibility = Visibility.Visible;
                btnTopLeft.IsEnabled = false;
                WinCheck[0] = 1;
            }
            else
            {
                ImgTopLeft.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                ImgTopLeft.Visibility = Visibility.Visible;
                btnTopLeft.IsEnabled = false;
                WinCheck[0] = 2;
            }
            PlayerTurn = !PlayerTurn;
            WinChecker();
        }

        private void btnMidLeft_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerTurn == true)
            {
                ImgMidLeft.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                ImgMidLeft.Visibility = Visibility.Visible;
                btnMidLeft.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[1] = 1;
            }
            else
            {
                ImgMidLeft.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                ImgMidLeft.Visibility = Visibility.Visible;
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
                ImgBotLeft.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                ImgBotLeft.Visibility = Visibility.Visible;
                btnBotLeft.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[2] = 1;
            }
            else
            {
                ImgBotLeft.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                ImgBotLeft.Visibility = Visibility.Visible;
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
                ImgMidTop.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                ImgMidTop.Visibility = Visibility.Visible;
                btnMidTop.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[3] = 1;
            }
            else
            {
                ImgMidTop.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                ImgMidTop.Visibility = Visibility.Visible;
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
                ImgMid.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                ImgMid.Visibility = Visibility.Visible;
                btnMid.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[4] = 1;

            }
            else
            {
                ImgMid.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                ImgMid.Visibility = Visibility.Visible;
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
                ImgMidBot.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                ImgMidBot.Visibility = Visibility.Visible;
                btnMidBot.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[5] = 1;

            }
            else
            {
                ImgMidBot.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                ImgMidBot.Visibility = Visibility.Visible;
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
                ImgRightTop.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                ImgRightTop.Visibility = Visibility.Visible;
                btnRightTop.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[6] = 1;
            }
            else
            {
                ImgRightTop.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                ImgRightTop.Visibility = Visibility.Visible;
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
                ImgRightMid.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                ImgRightMid.Visibility = Visibility.Visible;
                btnRightMid.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[7] = 1;
            }
            else
            {
                ImgRightMid.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                ImgRightMid.Visibility = Visibility.Visible;
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
                ImgRightBot.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                ImgRightBot.Visibility = Visibility.Visible;
                btnRightBot.IsEnabled = false;
                PlayerTurn = false;
                WinCheck[8] = 1;
            }
            else
            {
                ImgRightBot.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                ImgRightBot.Visibility = Visibility.Visible;
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
                btnTopLeft.IsEnabled = false;
                btnMidLeft.IsEnabled = false;
                btnBotLeft.IsEnabled = false;
                btnMidTop.IsEnabled = false;
                btnMid.IsEnabled = false;
                btnMidBot.IsEnabled = false;
                btnRightTop.IsEnabled = false;
                btnRightMid.IsEnabled = false;
                btnRightBot.IsEnabled = false;
                txtPopup.Text = "P1 Wins!!";
                popup.IsOpen = true;
            }
            else if (WinCheck[0] == 2 && WinCheck[1] == 2 && WinCheck[2] == 2 || WinCheck[3] == 2 && WinCheck[4] == 2 && WinCheck[5] == 2 || WinCheck[6] == 2 && WinCheck[7] == 2 && WinCheck[8] == 2 ||
                WinCheck[0] == 2 && WinCheck[4] == 2 && WinCheck[8] == 2 || WinCheck[2] == 2 && WinCheck[4] == 2 && WinCheck[6] == 2 ||
                WinCheck[0] == 2 && WinCheck[3] == 2 && WinCheck[6] == 2 || WinCheck[1] == 2 && WinCheck[4] == 2 && WinCheck[7] == 2 || WinCheck[2] == 2 && WinCheck[5] == 2 && WinCheck[8] == 2)
                 {
                txtWin.Text = "Player 2 Wins";
                btnTopLeft.IsEnabled = false;
                btnMidLeft.IsEnabled = false;
                btnBotLeft.IsEnabled = false;
                btnMidTop.IsEnabled = false;
                btnMid.IsEnabled = false;
                btnMidBot.IsEnabled = false;
                btnRightTop.IsEnabled = false;
                btnRightMid.IsEnabled = false;
                btnRightBot.IsEnabled = false;
                txtPopup.Text = "P2 Wins!!";
                popup.IsOpen = true;

                 }
            else if (WinCheck[0] >= 1 && WinCheck[1] >= 1 && WinCheck[2] >= 1 && WinCheck[3] >= 1 && WinCheck[4] >= 1 && WinCheck[5] >= 1 && WinCheck[6] >= 1 && WinCheck[7] >= 1 && WinCheck[8] >= 1)
            {
                txtWin.Text = "Tie!";
            }

        }

        private void ArrayConverter(string sender)
        {
            switch (sender)
            {
                case "btnTopLeft":

                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnTopLeft.IsEnabled = true;
            btnMidLeft.IsEnabled = true;
            btnBotLeft.IsEnabled = true;
            btnMidTop.IsEnabled = true;
            btnMid.IsEnabled = true;
            btnMidBot.IsEnabled = true;
            btnRightTop.IsEnabled = true;
            btnRightMid.IsEnabled = true;
            btnRightBot.IsEnabled = true;

            ImgTopLeft.Visibility = Visibility.Hidden;
            ImgMidLeft.Visibility = Visibility.Hidden;
            ImgBotLeft.Visibility = Visibility.Hidden;
            ImgMidTop.Visibility = Visibility.Hidden;
            ImgMid.Visibility = Visibility.Hidden;
            ImgMidBot.Visibility = Visibility.Hidden;
            ImgRightTop.Visibility = Visibility.Hidden;
            ImgRightMid.Visibility = Visibility.Hidden;
            ImgRightBot.Visibility = Visibility.Hidden;

            WinCheck[0] = 0;
            WinCheck[1] = 0;
            WinCheck[2] = 0;
            WinCheck[3] = 0;
            WinCheck[4] = 0;
            WinCheck[5] = 0;
            WinCheck[6] = 0;
            WinCheck[7] = 0;
            WinCheck[8] = 0;

            txtWin.Text = null;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button_Click(sender, e);
            popup.IsOpen = false;
        }
    }
}
