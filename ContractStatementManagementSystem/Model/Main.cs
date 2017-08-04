using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ContractStatementManagementSystem.Model
{
    public class Main
    {
        public ObservableCollection<ContractContent> ContractContents { get; set; }  //合同内容页

        public ObservableCollection<Sales> Sales { get; set; }  //销售页

    }
}
