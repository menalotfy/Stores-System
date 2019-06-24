using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeProject
{
    public class Employee
    {

        public int ID { get; set; }
        public string NationalId { get; set; }
        public string EmployeeName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public float Salary { get; set; }
        public ICollection<GeneralBill> generalBills { get; set; }
        public ICollection<SupplierBill> supplierBills { get; set; }
        public bool Status { get; set; }
    }
}
