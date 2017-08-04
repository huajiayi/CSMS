using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
   public class ProjectLog
    {
       public  int ID { set; get; } 
       public  int DepartmentID { set; get; } //部门id
       public string ConstructionDate { get; set; } //施工日期
       public  string DompletedDate { set; get; } //竣工日期
       public  string DompletedAcceptanceDate { set; get; } //竣工验收单日期
       public  string LogDate { set; get; } //日志日期
       public  string Name { set; get; }//操作人
       public  int ContractID { set; get; } //合同id
       public  string LogName { set; get; }//日志名
       public  int ServiceID { set; get; } //服务名

}
}
