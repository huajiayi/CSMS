using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
  public class ContractNameT
    {
        public Guid ID { get; set; }
        public string Customer { get; set; }
        public string Contract_Type { get; set; }
        public decimal Contract_Amount { get; set; }
        public double Count { get; set; }
        public string Contract_Number { get; set; }
        public string Contract_Date { get; set; }
        public string ContractName { get; set; }
    }
}
