using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
   public class MClass
    {
        public ObservableCollection<Accountant> ac{get;set;}
        public ObservableCollection<AccountantLog> oac{get;set;}
        public ObservableCollection<Productioner> pr { get; set; }
        public ObservableCollection<ProductionerLog> opr { get; set; }
        //public ObservableCollection<Project> pt { get; set; }
        public ObservableCollection<ProjectLog> opt { get; set; }
        public ObservableCollection<Project_data> pt { get; set; }
        public ObservableCollection<Sales> sl { get; set; }
        public ObservableCollection<SalesLog> osl { get; set; }
        public ObservableCollection<Warehouse> wh { get; set; }
        public ObservableCollection<WarehouseLog> ocw { get; set; }
        public ContractNameT ct { get; set; }
       // public ObservableCollection<Contract_Data> ocd { get; set; }
    }
}
