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
using System.IO;

namespace HamAndEggs_.Pages
{

    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        string strConnection = ConfigurationManager.ConnectionStrings["HamAndEggsConnection"].ConnectionString;
        string CmdString = string.Empty;
        public string Tafel;

        Ham_and_EggsDataSet datasource = new Ham_and_EggsDataSet();
        public string Data;
        public Menu()
        {
            InitializeComponent();
            FillDataGrid("SELECT * FROM Food" , "Food" , myDataGrid);
            Tafel = MainWindow.AppWindow.btnCont;
            FillDataGrid($"SELECT * FROM Receipt WHERE Tafel='{Tafel}'", "Receipt", ReceiptGrid);
        }

        private void FillDataGrid(string Cmd, string Table, DataGrid grid)
        {

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                CmdString = Cmd;
                SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = datasource.Tables[Table];
                sda.Fill(dt);
                grid.ItemsSource = dt.DefaultView;
            }
        }

        private void InsertIntoDatabase(string Order, string Tafel)
        {

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
            string Order = (drv[1].ToString());
            string Tafel = MainWindow.AppWindow.btnCont;
            InsertIntoDatabase(Order , Tafel);
            FillDataGrid($"SELECT * FROM Receipt WHERE Tafel='{Tafel}'" , "Receipt", ReceiptGrid);
        }

        private void btnReceipt_Click(object sender, RoutedEventArgs e)
        {
            ReceiptGrid.SelectAllCells();
            var cellInfos = ReceiptGrid.SelectedCells;

            var list1 = new List<string>();

            foreach (DataGridCellInfo cellInfo in cellInfos)
            {
                if (cellInfo.IsValid)
                {
                    //GetCellContent returns FrameworkElement
                    var content = cellInfo.Column.GetCellContent(cellInfo.Item);

                    //Need to add the extra lines of code below to get desired output

                    //get the datacontext from FrameworkElement and typecast to DataRowView
                    var row = (DataRowView)content.DataContext;

                    //ItemArray returns an object array with single element
                    object[] obj = row.Row.ItemArray;

                    //store the obj array in a list or Arraylist for later use
                    list1.Add(obj[1].ToString() + " €2.00");
                }
            }

            string[] text = list1.ToArray();
            File.WriteAllLines("../Receipt.txt", text);
        }

        private void btnReserveTable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClearReceipt_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                CmdString = ($"DELETE FROM Receipt WHERE Tafel='{Tafel}'");
                SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = datasource.Tables["Receipt"];
                sda.Fill(dt);
            }

            MainWindow.AppWindow.GoToTablesPage(sender, e);
        }
    }
}
