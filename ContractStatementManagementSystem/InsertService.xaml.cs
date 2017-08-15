
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
        public string type="f";
        public InsertService()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            Contract_Data cd =(Contract_Data) mw.ListViewSerices.SelectedItem;
            string service = tb_Service.Text.ToString().Trim();

            if (string.IsNullOrEmpty(service))
            {
                MessageBox.Show("输入值不能为空");
            }
            else
            {
                if (type.Equals("edit"))
                {
                  cd.Service = service;
                    //mw.ocd.Add(cd);
                    //if ((mw.ocd.IndexOf(mw.ocd.FirstOrDefault<Contract_Data>(x => x.ID == cd.ID))) >= 0)
                    //{
                    //   int a=mw.ocd.IndexOf(cd);
                    //   int b=mw.ocd.IndexOf(mw.ocd.FirstOrDefault<Contract_Data>(x => x.ID == cd.ID));
                    //    Contract_Data cpp = mw.ocd[b];
                    //    mw.ocd[b]=mw.ocd[a];
                    //    mw.ocd[a] = cpp;
                    //   // mw.ocd.Remove(mw.ocd.FirstOrDefault<Contract_Data>(x => x.ID == cd.ID));
                    //}
                    
                    SqlQuery.updata(cd);
                    SqlQuery.UpdataD(cd);
                    foreach (ProjectLog pg in mw.opt ) {
                        if (pg.ServiceID == cd.ID) {
                            pg.Service = cd.Service;
                        }
                    }
                    foreach (Project_data pd in mw.ppt)
                    {
                        if (pd.ServiceID == cd.ID)
                        {
                            pd.Service = cd.Service;
                        }
                    }
                    foreach (SalesLog pg in mw.osl)
                    {
                        if (pg.ServiceID == cd.ID)
                        {
                            pg.Service = cd.Service;
                        }
                    }
                    foreach (AccountantLog pg in mw.oac)
                    {
                        if (pg.ServiceID == cd.ID)
                        {
                            pg.Service = cd.Service;
                        }
                    }
                }
                else if(type.Equals("f")) {
                    Contract_Data contract_Data = new Contract_Data();
                    contract_Data.Contract_ID = mw.ct.ID;
                    contract_Data.ID = Guid.NewGuid();
                    contract_Data.Service = service;
                    mw.ocd.Add(contract_Data);
                    SqlQuery.insert(contract_Data);
                }

                //for (ProjectLog p in mw.opt)
                //{

                //}
                
                MessageBox.Show("操作成功！");
                this.Close();
            }
        }
    }
}
