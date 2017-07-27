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
    /// Interaction logic for InsertContract.xaml
    /// </summary>
    public partial class InsertContract : Window
    {
        public InsertContract()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string contract = tb_Contract.Text.Trim(); //合同名称
            string project = tb_Project.Text.Trim(); //项目名称
            string customer = tb_Customer.Text.Trim(); //合同方客户名称
            ComboBoxItem cbi = cb_Contract_Type.SelectedItem as ComboBoxItem;
            string contract_Type = cbi.Content.ToString().Trim(); //合同类别
            string contract_Amount = tb_Contract_Amount.Text.Trim(); //合同金额（人民币元）
            string count = tb_Count.Text.Trim(); //数量（套/个）
            string contract_Number = tb_Contract_Number.Text.Trim(); //合同编号
            string contract_Date = tb_Contract_Date.Text.Trim(); //合同签署日期

            this.Close();
        }
    }
}
