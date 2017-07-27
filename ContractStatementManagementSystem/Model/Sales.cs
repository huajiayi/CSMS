using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
     public class Sales //销售
    {
        public string ContractName { get; set; } //公司名
        public decimal ContractAmount { get; set; } //合同金额
        public double DemandCount { get; set; } //需求量
        public DateTime ContractDate { get; set; } //合同日期
        public DateTime ShippedDate { get; set; } //发货日期
        public DateTime ReturnDate { get; set; } //回执日期
        public DateTime InvoiceDate { get; set; } //开具发票日期
        public DateTime AffirmIncomeData { get; set; } //确认收入日期
        public decimal AffirmIncomeAmount { get; set; } //确认收入金额
        public double InvoiceCount { get; set; } //已开票数
        public decimal InvoiceAmount { get; set; } //已开票金额
        public decimal AmountCollection { get; set; } //已收入金额
        public string projectName { get; set; }  //项目名
        public string AffirmIncomeGist { get; set; } //确认收入依据
    }
}
