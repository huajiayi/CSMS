using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
   public class AccountantLog
    {
      public int ID { get; set; }
      public int DepartmentID { get; set; }
      public string AffirmIncomeGist { get; set; } //确认收入依据
      public string AffirmIncomeAmount { get; set; } //确认收入金额
      public double InvoiceCount { get; set; } //已开票数
      public decimal InvoiceAmount { get; set; } //已开票金额
      public decimal Cost { get; set; } //已结算成本数量
      public decimal Material { get; set; } //直接材料
      public decimal worker { get; set; } //工人成本
      public decimal Manufacturing_Costs { get; set; } //制造费用
      public decimal Subtotal { get; set; } //小计
      public decimal GrossrofitMargin { get; set; } //毛利
      public int ContractID { get; set; } //合同id
      public string LogDate { get; set; } //日志日期
      public string LogName { get; set; } //日志名
      public int ServiceID { get; set; } //服务id

    }
}
