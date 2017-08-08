using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class Warehouse
    {
       public Guid ID { set; get; }
       public Guid ContractID { set; get; } //合同id
       public double Reserves { set; get; } //仓储
       public double ShippedCount { set; get; }  //已发货量
       public double NoShippedCount { set; get; } //未发货量
       public Warehouse() { }
       public Warehouse(Guid ID, Guid ContractID, double Reserves, double ShippedCount, double NoShippedCount) {
            this.ID = ID;
            this.ContractID=ContractID;
            this.Reserves = Reserves;
            this.ShippedCount = ShippedCount;
            this.NoShippedCount = NoShippedCount;
        } 

    }
}
