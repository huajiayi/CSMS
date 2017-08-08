using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class SalesLog
    {
       public Guid ID { get; set; }
       public Guid DepartmentID { get; set; } //部门id
       public  string ReturnDate { get; set; } //回执日期
       public  string InvoiceDate { get; set; } //开具发票日期
       public  string AffirmIncomeDate { get; set; } //确认收入日期日期
       public  decimal AffirmIncomeAmount { get; set; } //确认收入金额
       public  double InvoiceCount { get; set; } //已开票数
       public  decimal InvoiceAmount { get; set; } //已开票金额
       public  decimal AmountCollection { get; set; } //已收入金额
       public  string AffirmIncomeGist { get; set; } //确认收入依据
       public Guid ContractID { get; set; } //合同id
       public  string LogDate { get; set; }  //日志日期
       public  string LogName { get; set; } //日志名
       public Guid ServiceID { get; set; } //服务名
       public string Name { get; set; }//操作人
        public string Service { get; set; }//服务
    }
}
