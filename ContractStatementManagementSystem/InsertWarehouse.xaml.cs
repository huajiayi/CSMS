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

namespace ContractStatementManagementSystem
{
    /// <summary>
    /// Interaction logic for InsertWarehouse.xaml
    /// </summary>
    public partial class InsertWarehouse : Window
    {
        public MainWindow mw;
        public InsertWarehouse()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string logName = tb_LogName.Text.ToString().Trim();
            string shipments = tb_Shipments.Text.ToString().Trim();
            string shippedDate = tb_ShippedDate.Text.ToString().Trim();

            MessageBox.Show("操作成功！");
            this.Close();
        }
    }
}
