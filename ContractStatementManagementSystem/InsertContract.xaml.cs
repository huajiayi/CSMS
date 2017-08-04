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
        public MainWindow mw;
        public InsertContract()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string contractName = tb_ContractName.Text.ToString().Trim();
            string customer = tb_Customer.Text.ToString().Trim();
            ComboBoxItem item = cb_Contract_Type.SelectedItem as ComboBoxItem;
            string contract_Type = item.Content.ToString().Trim();
            string contract_Amount = tb_Contract_Amount.Text.ToString().Trim();
            string count = tb_Count.Text.ToString().Trim();
            string contract_Number = tb_Contract_Number.Text.ToString().Trim();
            string contract_Date = DateTime.Parse(tb_Contract_Date.ToString().Trim()).ToShortDateString();
            mw.InsertContractContent(contractName, customer, contract_Type, contract_Amount, count, contract_Number, contract_Date);

            MessageBox.Show("操作成功！");
            mw.listView_Contract.SelectedIndex = mw.main.ContractContents.Count - 1;
            this.Close();
        }
    }
}
