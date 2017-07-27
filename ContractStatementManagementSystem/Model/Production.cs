using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
    public class Production //生产部
    {
        public DateTime ProductionDate { get; set; } //生产日期
        public double DemandCount { get; set; } //需求量
        public double ProductionCount { get; set; } //生产量
        public double TotalProduct { get; set; } //已生产量
        public double NOTotalProduct { get; set; } //未生产量
        public string ContractName { get; set; } //公司名
        public string projectName { get; set; }  //项目名

    }
}
