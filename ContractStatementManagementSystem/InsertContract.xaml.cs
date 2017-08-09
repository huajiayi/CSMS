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
    /// Interaction logic for InsertContract.xaml
    /// </summary>
    public partial class InsertContract : Window
    {
        //public ObservableCollection<ContractNameT> oct; 
        public MainWindow mw;
        public InsertContract()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string contractName = tb_ContractName.Text.ToString().Trim();
                string customer = tb_Customer.Text.ToString().Trim();
                ComboBoxItem item = cb_Contract_Type.SelectedItem as ComboBoxItem;
                string contract_Type = item.Content.ToString().Trim();
                string contract_Amount = tb_Contract_Amount.Text.ToString().Trim();
                string count = tb_Count.Text.ToString().Trim();
                string contract_Number = tb_Contract_Number.Text.ToString().Trim();
                string contract_Date;
                if (string.IsNullOrEmpty(tb_Contract_Date.ToString()))
                {
                    contract_Date = "";
                }
                else
                {
                    contract_Date = DateTime.Parse(tb_Contract_Date.ToString().Trim()).ToShortDateString();
                }

                if (string.IsNullOrEmpty(contractName) || string.IsNullOrEmpty(customer) || string.IsNullOrEmpty(contract_Type) || string.IsNullOrEmpty(contract_Amount) || string.IsNullOrEmpty(count) || string.IsNullOrEmpty(contract_Number) || string.IsNullOrEmpty(contract_Date))
                {
                    MessageBox.Show("所有值皆不能为空");
                }
                else if (decimal.Parse(contract_Amount) < 0)
                {
                    MessageBox.Show("合同金额不能为负数");
                }
                else if (double.Parse(count) < 0)
                {
                    MessageBox.Show("数量不能为负数");
                }
                else if (double.Parse(count) % 1 != 0)
                {
                    MessageBox.Show("数量不能为小数");
                }
                else
                {
                    ContractNameT ct = new ContractNameT();
                    ct.ID = Guid.NewGuid();
                    ct.Customer = customer;
                    ct.ContractName = contractName;
                    ct.Contract_Type = contract_Type;
                    ct.Contract_Amount = Convert.ToDecimal(contract_Amount);
                    ct.Contract_Date = contract_Date;
                    ct.Contract_Number = contract_Number;
                    ct.Count = Convert.ToDouble(count);
                    Contract_Data cd = new Contract_Data();
                    cd.ID = Guid.NewGuid();
                    cd.Contract_ID = ct.ID;
                    //cd.Service = "总服务";
                    GetData.first(ct, cd);
                    //oct = new ObservableCollection<ContractNameT>();
                    var a = mw.oct;



                    mw.oct.Add(ct);
                    mw.oct = new ObservableCollection<ContractNameT>(mw.oct.OrderByDescending(x => DateTime.Parse(x.Contract_Date)));
                    mw.listView_Contract.ItemsSource = mw.oct;
                    mw.listView_Contract.Items.Refresh();
                    MessageBox.Show("操作成功！");
                    mw.listView_Contract.SelectedItem = ct;

                    //立即创建一个服务
                    InsertService ins = new InsertService();
                    ins.mw = this.mw;
                    ins.ShowDialog();
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("合同金额和数量只能为正数");
            }
        }

    }
}
