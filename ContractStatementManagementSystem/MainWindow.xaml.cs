using ContractStatementManagementSystem.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace ContractStatementManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Main main;
        ContractContent contractContent; // 当前选择的合同内容页
        Sales sale; //当前选择的销售页
        public MainWindow()
        {
            InitializeComponent();
            main = new Main();
            main.ContractContents = new ObservableCollection<ContractContent>();
            main.Sales = new ObservableCollection<Sales>();

            InsertContractContent("a","1","1","100","1","1","2017/1/1"); //假数据
            InsertContractContent("b", "2", "2", "200", "2", "2", "2017/1/1"); //假数据
            grid_Main.DataContext = main;
        }

        private void listView_Contract_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            contractContent = listView_Contract.SelectedItem as ContractContent;
            stackPanel_ContractContent.DataContext = contractContent;

            sale = main.Sales.Single<Sales>(o => o.Contract_ID == contractContent.ID);
            stackPanel_Sales.DataContext = sale;
        }

        private void btn_InsertContract_Click(object sender, RoutedEventArgs e)
        {
            InsertContract ic = new InsertContract();
            ic.Show();
            ic.mw = this;
        }

        private void btn_deleteContract_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("你确定要删除本合同吗？", "提示", MessageBoxButton.YesNo, MessageBoxImage.Asterisk, MessageBoxResult.No, MessageBoxOptions.None);
            if (result == MessageBoxResult.Yes)
            {
                ContractContent contractContent = listView_Contract.SelectedItem as ContractContent;
                main.ContractContents.Remove(contractContent);

                MessageBox.Show("删除成功！");
                listView_Contract.SelectedIndex = main.ContractContents.Count - 1;
            }
        }

        private void btn_InsertService_Click(object sender, RoutedEventArgs e)
        {
            InsertService ins = new InsertService();
            ins.Show();
            ins.mw = this;
        }

        private void btn_Insert_Click(object sender, RoutedEventArgs e)
        {
            Button btn_Insert = (Button)sender;
            switch (btn_Insert.Name)
            {
                case "btn_InsertWarehouse":
                    InsertWarehouse iw = new InsertWarehouse();
                    iw.Show();
                    iw.mw = this;
                    break;
                case "btn_InsertAccountant":
                    InsertAccountant ia = new InsertAccountant();
                    ia.Show();
                    ia.mw = this;
                    break;
                case "btn_InsertProduction":
                    InsertProduction ip = new InsertProduction();
                    ip.Show();
                    ip.mw = this;
                    break;
                case "btn_InsertProject":
                    InsertProject ipj = new InsertProject();
                    ipj.Show();
                    ipj.mw = this;
                    break;
                case "btn_InsertSales":
                    InsertSales isl = new InsertSales();
                    isl.Show();
                    isl.mw = this;
                    break;
                default:
                    break;
            }
        }

        public void InsertContractContent(string contractName, string customer, string contract_Type, string contract_Amount, string count, string contract_Number, string contract_Date)
        {
            ContractContent contractContent = new ContractContent();
            contractContent.ID = Guid.NewGuid();
            contractContent.Customer = customer;
            contractContent.Contract_Type = contract_Type;
            contractContent.Contract_Amount = decimal.Parse(contract_Amount);
            contractContent.Count = double.Parse(count);
            contractContent.Contract_Number = contract_Number;
            contractContent.Contract_Date = contract_Date;
            contractContent.ContractName = contractName;
            contractContent.Contract_Datas = new ObservableCollection<Contract_Data>();
            main.ContractContents.Add(contractContent);
            //填充销售页内容
            InsertSales(contractContent);
        }

        private void InsertSales(ContractContent contractContent)
        {
            Sales sales = new Sales();
            sales.Contract_ID = contractContent.ID;
            sales.ContractName = contractContent.ContractName;
            sales.Contract_Amount = contractContent.Contract_Amount;
            sales.AmountCollection = 0;
            sales.NoAmountCollection = contractContent.Contract_Amount;
            sales.SalesLogs = new ObservableCollection<SalesLog>();
            main.Sales.Add(sales);
        }

        public void UpdateContractContent(string logName, string service, string amount)
        {
            //已收金额&未收金额相应改变
            sale.AmountCollection += decimal.Parse(amount);
            sale.NoAmountCollection -= decimal.Parse(amount);
            //添加一条日志
            SalesLog salesLog = new SalesLog();
            salesLog.LogName = logName;
            salesLog.Service = service;
            salesLog.Amount = decimal.Parse(amount);
            salesLog.Operator = "华嘉熠";
            salesLog.OperationDate = DateTime.Now.ToString();
            sale.SalesLogs.Add(salesLog);
            //刷新Label控件，目前只能以这种方法能刷新
            if (listView_Contract.SelectedIndex == 0)
            {
                listView_Contract.SelectedIndex += 1;
                listView_Contract.SelectedIndex -= 1;
            }
            else
            {
                listView_Contract.SelectedIndex -= 1;
                listView_Contract.SelectedIndex += 1;
            }
        }
    }
}
