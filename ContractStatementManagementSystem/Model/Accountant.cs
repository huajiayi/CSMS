using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
     public class Accountant //会计
    {
        public string AffirmIncomeGist { get; set; } //确认收入依据
        public decimal ContractAmount { get; set; } //合同金额
        public decimal AffirmIncomeAmount { get; set; } //确认收入金额
        public double InvoiceCount { get; set; } //已开票数
        public decimal InvoiceAmount { get; set; } //已开票金额
        public decimal Cost { get; set; } //已结算成本
        public decimal Material { get; set; } //直接材料
        public decimal Worker { get; set; } //工人成本
        public decimal Manufacturing_Costs { get; set; } //制造费用
        public decimal Subtotal { get; set; } //小计
        public decimal GrossrofitMargin { get; set; } //毛利
    }
}
