using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class Project_data : INotifyPropertyChanged
    {
      public Guid ID { get; set; }
         string dompletedDate { get; set; }
        public string DompletedDate //库存量
        {
            get { return dompletedDate; }

            set
            {
                dompletedDate = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DompletedDate"));

                }
            }
        }
         string dompletedAcceptanceDate { get; set; }
        public string DompletedAcceptanceDate //库存量
        {
            get { return dompletedAcceptanceDate; }

            set
            {
                dompletedAcceptanceDate = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DompletedAcceptanceDate"));

                }
            }
        }
        public Guid ServiceID { get; set; }
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
        string projectStart { get; set; }
        public string ProjectStart //库存量
        {
            get { return projectStart; }

            set
            {
                projectStart = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(" ProjectStart"));

                }
            }
        }
        public Guid ContractID { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
