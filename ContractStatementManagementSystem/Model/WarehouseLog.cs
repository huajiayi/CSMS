using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
   public class WarehouseLog
    {
       public Guid ID { get; set; }
       public int DepartmentID { get; set; } //部门id
       public double Shipments { get; set; } //发货量
       public string ShippedDate { get; set; } //发货日期
       public string LogDate { get; set; } //日志日期
       public string Name { get; set; } //操作人
       public int ContractID { get; set; } //合同id
       public string LogName { get; set; } //日志名
    }
}
