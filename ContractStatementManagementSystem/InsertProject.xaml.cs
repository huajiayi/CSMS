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
    /// Interaction logic for InsertProject.xaml
    /// </summary>
    public partial class InsertProject : Window
    {
        public InsertProject()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string dompletedDate = tb_DompletedDate.Text.Trim(); //竣工日期
            string dompletedAcceptanceDate = tb_DompletedAcceptanceDate.Text.Trim(); //取得竣工验收单日期

            this.Close();
        }
    }
}
