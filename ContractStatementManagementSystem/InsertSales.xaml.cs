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
    /// Interaction logic for InsertSales.xaml
    /// </summary>
    public partial class InsertSales : Window
    {
        public InsertSales()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string returnDate = tb_ReturnDate.Text.Trim(); //回执日期
            string invoiceDate = tb_InvoiceDate.Text.Trim(); //开具发票日期
            string affirmIncomeData = tb_AffirmIncomeData.Text.Trim(); //确认收入日期
            string affirmIncomeAmount = tb_AffirmIncomeAmount.Text.Trim(); //确认收入金额
            string invoiceCount = tb_InvoiceCount.Text.Trim(); //已开票数
            string invoiceAmount = tb_InvoiceAmount.Text.Trim(); //已开票金额
            string amountCollection = tb_AmountCollection.Text.Trim(); //已收入金额
            string affirmIncomeGist = tb_AffirmIncomeGist.Text.Trim(); //确认收入依据

            this.Close();
        }
    }
}
