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
            cb_Type.SelectedIndex = 0;
            tb_TypeDate.SelectedDate = DateTime.Now;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            string logName = tb_LogName.Text.ToString().Trim();
            Contract_Data item = (Contract_Data)cb_Service.SelectedItem;
            string service = item.Service;
            ComboBoxItem item_Type = (ComboBoxItem)cb_Type.SelectedItem;
            string type = item_Type.Content.ToString();
            string typeDate;
            if (string.IsNullOrEmpty(tb_TypeDate.ToString()))
            {
                typeDate = "";
            }
            else
            {
                typeDate = DateTime.Parse(tb_TypeDate.ToString().Trim()).ToShortDateString();
            }
            string constructionDate = "";
            string dompletedDate = "";
            string dompletedAcceptanceDate = "";
            if (type.Equals("施工日期"))
            {
                lbl_Date.Text = "施工日期";
                constructionDate = typeDate;
            }
            else if (type.Equals("竣工日期"))
            {
                lbl_Date.Text = "竣工日期";
                dompletedDate = typeDate;
            }
            else if (type.Equals("取得竣工验收单日期"))
            {
                lbl_Date.Text = "取得竣工验收单日期";
                dompletedAcceptanceDate = typeDate;
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

        private void cb_Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item_Type = (ComboBoxItem)cb_Type.SelectedItem;
            string type = item_Type.Content.ToString();
            if (type.Equals("施工日期"))
            {
                lbl_Date.Text = "施工日期：";
            }
            else if (type.Equals("竣工日期"))
            {
                lbl_Date.Text = "竣工日期：";
            }
            else if (type.Equals("取得竣工验收单日期"))
            {
                lbl_Date.Text = "取得竣工验收单日期：";
            }
        }
    }
}
