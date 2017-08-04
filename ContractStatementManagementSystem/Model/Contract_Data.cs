using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
   public class Contract_Data
    {
       public int ID { get; set; } 
       public string Service { get;set;}// 服务项目
       public Guid Contract_ID { get; set; }//合同id
    }
}
