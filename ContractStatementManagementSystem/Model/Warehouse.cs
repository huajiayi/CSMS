using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
   public class Warehouse
    {
       public int ID { set; get; }
       public int ContractID { set; get; } //合同id
       public double Reserves { set; get; } //仓储
       public double ShippedCount { set; get; }  //已发货量
       public double NoShippedCount { set; get; } //未发货量


    }
}
