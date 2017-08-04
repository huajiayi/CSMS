using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
   public class ProductionerLog
    {
       public int ID { get; set; }
       public int DepartmentID { set; get; } //部门id
       public double ProductionCount { set; get; } //生产量
       public string ProductionDate { set; get; } //生产日期
       public string LogDate { set; get; } //日志日期
       public string Name { set; get; } //日志名
    }   
}
