using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class Project //工程
    {
        public DateTime ShippedDate { get; set; } //发货日期
        public DateTime DompletedDate { get; set; } //竣工日期
        public DateTime DompletedAcceptanceDate { get; set; } //取得竣工验收单日期
        public string ContractName { get; set; } //公司名
        public string projectName { get; set; }  //项目名
    }
}
