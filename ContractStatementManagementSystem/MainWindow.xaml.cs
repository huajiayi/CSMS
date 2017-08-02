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

namespace ContractStatementManagementSystem
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

        private void btn_Insert_Click(object sender, RoutedEventArgs e)
        {
            Button btn_Insert = (Button)sender;
            switch (btn_Insert.Name)
            {
                case "btn_InsertWarehouse":
                    InsertWarehouse iw = new InsertWarehouse();
                    iw.Show();
                    break;
                case "btn_InsertAccountant":
                    InsertAccountant ia = new InsertAccountant();
                    ia.Show();
                    break;
                case "btn_InsertProduction":
                    InsertProduction ip = new InsertProduction();
                    ip.Show();
                    break;
                case "btn_InsertProject":
                    InsertProject ipj = new InsertProject();
                    ipj.Show();
                    break;
                case "btn_InsertSales":
                    InsertSales isl = new InsertSales();
                    isl.Show();
                    break;
                default:
                    break;
            }
        }

        private void btn_InsertContract_Click(object sender, RoutedEventArgs e)
        {
            InsertContract ic = new InsertContract();
            ic.Show();
        }

        private void btn_deleteContract_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
