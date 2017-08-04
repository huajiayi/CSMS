using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
    public class ContractContent
    {
        public Guid ID { get; set; }
        public string Customer { get; set; }
        public string Contract_Type { get; set; }
        public decimal Contract_Amount { get; set; }
        public double Count { get; set; }
        public string Contract_Number { get; set; }
        public string Contract_Date { get; set; }
        public string ContractName { get; set; }
        public ObservableCollection<Contract_Data> Contract_Datas { get; set; }  //服务条款

    }
}
