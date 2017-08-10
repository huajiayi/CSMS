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
    /// Interaction logic for InsertProduction.xaml
    /// </summary>
    public partial class InsertProduction : Window
    {
        public MainWindow mw;
        public InsertProduction()
        {
            InitializeComponent();
            tb_ProductionDate.SelectedDate = DateTime.Now;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string logName = tb_LogName.Text.ToString().Trim();
            string productionQuantity = tb_ProductionQuantity.Text.ToString().Trim();
            string productionDate;
            if (string.IsNullOrEmpty(tb_ProductionDate.ToString()))
            {
                productionDate = "";
            }
            else
            {
                productionDate = DateTime.Parse(tb_ProductionDate.ToString().Trim()).ToShortDateString();
            }

            if (string.IsNullOrEmpty(logName) || string.IsNullOrEmpty(productionQuantity) || string.IsNullOrEmpty(productionDate))
            {
                MessageBox.Show("所有值皆不能为空");
            }
            else if (double.Parse(productionQuantity) < 0)
            {
                MessageBox.Show("生产数量不能为负数");
            }
            else if (double.Parse(productionQuantity) % 1 != 0)
            {
                MessageBox.Show("生产数量不能为小数");
            }
            else
            {
                ProductionerLog pl = new ProductionerLog();
                pl.ID = Guid.NewGuid();
                pl.ContractID = mw.ct.ID;
                pl.DepartmentID = mw.ppr[0].ID;
                pl.ProductionCount = Convert.ToDouble(productionQuantity);

                pl.ProductionDate = productionDate;
                pl.LogDate = DateTime.Now.ToString();
                pl.LogName = logName;
                mw.opr.Add(pl);
                mw.ppr[0] = GetData.ProductionerGet(pl, mw.ppr, mw.wwh)[0];
                MessageBox.Show("操作成功！");
                this.Close();
            }
            }
            catch (FormatException)
            {
                MessageBox.Show("生产数量只能为正整数");
            }
        }

        private void tb_ProductionQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string productionQuantity = tb_ProductionQuantity.Text.ToString().Trim();
                if (string.IsNullOrEmpty(productionQuantity))
                {
                    productionQuantity = "0";
                }
                if (double.Parse(productionQuantity) > mw.ppr[0].NoTotalProduct)
                {
                    tb_ProductionQuantity_Warn.Visibility = Visibility.Visible;
                    btn_Save.IsEnabled = false;
                }
                else
                {
                    tb_ProductionQuantity_Warn.Visibility = Visibility.Collapsed;
                    btn_Save.IsEnabled = true;
                }
            }
            catch (FormatException)
            {
                
            }
        }
    }
}
