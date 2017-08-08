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
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string logName = tb_LogName.Text.ToString().Trim();
            string productionQuantity = tb_ProductionQuantity.Text.ToString().Trim();
            string productionDate = DateTime.Parse(tb_ProductionDate.ToString().Trim()).ToShortDateString();
            ProductionerLog pl = new ProductionerLog();
            pl.ID = Guid.NewGuid();
            pl.ContractID = mw.ct.ID;
            pl.DepartmentID = mw.ppr[0].ID;
            pl.ProductionCount = Convert.ToDouble(productionQuantity);
  
            pl.ProductionDate = productionDate;
            pl.LogDate = DateTime.Now.ToString();
            pl.LogName = logName;
            mw.opr.Add(pl);
            mw.ppr[0] = GetData.ProductionerGet(pl, mw.ppr)[0];
            MessageBox.Show("操作成功！");
            this.Close();
        }
    }
}
