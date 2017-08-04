using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem.Model
{
   public class Sales
    {
       public Guid Contract_ID { get; set; } //合同ID
       public string ContractName { get; set; } //合同名称
       public decimal Contract_Amount { get; set; } //总金额
       public decimal AmountCollection { get; set; } //已收金额
       public decimal NoAmountCollection { get; set; } //未收金额
       public ObservableCollection<SalesLog> SalesLogs { get; set; }

    }
}
