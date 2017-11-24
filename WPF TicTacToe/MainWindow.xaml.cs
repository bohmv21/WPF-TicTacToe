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

        private void Default_Click(object sender, RoutedEventArgs e)
        {
            Image button = (Image)((Button)sender).Content;
            int Name = Convert.ToInt16(((Button)sender).Name.Remove(0,1));

            if (PlayerTurn == true)
            {
                button.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                imgTurn.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                WinCheck[Name] = 1;
            }
            else
            {
                button.Source = new BitmapImage(new Uri("Images/Cross.png", UriKind.Relative));
                imgTurn.Source = new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative));
                WinCheck[Name] = 2;
            }
            ((Button)sender).IsEnabled = false;
            PlayerTurn = !PlayerTurn;
            WinChecker();
        }

        private void WinChecker()
        {
            if (WinCheck[0] == 1 && WinCheck[1] == 1 && WinCheck[2] == 1 || WinCheck[3] == 1 && WinCheck[4] == 1 && WinCheck[5] == 1 || WinCheck[6] == 1 && WinCheck[7] == 1 && WinCheck[8] == 1 ||
                WinCheck[0] == 1 && WinCheck[4] == 1 && WinCheck[8] == 1 || WinCheck[2] == 1 && WinCheck[4] == 1 && WinCheck[6] == 1 ||
                WinCheck[0] == 1 && WinCheck[3] == 1 && WinCheck[6] == 1 || WinCheck[1] == 1 && WinCheck[4] == 1 && WinCheck[7] == 1 || WinCheck[2] == 1 && WinCheck[5] == 1 && WinCheck[8] == 1)
            {
                txtWin.Text = "Player 1 Wins";
                txtPopup.Text = "P1 Wins!!";
                popup.IsOpen = true;
            }
            else if (WinCheck[0] == 2 && WinCheck[1] == 2 && WinCheck[2] == 2 || WinCheck[3] == 2 && WinCheck[4] == 2 && WinCheck[5] == 2 || WinCheck[6] == 2 && WinCheck[7] == 2 && WinCheck[8] == 2 ||
                WinCheck[0] == 2 && WinCheck[4] == 2 && WinCheck[8] == 2 || WinCheck[2] == 2 && WinCheck[4] == 2 && WinCheck[6] == 2 ||
                WinCheck[0] == 2 && WinCheck[3] == 2 && WinCheck[6] == 2 || WinCheck[1] == 2 && WinCheck[4] == 2 && WinCheck[7] == 2 || WinCheck[2] == 2 && WinCheck[5] == 2 && WinCheck[8] == 2)
                 {
                txtWin.Text = "Player 2 Wins";
                txtPopup.Text = "P2 Wins!!";
                popup.IsOpen = true;

                 }
            else if (WinCheck[0] >= 1 && WinCheck[1] >= 1 && WinCheck[2] >= 1 && WinCheck[3] >= 1 && WinCheck[4] >= 1 && WinCheck[5] >= 1 && WinCheck[6] >= 1 && WinCheck[7] >= 1 && WinCheck[8] >= 1)
            {
                txtWin.Text = "Tie!";
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Image[] arrSource = {ImgTopLeft , ImgMidLeft , ImgBotLeft , ImgMidTop, ImgMid, ImgMidBot , ImgRightTop, ImgRightMid, ImgRightBot , imgTurn};

            _0.IsEnabled = true;
            _1.IsEnabled = true;
            _2.IsEnabled = true;
            _3.IsEnabled = true;
            _4.IsEnabled = true;
            _5.IsEnabled = true;
            _6.IsEnabled = true;
            _7.IsEnabled = true;
            _8.IsEnabled = true;

            foreach (Image element in arrSource)
            {
                element.Source = null;
            }

            foreach (int element in WinCheck)
            {
                int i = 0;
                WinCheck[i] = 0;
                i++;
            }

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
            Reset_Click(sender, e);
            popup.IsOpen = false;
        }
    }
}
