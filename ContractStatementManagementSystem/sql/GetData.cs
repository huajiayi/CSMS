using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
    public class GetData
    {
        public static ObservableCollection<Warehouse> WarehouseGet(WarehouseLog w, ObservableCollection<Warehouse> ow)
        {
            SqlQuery.insert(w);
            //ObservableCollection <WarehouseLog> owl= SqlQuery.WarehouseLogQuery(w.ContractID);
            ObservableCollection<ProductionerLog> op = SqlQuery.ProductionerLogQuery(w.ContractID);
            //ObservableCollection<Warehouse> ow =  SqlQuery.WarehouseQuery(w.ContractID);
            //var a = owl.Sum(x => x.Shipments);
            var b = op.Sum(x => x.ProductionCount);
            //Warehouse wah = new Warehouse();
            //wah.ContractID = w.ContractID;
            //wah.ID = ow[0].ID;
            ow[0].ShippedCount +=w.Shipments;
            ow[0].Reserves -= w.Shipments;
            ow[0].NoShippedCount -= w.Shipments;
            SqlQuery.updata(ow[0]);
            //ObservableCollection<object> ob = new ObservableCollection<object>();
            //ob.Add(owl);
            //ob.Add();
            return ow;

        }
        public static ObservableCollection<Productioner> ProductionerGet(ProductionerLog pl, ObservableCollection<Productioner> op )
        {
            SqlQuery.insert(pl);
            //var a = opl.Sum(x => x.ProductionCount);
            op[0].TotalProduct += pl.ProductionCount;
            op[0].NoTotalProduct -=pl.ProductionCount;
            SqlQuery.updata(op[0]);
            return op;
        }
        public static ObservableCollection<Sales> SalesGet(SalesLog sl, ObservableCollection<Sales> os) {
            SqlQuery.insert(sl);
            os[0].AmountCollection += sl.AmountCollection;
            os[0].NoAmountCollection -= sl.AffirmIncomeAmount;
            os[0].SubAffirmIncomeAmount += sl.AffirmIncomeAmount;
            os[0].SubInvoiceAmount += sl.InvoiceAmount;
            os[0].SubInvoiceCount += sl.InvoiceCount;
            SqlQuery.updata(os[0]);
            return os;
        }
        public static ObservableCollection<Project> ProjectGet(ProjectLog pjl, ObservableCollection<Project> opj) {
            SqlQuery.insert(pjl);
            opj[0].DompletedDate = pjl.DompletedDate;
            opj[0].DompletedAcceptanceDate = pjl.DompletedAcceptanceDate;
            opj[0].ProjectStart = pjl.ProjectStart;
            SqlQuery.updata(opj[0]);
            return opj;
        }
        public static ObservableCollection<Accountant> AccountantGet(AccountantLog al, ObservableCollection<Accountant> a ) {
            SqlQuery.insert(al);
            
            a[0].SubAffirmIncomeAmount += al.AffirmIncomeAmount;
            a[0].AffirmIncomeGist = al.AffirmIncomeGist;
            a[0].SubInvoiceAmount += al.InvoiceAmount;
            a[0].SubInvoiceCount += al.InvoiceCount;
            a[0].SubManufacturing_Costs += al.Manufacturing_Costs;
            a[0].SubMaterial += al.Material;
            a[0].Subtotal += al.Subtotal;
            a[0].Subworker += al.worker;
            a[0].AvgGrossrofitMargin = al.GrossrofitMargin;
            a[0].NoAffirmIncomeAmount -= al.AffirmIncomeAmount;
            a[0].SubCost += al.Cost;
            return a;
        }
        public static void first (ContractNameT ct,Contract_Data cd){
            Accountant ac = new Accountant();
            ac.ID = Guid.NewGuid();
            ac.ContractID = ct.ID;
            ac.NoAffirmIncomeAmount = ct.Contract_Amount;
            ac.SubAffirmIncomeAmount = 0;
            ac.SubInvoiceAmount = 0;
            ac.SubInvoiceCount = 0;
            ac.SubManufacturing_Costs = 0;
            ac.SubMaterial = 0;
            ac.Subtotal = 0;
            ac.Subworker = 0;
            ac.SubCost = 0;
            Productioner pr = new Productioner();
            pr.ContractID = ct.ID;
            pr.NoTotalProduct = ct.Count;
            pr.TotalProduct = 0;
            pr.ID = Guid.NewGuid();
            Project pt = new Project();
            pt.ID = Guid.NewGuid();
            pt.ContractID = ct.ID;
            Sales sl = new Sales();
            sl.ID = Guid.NewGuid();
            sl.ContractID = ct.ID;
            sl.AmountCollection = 0;
            sl.NoAmountCollection = ct.Contract_Amount;
            sl.SubAffirmIncomeAmount = 0;
            sl.SubInvoiceCount = 0;
            sl.SubInvoiceAmount = 0;
            Warehouse wh = new Warehouse();
            wh.ID = Guid.NewGuid();
            wh.ContractID = ct.ID;
            wh.NoShippedCount = ct.Count;
            wh.Reserves = 0;
            wh.ShippedCount = 0;
            SqlQuery.Contractinsert(ct,ac,pr,pt,sl,wh,cd);
            

         }
               
    }
}
