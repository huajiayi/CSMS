using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractStatementManagementSystem
{
    public class SqlQuery
    {
        public static string @string = ConfigurationManager.ConnectionStrings["MHCC_sales"].ConnectionString;
        public static void Contractinsert( ContractNameT ct,Accountant ac,Productioner pr,Project pj,Sales sa,Warehouse wh) {
            using (var conn = new SqlConnection(@string))
            {
                string sql0 = String.Format(@"insert into ContractNameT (ID,Customer,Contract_Type,Contract_Amount,Count,Contract_Number,Contract_Date,ContractName) values('{7}','{0}','{1}',{2},{3},'{4}','{5}','{6}');", ct.Customer, ct.Contract_Type, ct.Contract_Amount, ct.Count, ct.Contract_Number, ct.Contract_Date,ct.ContractName,ct.ID);
                //string sql1 = String.Format(@"insert into Contract_Data (ID,Service,Contract_ID) values('{0}','{1}','{2}');", cd.ID,cd.Service, cd.Contract_ID);
                string sql2 = String.Format(@"insert into Accountant (ID,ContractID,AffirmIncomeGist,SubAffirmIncomeAmount,SubInvoiceCount,SubInvoiceAmount,SubCost,SubMaterial,Subworker,SubManufacturing_Costs,AvgGrossrofitMargin,NoAffirmIncomeAmount,Subtotal) values('{0}','{1}','{2}',{3},{4},{5},{6},{7},{8},{9},{10},{11},{12});", ac.ID,ac.ContractID,ac.AffirmIncomeGist,ac.SubAffirmIncomeAmount, ac.SubInvoiceCount, ac.SubInvoiceAmount, ac.SubCost, ac.SubMaterial, ac.Subworker, ac.SubManufacturing_Costs, ac.AvgGrossrofitMargin,ac.NoAffirmIncomeAmount,ac.Subtotal);
                string sql3 = String.Format(@"insert into Productioner (ID,ContractID,TotalProduct,NoTotalProduct) values('{0}','{1}',{2},{3});",pr.ID,pr.ContractID,pr.TotalProduct,pr.NoTotalProduct);
                string sql4 = String.Format(@"insert into Project (ID,ContractID,DompletedDate,DompletedAcceptanceDate) values('{0}','{1}','{2}','{3}');", pj.ID,pj.ContractID,pj.DompletedDate,pj.DompletedAcceptanceDate);
                string sql5 = String.Format(@"insert into Sales (ID,ContractID,AmountCollection,NoAmountCollection,SubAffirmIncomeAmount,SubInvoiceCount,SubInvoiceAmount) values('{0}','{1}',{2},'{3}',{4},{5},{6});", sa.ID,sa.ContractID,sa.AmountCollection,sa.NoAmountCollection,sa.SubAffirmIncomeAmount,sa.SubInvoiceCount,sa.SubInvoiceAmount);
                string sql6 = String.Format(@"insert into Warehouse (ID,ContractID,Reserves,ShippedCount,NoShippedCount) values('{0}','{1}',{2},{3},{4});",wh.ID,wh.ContractID,wh.Reserves,wh.ShippedCount,wh.NoShippedCount);
                string[] sqls = { sql0,  sql2, sql3, sql4, sql5,sql6 };
                string s=string.Concat(sqls);
                conn.Open();
                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.ExecuteNonQuery();

            }
        }
        public static ObservableCollection<ContractNameT> ContractQuery() {
            string sql = String.Format(@"SELECT * FROM [ContractNameT]");
            ObservableCollection<ContractNameT> ww = new ObservableCollection<ContractNameT>(Query<ContractNameT>(sql));
            return ww;
        }
        public static ObservableCollection<ContractNameT> ContractVQuery(Guid id)
        {
            string sql = String.Format(@"SELECT * FROM [ContractNameT] where ID='{0}'",id);
            ObservableCollection<ContractNameT> ww = new ObservableCollection<ContractNameT>(Query<ContractNameT>(sql));
            return ww;
        }
        public static ObservableCollection<Productioner> ProductionerQuery(Guid id){
             string sql = String.Format(@"SELECT * FROM [Productioner] where ContractID='{0}'", id);
             ObservableCollection<Productioner> ww = new ObservableCollection<Productioner>(Query<Productioner>(sql));
             return ww;
            }
        public static ObservableCollection<ProductionerLog> ProductionerLogQuery(Guid id)
        {
            string sql = String.Format(@"SELECT * FROM [ProductionerLog] where ContractID='{0}'", id); 
            ObservableCollection<ProductionerLog> ww = new ObservableCollection<ProductionerLog>(Query<ProductionerLog>(sql));
            return ww;
        }
        public static ObservableCollection<Warehouse> WarehouseQuery(Guid id)
        {
            string sql = String.Format(@"SELECT * FROM [Warehouse] where ContractID='{0}'", id);
            ObservableCollection<Warehouse> ww = new ObservableCollection<Warehouse>(Query<Warehouse>(sql));
            return ww;
        }
        public static ObservableCollection<WarehouseLog> WarehouseLogQuery (Guid id)
        {
            string sql = String.Format(@"SELECT * FROM [WarehouseLog] where ContractID='{0}'", id);
           
           
            ObservableCollection<WarehouseLog> ww = new ObservableCollection<WarehouseLog>(Query<WarehouseLog>(sql));
            return ww;
        }
        public static ObservableCollection<Sales> SalesQuery(Guid id)
        {
            string sql = String.Format(@"SELECT * FROM [Sales] where ContractID='{0}'", id);
            ObservableCollection<Sales> ww = new ObservableCollection<Sales>(Query<Sales>(sql));
            return ww;
        }
        public static ObservableCollection<SalesLog> SalesLogQuery(Guid id)

        {
            string sql = String.Format(@"SELECT * FROM [SalesLog] where ContractID='{0}'", id);
            ObservableCollection<SalesLog> ww = new ObservableCollection<SalesLog>(Query<SalesLog>(sql));
            return ww;
        }
        public static ObservableCollection<Contract_Data> ContractDataQuery(Guid id)

        {
            string sql = String.Format(@"SELECT * FROM [Contract_Data] where Contract_ID='{0}'", id);
            ObservableCollection<Contract_Data> ww = new ObservableCollection<Contract_Data>(Query<Contract_Data>(sql));
            return ww;
        }
        public static ObservableCollection<ContractNameT> ContractByIDQuery(Guid id)
        {
            string sql = String.Format(@"SELECT * FROM [Contract_Data] where ID='{0}'", id);
            ObservableCollection<ContractNameT> ww = new ObservableCollection<ContractNameT>(Query<ContractNameT>(sql));
            return ww;
        }
        public static ObservableCollection<Project> ProjectQuery(Guid id)
        {
            string sql = String.Format(@"SELECT * FROM [Project] where ContractID='{0}'", id);
            ObservableCollection<Project> ww = new ObservableCollection<Project>(Query<Project>(sql));
            return ww;
        }
        public static ObservableCollection<ProjectLog> ProjectLogQuery(Guid id)
        {
            string sql = String.Format(@"SELECT * FROM [ProjectLog] where ContractID='{0}'", id);
            ObservableCollection<ProjectLog> ww = new ObservableCollection<ProjectLog>(Query<ProjectLog>(sql));
            return ww;
        }
        public static ObservableCollection<Accountant> AccountantQuery(Guid id)
        {
            string sql = String.Format(@"SELECT * FROM [Accountant] where ContractID='{0}'", id);
            
            ObservableCollection<Accountant> ww =new ObservableCollection<Accountant>(Query<Accountant>(sql));
            return ww;
        }
        public static ObservableCollection<AccountantLog> AccountantLogQuery(Guid id)
        {
            string sql = String.Format(@"SELECT * FROM [Accountantlog] where ID='{0}'", id);
            ObservableCollection<AccountantLog> ww = new ObservableCollection<AccountantLog>(Query<AccountantLog>(sql));
            return ww;
        }
        public static void insert( object ob)
        {
            using (var conn = new SqlConnection(@string))
            {
                if (ob is ProjectLog) {
                    ProjectLog a = (ProjectLog)ob;
                    string sql0 = String.Format("insert into ProjectLog(ID,DepartmentID,DompletedDate,DompletedAcceptanceDate,LogDate,Name,ContractID,LogName,ServiceID,Service,ProjectStart) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", a.ID,a.DepartmentID,a.DompletedDate,a.DompletedAcceptanceDate,a.LogDate,a.Name,a.ContractID,a.LogName,a.ServiceID,a.Service,a.ProjectStart);
                    string s = string.Concat(sql0);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(s, conn);
                    cmd.ExecuteNonQuery();
                }
                if (ob is AccountantLog)
                {
                    AccountantLog a = (AccountantLog)ob; 
                    string sql0 = String.Format("insert into AccountantLog(ID,DepartmentID,AffirmIncomeGist,AffirmIncomeAmount,InvoiceCount,InvoiceAmount,Cost,Material,worker,Manufacturing_Costs,Subtotal,GrossrofitMargin,ContractID,LogDate,LogName,ServiceID,Name,Service) values('{0}','{1}','{2}',{3},{4},{5},{6},{7},{8},{9},{10},{11},'{12}','{13}','{14}','{15}','{16}','{17}')", a.ID,a.DepartmentID,a.AffirmIncomeGist,a.AffirmIncomeAmount,a.InvoiceCount,a.InvoiceAmount,a.Cost,a.Material,a.worker,a.Manufacturing_Costs,a.Subtotal,a.GrossrofitMargin,a.ContractID,a.LogDate,a.LogName,a.ServiceID,a.Name,a.Service);
                    string s = string.Concat(sql0);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(s, conn);
                    cmd.ExecuteNonQuery();
                }
                if (ob is ProductionerLog)
                {
                    ProductionerLog a = (ProductionerLog)ob;
                    string sql0 = String.Format("insert into ProductionerLog(ID,DepartmentID,ProductionCount,ProductionDate,LogDate,ContractID,LogName,Name) values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}')",
                        a.ID, a.DepartmentID, a.ProductionCount, a.ProductionDate, a.LogDate, a.ContractID,a.LogName,a.Name);
                    string s = string.Concat(sql0);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(s, conn);
                    cmd.ExecuteNonQuery();
                }
                if (ob is WarehouseLog)
                {
                    WarehouseLog a = (WarehouseLog)ob;
                    string sql0 = String.Format("insert into WarehouseLog(ID,DepartmentID,Shipments,ShippedDate,LogDate,ContractID,LogName,Name) values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}')",
                        a.ID, a.DepartmentID, a.Shipments, a.ShippedDate, a.LogDate, a.ContractID, a.LogName, a.Name);
                    string s = string.Concat(sql0);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(s, conn);
                    cmd.ExecuteNonQuery();
                }
                if (ob is SalesLog)
                {
                    SalesLog a = (SalesLog)ob;
                    string sql0 = String.Format("insert into SalesLog(ID,DepartmentID,ReturnDate,InvoiceDate,AffirmIncomeDate,AffirmIncomeAmount,InvoiceCount,InvoiceAmount,AmountCollection,AffirmIncomeGist,ContractID,LogDate,LogName,ServiceID,Name,Service) values('{0}','{1}','{2}','{3}','{4}',{5},{6},{7},{8},'{9}','{10}','{11}','{12}','{13}','{14}','{15}')",a.ID, a.DepartmentID, a.ReturnDate, a.InvoiceDate, a.AffirmIncomeDate,a.AffirmIncomeAmount,a.InvoiceCount,a.InvoiceAmount,a.AmountCollection,a.AffirmIncomeGist,a.ContractID,a.LogDate,a.LogName,a.ServiceID,a.Name,a.Service);
                    string s = string.Concat(sql0);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(s, conn);
                    cmd.ExecuteNonQuery();
                }
                if (ob is Contract_Data)
                {
                    Contract_Data a = (Contract_Data)ob;
                    string sql0 = String.Format("insert into Contract_Data(ID,Service,Contract_ID) values('{0}','{1}','{2}')", a.ID,a.Service,a.Contract_ID);
                    string s = string.Concat(sql0);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(s, conn);
                    cmd.ExecuteNonQuery();
                }

            }

        }
        public static void updata( object ob) {
            using (var conn = new SqlConnection(@string))
            {

                if (ob is Accountant)
                {
                    Accountant c = (Accountant)ob;
                    string sql0 = String.Format(@"update Accountant set ID='{0}',ContractID='{1}',AffirmIncomeGist='{2}', SubAffirmIncomeAmount={3}, SubInvoiceCount={4},SubInvoiceAmount={5},SubCost={6},SubMaterial={7},Subworker={8},SubManufacturing_Costs={9},Subtotal={10},AvgGrossrofitMargin={11},NoAffirmIncomeAmount={12} where ID='{0}'",
                        c.ID, c.ContractID, c.AffirmIncomeGist,c.SubAffirmIncomeAmount,c.SubInvoiceCount,c.SubInvoiceAmount, c.SubCost,c.SubMaterial,c.Subworker,c.SubManufacturing_Costs,c.Subtotal,c.AvgGrossrofitMargin,c.NoAffirmIncomeAmount);

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql0, conn);
                    cmd.ExecuteNonQuery();

                }

                if (ob is Productioner)
                {
                    Productioner c = (Productioner)ob;
                    string sql0 = String.Format(@"update Productioner set ID='{0}',ContractID='{1}',TotalProduct={2}, NoTotalProduct={3} where ID='{0}'", c.ID, c.ContractID, c.TotalProduct, c.NoTotalProduct);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql0, conn);
                    cmd.ExecuteNonQuery();
                }
                if (ob is Sales) {
                    Sales c = (Sales)ob;
                    string sql0 = String.Format(@"update Sales set ID='{0}',ContractID='{1}',AmountCollection={2}, NoAmountCollection={3}, SubAffirmIncomeAmount={4},SubInvoiceCount={5},SubInvoiceAmount={6}  where ID='{0}'",c.ID, c.ContractID, c.AmountCollection, c.NoAmountCollection,c.SubAffirmIncomeAmount,c.SubInvoiceCount, c.SubInvoiceAmount);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql0, conn);
                    cmd.ExecuteNonQuery();
                }
                    if (ob is Warehouse)
                    {
                    Warehouse c = (Warehouse)ob;
                        string sql0 = String.Format(@"update Warehouse set ID='{0}',ContractID='{1}',Reserves={2},ShippedCount={3}, NoShippedCount={4} where ID='{0}'", c.ID, c.ContractID, c.Reserves,c.ShippedCount,c.NoShippedCount);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(sql0, conn);
                       cmd.ExecuteNonQuery();

                }
                if (ob is Project)
                {
                    Project c = (Project)ob;
                    string sql0 = String.Format(@"update Project set ID='{0}',ContractID='{1}',DompletedDate='{2}',DompletedAcceptanceDate='{3}',ProjectStart='{4}' where ID='{0}'", c.ID, c.ContractID, c.DompletedDate, c.DompletedAcceptanceDate,c.ProjectStart);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql0, conn);
                    cmd.ExecuteNonQuery();

                }

            }
            }

        public static IEnumerable<T> Query<T>(string sql, object parameter = null)
        {

            using (var conn = new SqlConnection(@string))
            {
                conn.Open();

                return conn.Query<T>(sql, parameter);
            }

        }
    }
}
