using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
    public class Warehouse : INotifyPropertyChanged
    {
       public Guid ID { set; get; }
       public Guid ContractID { set; get; } //合同id
       private double _reserves;
       public double Reserves //库存量
       {
           get { return _reserves; }

           set
           {
               _reserves = value;

               if (PropertyChanged != null)
               {
                   PropertyChanged(this, new PropertyChangedEventArgs("Reserves"));

               }
           } 
       }
       public double ShippedCount { set; get; }  //已发货量
       public double NoShippedCount { set; get; } //未发货量
       public Warehouse() { }
       public Warehouse(Guid ID, Guid ContractID, double Reserves, double ShippedCount, double NoShippedCount) {
            this.ID = ID;
            this.ContractID=ContractID;
            this.Reserves = Reserves;
            this.ShippedCount = ShippedCount;
            this.NoShippedCount = NoShippedCount;
        }
       public event PropertyChangedEventHandler PropertyChanged;

    }
}
