using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
    public class Productioner
    {
       public Guid ID { get; set; }
       public Guid ContractID { get; set; } //合同id
       public double TotalProduct { get; set; } //已生产量
       public double NoTotalProduct { get; set; } //未生产量
        
        
    }
}
