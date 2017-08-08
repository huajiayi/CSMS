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
            string contractName = tb_ContractName.Text.ToString().Trim();
            string customer = tb_Customer.Text.ToString().Trim();
            ComboBoxItem item = cb_Contract_Type.SelectedItem as ComboBoxItem;
            string contract_Type = item.Content.ToString().Trim();
            string contract_Amount = tb_Contract_Amount.Text.ToString().Trim();
            string count = tb_Count.Text.ToString().Trim();
            string contract_Number = tb_Contract_Number.Text.ToString().Trim();
            string contract_Date = DateTime.Parse(tb_Contract_Date.ToString().Trim()).ToShortDateString();
            ContractNameT ct = new ContractNameT();
            ct.ID = Guid.NewGuid();
            ct.Customer = customer;
            ct.ContractName = contractName;
            ct.Contract_Type = contract_Type;
            ct.Contract_Amount = Convert.ToDecimal(contract_Amount);
            ct.Contract_Date = contract_Date;
            ct.Contract_Number =contract_Number;
            ct.Count = Convert.ToDouble(count);
            Contract_Data cd = new Contract_Data();
            cd.ID = Guid.NewGuid();
            cd.Contract_ID = ct.ID;
            cd.Service = "总服务";
            GetData.first(ct,cd);
            //oct = new ObservableCollection<ContractNameT>();
            var a = mw.oct;
            


            mw.oct.Add(ct);
            mw.oct = new ObservableCollection<ContractNameT>(mw.oct.OrderByDescending(x => DateTime.Parse(x.Contract_Date)));
            MessageBox.Show("操作成功！");
           
            this.Close();
        }
    }
}
