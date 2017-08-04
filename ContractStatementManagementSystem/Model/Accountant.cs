using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
   public class Accountant
    {
      public int ID { get; set; }
      public int ContractID { get; set; } //合同名
      public string NewAffirmIncomeGist { get; set; } //最新确认收入依据 
      public decimal NewAffirmIncomeAmount { get; set; } //最新确认收入金额
      public double NewInvoiceCount { get; set; } //最新已开票数
      public decimal NewInvoiceAmount { get; set; } //最新已开票金额
      public decimal NewCost { get; set; } //最新已结算成本数量
      public decimal NewMaterial { get; set; } //最新直接材料
      public decimal Newworker { get; set; } //最新工人成本
      public decimal NewManufacturing_Costs { get; set; } //最新制造费用
      public decimal NewSubtotal { get; set; } //最新小计
      public decimal NewGrossrofitMargin { get; set; } //最新毛利

    }
}
