using storeProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreCSharpProject
{
    public partial class ReturnedFromOrderRepresentative : Form
    {
        public List<OrderDetails> OrdersDetails { get; set; } = new List<OrderDetails>();
        Orders Orders = new Orders();

        store store = new store();
        public ReturnedFromOrderRepresentative()
        {
            InitializeComponent();
        }

        private void ReturnedFromOrderRepresentative_Load(object sender, EventArgs e)
        {
            var mnd = (from MDB in store.SalesRepresentatives
                       where MDB.Employee.ID == MDB.Employee_Id
                       select new { MDB.Employee.EmployeeName, MDB.ID }).ToArray();
            CMB_MndobName.DisplayMember = "EmployeeName";
            CMB_MndobName.ValueMember = "ID";
            CMB_MndobName.DataSource = mnd;

        }

        private void btnFound_Click(object sender, EventArgs e)
        {
            var billDate = DTV_ٍSpendDate.Value;
            var salesRep = store.employee.FirstOrDefault(m => m.EmployeeName == CMB_MndobName.Text);

            Orders = (
               from s in store.Orders
               where (s.SalesRepresentative.Employee_Id == salesRep.ID /*&& s.SalesOrderDate == billDate*/ )
               select s
               ).FirstOrDefault();
            if (Orders != null)
            {
                panel1.Show();
                panel2.Show();
                DGV_SpendProducts.Show(); SaveBTn.Show();
                OrdersDetails = store.OrderDetails.Where(s => s.Order_id == Orders.ID).ToList();

                int row = 0;
                foreach (var item in OrdersDetails)
                {
                    

                    var product = new Products();
                    product = store.products.FirstOrDefault(p => p.ID == item.products_id);

                    DGV_SpendProducts.Rows[row].Cells[3].Value = product.ID.ToString();
                    DGV_SpendProducts.Rows[row].Cells[2].Value = product.ProductName.ToString();
                    DGV_SpendProducts.Rows[row].Cells[0].Value = product.Price_customer.ToString();
                    DGV_SpendProducts.Rows[row].Cells[1].Value = item.quantity.ToString();

                    row++;
                    
                }

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DGV_SpendProducts.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {
                var id = int.Parse(DGV_SpendProducts.SelectedRows[0].Cells[3].Value.ToString());

                var q = int.Parse(DGV_SpendProducts.SelectedRows[0].Cells[1].Value.ToString());
                var query = (from d in store.OrderDetails
                             where (d.products_id == id && d.quantity == q)
                             select d).FirstOrDefault();

                store.OrderDetails.Remove(query);

                DGV_SpendProducts.Rows.RemoveAt(this.DGV_SpendProducts.SelectedRows[0].Index);



            }
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            var row = 0;
            OrdersDetails = store.OrderDetails.Where(s => s.Order_id == Orders.ID).ToList();

            foreach (var item in OrdersDetails)
            {


                var product = new Products();
                product = store.products.FirstOrDefault(p => p.ID == item.products_id);
                //CustomerNametextBox.Text = product.ProductName;

                DGV_SpendProducts.Rows[row].Cells[2].Value = product.ProductName.ToString();
                DGV_SpendProducts.Rows[row].Cells[0].Value = product.Price_customer.ToString();
                DGV_SpendProducts.Rows[row].Cells[3].Value = product.ID.ToString();
                DGV_SpendProducts.Rows[row].Cells[1].Value = item.quantity.ToString();

                row++;
            }


        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DGV_SpendProducts.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {


                var p_id = int.Parse(DGV_SpendProducts.SelectedRows[0].Cells[3].Value.ToString());
                var product = store.products.FirstOrDefault(p => p.ID == p_id);
                ProductNametextBox2.Text = product.ProductName;
                priceNumericUpDown1.Value = decimal.Parse(product.Price_customer.ToString());
                numericQuantity.Value = decimal.Parse(DGV_SpendProducts.SelectedRows[0].Cells[1].Value.ToString());



            }

        }

        private void SaveBTn_Click(object sender, EventArgs e)
        {
            double totalCost = 0;

            for (var item = 0; item < DGV_SpendProducts.Rows.Count - 1; item++)
            {

                totalCost +=
                     double.Parse(DGV_SpendProducts.Rows[item].Cells[0].Value.ToString()) *
                     double.Parse(DGV_SpendProducts.Rows[item].Cells[1].Value.ToString());



            }
;
            var id = int.Parse(CMB_MndobName.SelectedValue.ToString());
            var SaleID = store.SalesRepresentatives.FirstOrDefault(c => c.ID == id).ID;
            Orders.SalesRepresentative_Id = SaleID;
            Orders.OrderDate = DTV_ٍSpendDate.Value;
            Orders.TotalCost = totalCost;

            //  salesOrder.SalesRepresentative.ID = context.SalesRepresentatives.FirstOrDefault(s => s.ID == int.Parse(mandobCompobox.SelectedValue.ToString())).ID;
            store.SaveChanges();
            ///sales order payment
            var i = 0;
            foreach (var item in OrdersDetails)
            {
                //  SalesOrderDetails salesOrderDetails = new SalesOrderDetails();
                item.products_id = int.Parse(DGV_SpendProducts.Rows[i].Cells[3].Value.ToString());
                item.quantity = int.Parse(DGV_SpendProducts.Rows[i].Cells[1].Value.ToString());
                //item.salesOrder_id = SalesOrder.ID;
                i++;
                // store.SalesOrderDetails.Add(salesOrderDetails);
            }

            store.SaveChanges();
            MessageBox.Show("تم العمليه بنجاح");

        }

        private void BT_AddProductSpend_Click(object sender, EventArgs e)
        {
            if (DGV_SpendProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("يجب انت تختار منتج");
            }
            else
            {
                int PID = int.Parse(DGV_SpendProducts.SelectedRows[0].Cells[3].Value.ToString());
                double quantity = store.products.FirstOrDefault(c => c.ID == PID).quantityPerProducts;
                if (quantity > double.Parse(numericQuantity.Value.ToString()))
                {
                    DGV_SpendProducts.SelectedRows[0].Cells[2].Value = ProductNametextBox2.Text.ToString();
                    DGV_SpendProducts.SelectedRows[0].Cells[0].Value = priceNumericUpDown1.Text.ToString();
                    DGV_SpendProducts.SelectedRows[0].Cells[1].Value = numericQuantity.Value.ToString();
                    DGV_SpendProducts.SelectedRows[0].Cells[3].Value = PID.ToString();
                    var pro = store.products.FirstOrDefault(p => p.ID == PID);


                    var quantitiy = DGV_SpendProducts.SelectedRows[0].Cells[2].Value;
                    if (decimal.Parse(quantitiy.ToString()) > numericQuantity.Value)
                    {
                        var q = decimal.Parse(quantitiy.ToString()) - numericQuantity.Value;
                   
                        pro.quantityPerProducts += double.Parse(q.ToString());

                    }
                    else {
                        var q =  numericQuantity.Value- decimal.Parse(quantitiy.ToString());

                        pro.quantityPerProducts -= double.Parse(q.ToString());

                    }
                    priceNumericUpDown1.Text = null;
                    ProductNametextBox2.Text = null;
                    numericQuantity.Text = null;

                }
                else
                {
                    MessageBox.Show("لا يوجد كمية كافية ");
                    numericQuantity.Value = decimal.Parse(quantity.ToString());
                }


            }
        }
    }
    
}
