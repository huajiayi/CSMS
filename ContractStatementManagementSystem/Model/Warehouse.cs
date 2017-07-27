using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
    public class Warehouse //仓库

    {
        public double Reserves { set; get; } //储量
        public double DemandCount { get; set; } //需求量
        public double Shipments { get; set; } //发货量 
        public double ShippedCount { get; set; } //以发货量
        public double NoShippedCount { get; set; } //未发货量
        public DateTime ShippedDate { get; set; } //发货日期
        public string ContractName { get; set; } //公司名
        public string ProjectName { get; set; }  //项目名

    }
}
