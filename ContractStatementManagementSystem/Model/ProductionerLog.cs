using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class ProductionerLog
    {
       public Guid ID { get; set; }
       public Guid DepartmentID { set; get; } //部门id
       public double ProductionCount { set; get; } //生产量
       public string ProductionDate { set; get; } //生产日期
       public string LogDate { set; get; } //日志日期
       public string LogName { set; get; } //日志名
       public string Name { set; get; }//操作人
       public Guid ContractID { get; set; } //合同id
     
    }   
}
