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
    /// Interaction logic for InsertSales.xaml
    /// </summary>
    public partial class InsertSales : Window
    {
        public MainWindow mw; 
        public InsertSales(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
            cb_Service.ItemsSource = mw.ocd;
            cb_Service.SelectedIndex = 0;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string logName = tb_LogName.Text.ToString().Trim();
                Contract_Data item = (Contract_Data)cb_Service.SelectedItem;
                string service = item.Service;
                string amount = tb_Amount.Text.ToString().Trim();

                if (string.IsNullOrEmpty(logName) || string.IsNullOrEmpty(service) || string.IsNullOrEmpty(amount))
                {
                    MessageBox.Show("所有值皆不能为空");
                }
                else if (double.Parse(amount) < 0)
                {
                    MessageBox.Show("收款金额不能为负数");
                }
                else
                {
                    SalesLog sl = new SalesLog();
                    sl.DepartmentID = mw.ssl[0].ID;
                    sl.ID = Guid.NewGuid();
                    sl.ContractID = mw.ct.ID;
                    sl.Service = service;
                    sl.ServiceID = item.ID;
                    sl.AffirmIncomeAmount = Convert.ToDecimal(amount);
                    sl.LogDate = DateTime.Now.ToString();
                    sl.LogName = logName;
                    mw.osl.Add(sl);
                    mw.ssl[0] = GetData.SalesGet(sl, mw.ssl)[0];
                    MessageBox.Show("操作成功！");
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("收款金额只能为正数");
            }   
        }

        private void tb_Amount_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string amount = tb_Amount.Text.ToString().Trim();
            if (string.IsNullOrEmpty(amount))
            {
                amount = "0";
            }
            if (decimal.Parse(amount) > mw.ssl[0].NoAmountCollection)
            {
                tb_Amount_Warn.Visibility = Visibility.Visible;
                btn_Save.IsEnabled = false;
            }
            else
            {
                tb_Amount_Warn.Visibility = Visibility.Collapsed;
                btn_Save.IsEnabled = true;
            }
            }
            catch (FormatException)
            {
                
            }
        }
    }
}
