using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace storeProject
{
    class store : DbContext
    {
        public store() : base(@"Data Source=DESKTOP-2KNRDIS\SQL2016;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog = StoreProject")

        { }
        public DbSet<Categories> categories { get; set; }
        public virtual DbSet<Products> products { get; set; }
        public virtual DbSet<ProductUnits> ProductUnits { get; set; }

        public virtual DbSet<GeneralBillDetails> GeneralBillDetails { get; set; }
        public virtual DbSet<GeneralBill> GeneralBills { get; set; }

        public virtual DbSet<Suppliers> suppliers { get; set; }
        public virtual DbSet<SalesOrder> SalesOrder { get; set; }
        public virtual DbSet<Customers> customers { get; set; }
        public virtual DbSet<Employee> employee { get; set; }
        public virtual DbSet<SupplierBillPayment> supplierBillPayment { get; set; }
        //public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<Returned> retueneds { get; set; }
        public virtual DbSet<SalesRepresentative> SalesRepresentatives { get; set; }
        public virtual DbSet<Acounts> Acounts { get; set; }
        public virtual DbSet<SalesOredersPaymment> SalesOredersPaymments { get; set; }
        public virtual DbSet<GeneralBillPayment> GeneralBillPayments { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<SalesOrderDetails> SalesOrderDetails { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<SupplierBill> SupplierBills { get; set; }
        public virtual DbSet<SuppliersBillDetails> SuppliersBillDetails { get; set; }





    }
}
