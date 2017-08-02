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
        public InsertAccountant()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
