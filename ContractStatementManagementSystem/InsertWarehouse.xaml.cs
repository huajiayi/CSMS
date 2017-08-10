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
            tb_ShippedDate.SelectedDate = DateTime.Now;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string logName = tb_LogName.Text.ToString().Trim();
                string shipments = tb_Shipments.Text.ToString().Trim();
                string shippedDate;
                if (string.IsNullOrEmpty(tb_ShippedDate.ToString()))
                {
                    shippedDate = "";
                }
                else
                {
                    shippedDate = DateTime.Parse(tb_ShippedDate.ToString().Trim()).ToShortDateString();
                }

                if (string.IsNullOrEmpty(logName) || string.IsNullOrEmpty(shipments) || string.IsNullOrEmpty(shippedDate))
                {
                    MessageBox.Show("所有值皆不能为空");
                }
                else if (double.Parse(shipments) < 0)
                {
                    MessageBox.Show("发货数量不能为负数");
                }
                else if (double.Parse(shipments) % 1 != 0)
                {
                    MessageBox.Show("发货数量不能为小数");
                }
                else
                {
                    WarehouseLog w = new WarehouseLog();
                    w.ID = Guid.NewGuid();
                    w.LogName = logName;
                    w.Shipments = Convert.ToDouble(shipments);
                    w.ShippedDate = shippedDate;
                    w.LogDate = DateTime.Now.ToString();
                    w.ContractID = mw.ct.ID;
                    w.DepartmentID = mw.wwh[0].ID;
                    mw.wwh[0] = GetData.WarehouseGet(w, mw.wwh)[0];
                    mw.ocw.Add(w);
                    MessageBox.Show("操作成功！");
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("发货数量只能为正整数");
            }   
        }

        private void tb_Shipments_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string shipments = tb_Shipments.Text.ToString().Trim();
                if (string.IsNullOrEmpty(shipments))
                {
                    shipments = "0";
                }
                //如果发货数量大于库存量，提示库存量不足
                if (double.Parse(shipments) > mw.wwh[0].Reserves)
                {
                    tb_Insufficient_Warn.Visibility = Visibility.Visible;
                    btn_Save.IsEnabled = false;
                }
                else
                {
                    tb_Insufficient_Warn.Visibility = Visibility.Collapsed;
                    btn_Save.IsEnabled = true;
                }
                //如果发货数量大于未发货数量，提示发货数量不能大于未发货数量
                if (double.Parse(shipments) > mw.wwh[0].NoShippedCount)
                {
                    tb_Shipments_Warn.Visibility = Visibility.Visible;
                    btn_Save.IsEnabled = false;
                }
                else
                {
                    tb_Shipments_Warn.Visibility = Visibility.Collapsed;
                    btn_Save.IsEnabled = true;
                }
            }
            catch (FormatException)
            {
                
            }
        }
    }
}
