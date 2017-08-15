using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class ProjectLog : INotifyPropertyChanged
    {
       public Guid ID { set; get; } 
       public Guid DepartmentID { set; get; } //部门id
       public  string DompletedDate { set; get; } //竣工日期
       public  string DompletedAcceptanceDate { set; get; } //竣工验收单日期
       public  string LogDate { set; get; } //日志日期
       public  string Name { set; get; }//操作人
       public Guid ContractID { set; get; } //合同id
       public  string LogName { set; get; }//日志名
       public Guid ServiceID { set; get; } //服务名
        public string service;// 服务项目
        public string Service // 服务项目
        {
            get { return service; }

            set
            {
                service = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Service"));

                }
            }
        }
        public  string ProjectStart { get; set; }//施工日期
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
