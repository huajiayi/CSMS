
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
       public ObservableCollection<ContractNameT> oct { get; set; }
        public ObservableCollection<Contract_Data> ocd { get; set; }
        public ObservableCollection<AccountantLog> oac { get; set; }
        public ObservableCollection<ProductionerLog> opr { get; set; }
        public ObservableCollection<ProjectLog> opt { get; set; }
        public ObservableCollection<SalesLog> osl { get; set; }
        public ObservableCollection<WarehouseLog> ocw { get; set; }
        public ObservableCollection<Accountant> aac { get; set; }
        public ObservableCollection<Project> ppt { get; set; }
        public ObservableCollection<Sales> ssl { get; set; }
        public ObservableCollection<Productioner> ppr { get; set; }
        public ObservableCollection<Warehouse>  wwh { get; set; }
        public ContractNameT ct { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<ContractNameT> oct_beforeSort = SqlQuery.ContractQuery();
            oct =new ObservableCollection<ContractNameT> (oct_beforeSort.OrderByDescending(x => DateTime.Parse(x.Contract_Date)).ToList());
            listView_Contract.ItemsSource = oct;
            MClass mc = new MClass();


           // grid_Main.DataContext ;
        }

        private void listView_Contract_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ct=(ContractNameT)listView_Contract.SelectedItem;
            ocd= SqlQuery.ContractDataQuery(ct.ID);
            ListViewSerices.ItemsSource = ocd;
            MClass mc = new MClass();
            aac = SqlQuery.AccountantQuery(ct.ID);
            mc.ac = aac;
            mc.oac = SqlQuery.AccountantLogQuery(ct.ID);
            oac=mc.oac;
            wwh = SqlQuery.WarehouseQuery(ct.ID);
            mc.wh = wwh;
            ocw = SqlQuery.WarehouseLogQuery(ct.ID);
            mc.ocw = ocw;
            ppr = SqlQuery.ProductionerQuery(ct.ID);
            mc.pr = ppr;
            opr = SqlQuery.ProductionerLogQuery(ct.ID);
            mc.opr = opr;
            ppt = SqlQuery.ProjectQuery(ct.ID);
            mc.pt = ppt;
            opt=mc.opt = SqlQuery.ProjectLogQuery(ct.ID);
            ssl = SqlQuery.SalesQuery(ct.ID);
            mc.sl = ssl;
            osl= mc.osl = SqlQuery.SalesLogQuery(ct.ID);
            mc.ct = SqlQuery.ContractVQuery(ct.ID)[0];
            MGrid.DataContext = mc;


        }

        private void btn_InsertContract_Click(object sender, RoutedEventArgs e)
        {
            InsertContract ic = new InsertContract();
            ic.Show();
            ic.mw = this;
           // this.oct = ic.oct;
        }

        private void btn_deleteContract_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("你确定要删除本合同吗？", "提示", MessageBoxButton.YesNo, MessageBoxImage.Asterisk, MessageBoxResult.No, MessageBoxOptions.None);
            if (result == MessageBoxResult.Yes)
            {
               

                MessageBox.Show("删除成功！");
                //listView_Contract.SelectedIndex;
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

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
