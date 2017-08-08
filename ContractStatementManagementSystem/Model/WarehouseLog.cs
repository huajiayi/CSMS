using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class WarehouseLog
    {
       public Guid ID { get; set; }
       public Guid DepartmentID { get; set; } //部门id
       public double Shipments { get; set; } //发货量
       public string ShippedDate { get; set; } //发货日期
       public string LogDate { get; set; } //日志日期
       public string Name { get; set; } //操作人
       public Guid ContractID { get; set; } //合同id
       public string LogName { get; set; } //日志名
       
        public WarehouseLog() { }
        public WarehouseLog(Guid ID, Guid DepartmentID, double Shipments, string ShippedDate, string LogDate ,string Name ) {
            this.ID = ID;
            this.DepartmentID = DepartmentID;
            this.Shipments = Shipments;
            this.ShippedDate = ShippedDate;
            this.LogDate = LogDate;
            this.Name=Name;
        }
    }
}
