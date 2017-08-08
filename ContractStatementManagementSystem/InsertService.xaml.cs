
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for InsertService.xaml
    /// </summary>
    public partial class InsertService : Window
    {
        public MainWindow mw;
        public InsertService()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string service = tb_Service.Text.ToString().Trim();
            Contract_Data contract_Data = new Contract_Data();
            contract_Data.Contract_ID = mw.ct.ID;
            contract_Data.ID = Guid.NewGuid();
            contract_Data.Service = service;
            mw.ocd.Add(contract_Data);
            SqlQuery.insert(contract_Data);
            MessageBox.Show("操作成功！");
            this.Close();
        }
    }
}
