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
    /// Interaction logic for InsertAccountant.xaml
    /// </summary>
    public partial class InsertAccountant : Window
    {
        public InsertAccountant()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string cost = tb_Cost.Text.Trim(); //已结算成本
            string material = tb_Material.Text.Trim(); //直接材料
            string worker = tb_Worker.Text.Trim(); //直接工人
            string manufacturing_Costs = tb_Manufacturing_Costs.Text.Trim(); //制造费用
            string subtotal = tb_Subtotal.Text.Trim(); //小计
            string GrossrofitMargin = tb_GrossrofitMargin.Text.Trim(); //毛利

            this.Close();
        }
    }
}
