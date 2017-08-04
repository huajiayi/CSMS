using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
   public class SalesLog
    {
       public string LogName { get; set; } //日志名
       public string Service { get; set; } //服务款项
       public decimal Amount { get; set; } //收款金额
       public string Operator { get; set; } //操作人
       public string OperationDate { get; set; } //操作日期
    }
}
