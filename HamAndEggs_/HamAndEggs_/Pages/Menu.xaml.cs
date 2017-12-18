using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
using System.Collections;

namespace HamAndEggs_.Pages
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        Ham_and_EggsDataSet datasource = new Ham_and_EggsDataSet();
        public string Data;
        public Menu()
        {
            InitializeComponent();

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            string strConnection = ConfigurationManager.ConnectionStrings["HamAndEggsConnection"].ConnectionString;
            string CmdString = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                CmdString = "SELECT * FROM Food";
                SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = datasource.Tables["Food"];
                sda.Fill(dt);
                myDataGrid.ItemsSource = dt.DefaultView;
            }
        }

        private void InsertIntoDatabase(string Order, string Tafel)
        {
            string strConnection = ConfigurationManager.ConnectionStrings["HamAndEggsConnection"].ConnectionString;
            string CmdString = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                CmdString = ($"INSERT INTO Receipt (Name, Tafel) VALUES ('{Order}' , '{Tafel}')");
                SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = datasource.Tables["Receipt"];
                sda.Fill(dt);
            }
        }

        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView drv = (DataRowView)myDataGrid.SelectedItem;
            Data = Data + (drv[1].ToString()) + "\n";
            string Order = (drv[1].ToString());
            Receipt.Text = Data;
            string Tafel = MainWindow.AppWindow.btnCont;
            InsertIntoDatabase(Order , Tafel);           
        }
    }
}
