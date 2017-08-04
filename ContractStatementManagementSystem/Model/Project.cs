using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
   public class Project
    {
       public  int ID { get; set; }
       public  int ContractID { set; get; } //合同日期
       public  string DompletedDate { get; set; } //竣工日期
       public  string DompletedAcceptanceDate { get; set; } //竣工验收日期
    }
}
