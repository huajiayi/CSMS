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
        public MainWindow mw;
        public InsertProject(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
            cb_Service.ItemsSource = mw.ocd;
            cb_Service.SelectedIndex = 0;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string logName = tb_LogName.Text.ToString().Trim();
            Contract_Data item = (Contract_Data)cb_Service.SelectedItem;
            string service = item.Service;
            string constructionDate;
            if (string.IsNullOrEmpty(tb_ConstructionDate.ToString()))
            {
                constructionDate = "";
            }
            else
            {
                constructionDate = DateTime.Parse(tb_ConstructionDate.ToString().Trim()).ToShortDateString();
            }
            string dompletedDate;
            if (string.IsNullOrEmpty(tb_DompletedDate.ToString()))
            {
                dompletedDate = "";
            }
            else
            {
                dompletedDate = DateTime.Parse(tb_DompletedDate.ToString().Trim()).ToShortDateString();
            }
            string dompletedAcceptanceDate;
            if (string.IsNullOrEmpty(tb_DompletedAcceptanceDate.ToString()))
            {
                dompletedAcceptanceDate = "";
            }
            else
            {
                dompletedAcceptanceDate = DateTime.Parse(tb_DompletedAcceptanceDate.ToString().Trim()).ToShortDateString();
            }

            if (string.IsNullOrEmpty(logName) || string.IsNullOrEmpty(service))
            {
                MessageBox.Show("日志名和服务款项不能为空");
            }
            else
            {
                ProjectLog p = new ProjectLog();
                p.ID = Guid.NewGuid();
                p.ContractID = mw.ct.ID;
                p.DepartmentID = mw.ppt[0].ID;
                p.ProjectStart = constructionDate;
                p.DompletedDate = dompletedDate;
                p.DompletedAcceptanceDate = dompletedAcceptanceDate;
                p.LogDate = DateTime.Now.ToString();
                p.LogName = logName;
                p.Service = service;
                mw.opt.Add(p);
                mw.ppt[0] = GetData.ProjectGet(p, mw.ppt)[0];
                MessageBox.Show("操作成功！");
                this.Close();
            }
            
        }
    }
}
