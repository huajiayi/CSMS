﻿
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
using System.ComponentModel;

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
        public ObservableCollection<Project_data> ppt { get; set; }
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
            if (ct == null)
            {
                listView_Contract.SelectedIndex = 0;
                ct = (ContractNameT)listView_Contract.SelectedItem;
            }
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
            ppt = SqlQuery.Project_dataQuery(ct.ID);
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
            ic.mw = this;
      
            ic.ShowDialog();
           // this.oct = ic.oct;
        }

        private void btn_deleteContract_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("你确定要删除本合同吗？", "提示", MessageBoxButton.YesNo, MessageBoxImage.Asterisk, MessageBoxResult.No, MessageBoxOptions.None);
            if (result == MessageBoxResult.Yes)
            {

                SqlQuery.DeleteContract(ct.ID);
                oct.Remove(ct);
                MessageBox.Show("删除成功！");
                //listView_Contract.SelectedIndex;
            }
        }

        private void btn_InsertService_Click(object sender, RoutedEventArgs e)
        {
            InsertService ins = new InsertService();
            ins.mw = this;
            ins.type = "f";
            ins.ShowDialog();
        }

        private void btn_Insert_Click(object sender, RoutedEventArgs e)
        {
            Button btn_Insert = (Button)sender;
            switch (btn_Insert.Name)
            {
                case "btn_InsertWarehouse":
                    InsertWarehouse iw = new InsertWarehouse();
                    iw.mw = this;
                    iw.ShowDialog();
                    break;
                case "btn_InsertAccountant":
                    InsertAccountant ia = new InsertAccountant(this);
                    ia.ShowDialog();
                    break;
                case "btn_InsertProduction":
                    InsertProduction ip = new InsertProduction();
                    ip.mw = this;
                    ip.ShowDialog();
                    break;
                case "btn_InsertProject":
                    InsertProject ipj = new InsertProject(this);
                    ipj.ShowDialog();
                    break;
                case "btn_InsertSales":
                    InsertSales isl = new InsertSales(this);
                    isl.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void btn_EditService_Click(object sender, RoutedEventArgs e)
        {
            InsertService ins = new InsertService();
            ins.type="edit";
            ins.mw = this;
            ins.ShowDialog();
        }

        private void btn_DeleteService3_Click(object sender, RoutedEventArgs e)
        {
            Contract_Data cd = (Contract_Data)ListViewSerices.SelectedItem;
            ocd.Remove(cd);
            SqlQuery.DeleteService(cd.ID);
            int a = opt.Count;
            int b = ppt.Count;
            int c = osl.Count;
            int ee = oac.Count;
            for (int i=a-1;i>=0;i--) {
                if (opt[i].ServiceID == cd.ID)
                {

                    opt.Remove(opt[i]);
                }
            }
            for (int i = b-1; i >=0 ; i--)
            {
                if (ppt[i].ServiceID == cd.ID)
                {
                    ppt.Remove(ppt[i]);
                }
            }
            for (int i = c-1; i>=0; i--)
            {
                if (osl[i].ServiceID == cd.ID)
                {
                    osl.Remove(osl[i]);
                }
            }
            for (int i = ee - 1; i >= 0; i--)
            {
                if (oac[i].ServiceID == cd.ID)
                {
                    oac.Remove(oac[i]);
                }
            }



            //opt.Remove((opt.FirstOrDefault<ProjectLog>(x => x.ServiceID == cd.ID)));
            //osl.Remove((osl.FirstOrDefault<SalesLog>(x => x.ServiceID == cd.ID)));
            //oac.Remove((oac.FirstOrDefault<AccountantLog>(x => x.ServiceID == cd.ID)));


        }
    }
}
