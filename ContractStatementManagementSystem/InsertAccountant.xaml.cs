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
        public MainWindow mw;
        public InsertAccountant()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string logName = tb_LogName.Text.ToString().Trim();
            string service = tb_Service.Text.ToString().Trim();
            ComboBoxItem cbi = cb_AffirmIncomeGist.SelectedItem as ComboBoxItem;
            string affirmIncomeGist = cbi.Content.ToString().Trim();
            string affirmIncomeAmount = tb_AffirmIncomeAmount.Text.ToString().Trim();
            string invoiceCount = tb_InvoiceCount.Text.ToString().Trim();
            string invoiceAmount = tb_InvoiceAmount.Text.ToString().Trim();
            string amount = tb_Amount.Text.ToString().Trim();
            string cost = tb_Cost.Text.ToString().Trim();
            string material = tb_Material.Text.ToString().Trim();
            string subtotal = tb_Subtotal.Text.ToString().Trim();
            string grossrofitMargin = tb_GrossrofitMargin.Text.ToString().Trim();

            MessageBox.Show("操作成功！");
            this.Close();
        }
    }
}
