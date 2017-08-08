using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class Sales
    {
       public Guid ID { get; set; }
       public Guid ContractID { get; set; } //合同id
       public  decimal AmountCollection { get; set; } //已收入总金额
       public  decimal NoAmountCollection { get; set; } //未收入总金额
       //string AffirmIncomeData { get; set; }
       public  decimal SubAffirmIncomeAmount { get; set; } //确认收入金额总合
       public  double SubInvoiceCount { get; set; } //已开票数总合
       public  decimal SubInvoiceAmount { get; set; }//已开票金额综合
       

    }
}
