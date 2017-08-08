using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class Accountant
    {
      public Guid ID { get; set; }
      public Guid ContractID { get; set; } //合同名
      public string AffirmIncomeGist { get; set; } //最新确认收入依据 
      public decimal SubAffirmIncomeAmount { get; set; } //总确认收入金额
      public double SubInvoiceCount { get; set; } //总已开票数
      public decimal SubInvoiceAmount { get; set; } //总已开票金额
      public double SubCost { get; set; } //总已结算成本数量
      public decimal SubMaterial { get; set; } //总直接材料
      public decimal Subworker { get; set; } //总工人成本
      public decimal SubManufacturing_Costs { get; set; } //总制造费用
      public decimal Subtotal { get; set; } //总计
      public double AvgGrossrofitMargin { get; set; } //最新毛利
       public decimal NoAffirmIncomeAmount { get; set; }//未收款项

    }
}
