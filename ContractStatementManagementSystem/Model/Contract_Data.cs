using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class Contract_Data : INotifyPropertyChanged
    {
       public Guid ID { get; set; }
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
        public Guid Contract_ID { get; set; }//合同id
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
