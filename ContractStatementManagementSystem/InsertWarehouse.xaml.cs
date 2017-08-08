using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Warehouse> wwh { get; set; }
        public InsertWarehouse()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string logName = tb_LogName.Text.ToString().Trim();
            string shipments = tb_Shipments.Text.ToString().Trim();
            string shippedDate = DateTime.Parse(tb_ShippedDate.ToString().Trim()).ToShortDateString();
            WarehouseLog w = new WarehouseLog();
            w.ID = Guid.NewGuid();
            w.LogName = logName;
            w.Shipments = Convert.ToDouble(shipments);
            w.ShippedDate = shippedDate;
            w.LogDate = DateTime.Now.ToString();
            w.ContractID = mw.ct.ID;
            w.DepartmentID = mw.wwh[0].ID;
            mw.wwh[0]=GetData.WarehouseGet(w, mw.wwh)[0];
            mw.ocw.Add(w);
            MessageBox.Show("操作成功！");
            this.Close();
        }
    }
}
