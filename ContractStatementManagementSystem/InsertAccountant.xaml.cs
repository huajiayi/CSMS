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
            string cost = tb_Cost.Text.ToString().Trim();
            string material = tb_Material.Text.ToString().Trim();
            string subtotal = tb_Subtotal.Text.ToString().Trim();
            string grossrofitMargin = tb_GrossrofitMargin.Text.ToString().Trim();
            string name = Name.Text.ToString().Trim(); ;
            AccountantLog al = new AccountantLog();
            al.ID = Guid.NewGuid();
            al.LogName = logName;
            al.LogDate = DateTime.Now.ToString();
            // al.ServiceID=
            al.Name = name;
            al.Service = service;
            al.AffirmIncomeGist = affirmIncomeAmount;
            al.AffirmIncomeAmount = Convert.ToDecimal(affirmIncomeAmount); 
            al.InvoiceCount = Convert.ToDouble(invoiceCount);
            al.InvoiceAmount = Convert.ToDecimal(invoiceAmount);
            al.Cost= Convert.ToDouble(cost);
            al.Material= Convert.ToDecimal(material);
            al.GrossrofitMargin= Convert.ToDouble(grossrofitMargin);
            al.Subtotal= Convert.ToDecimal(subtotal);
            al.ContractID = mw.ct.ID;
            al.DepartmentID = mw.aac[0].ID;
            mw.oac.Add(al);
            mw.aac[0] = GetData.AccountantGet(al,mw.aac)[0];
            MessageBox.Show("操作成功！");
            this.Close();
        }
    }
}
