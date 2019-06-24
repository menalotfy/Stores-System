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
    public partial class SalesBillMandob : Form
    {
        public string name { get; set; }
        public int id { get; set; }
        store context = new store();
        public SalesBillMandob()
        {
            InitializeComponent();
        }

        private void DataGrid_remove(object sender, EventArgs e)
        {

            foreach (DataGridViewRow r in dgv_SalesBill.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    dgv_SalesBill.Rows.RemoveAt(r.Index);
                }
            }
        }

        private void btn_AddToBills_Click(object sender, EventArgs e)
        {

            var product_query =
                (from p in context.products
                 where p.ProductName == name && p.status == false
                 select p).FirstOrDefault();
            if (double.Parse(numericQuantity.Value.ToString()) > product_query.quantityPerProducts)
            {
                MessageBox.Show("هذه الكميه غير متوفره");
            }
            else
            {
                product_query.quantityPerProducts = product_query.quantityPerProducts - double.Parse(numericQuantity.Value.ToString());
                context.SaveChanges();
                int row = 0;
                dgv_SalesBill.Rows.Add();
                row = dgv_SalesBill.Rows.Count - 2;

                dgv_SalesBill["ProductID", row].Value = id.ToString();
                dgv_SalesBill["productName", row].Value = cmb_ProductName.SelectedValue;
                dgv_SalesBill["productQuantity", row].Value = numericQuantity.Value;
                dgv_SalesBill["price", row].Value = textBoxProductPrice.Text;
                dgv_SalesBill["discount", row].Value = numericDiscount.Value;
            }
        }

        private void SalesBillMandob_Load(object sender, EventArgs e)
        {
            var customer_query = (from s in context.customers
                                  select s.Name).ToList();
            cmb_CustomerName.DataSource = customer_query;
            var mandoob_query = (from m in context.SalesRepresentatives
                                 select m.Employee.EmployeeName).ToList();
            mandobCompobox.DataSource = mandoob_query;
            var category_qyery = (from c in context.categories
                                  select c.CategoryName).ToList();
            cmb_Category.DataSource = category_qyery;


        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Cancel.Click += DataGrid_remove;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            double totalCost = 0;

            for (var item = 0; item < dgv_SalesBill.Rows.Count - 1; item++)
            {

                totalCost +=
                     double.Parse(dgv_SalesBill.Rows[item].Cells[1].Value.ToString()) *
                     double.Parse(dgv_SalesBill.Rows[item].Cells[2].Value.ToString()) -
                     double.Parse(dgv_SalesBill.Rows[item].Cells[0].Value.ToString());


            }
            numericTotalCost.Value = decimal.Parse(totalCost.ToString());
            numericResCost.Value = numericTotalCost.Value - numericPaiedCost.Value;
            SalesOrder salesOrder = new SalesOrder();
            salesOrder.customers_Id = context.customers.FirstOrDefault(c => c.Name == cmb_CustomerName.Text).ID;
            salesOrder.SalesOrderDate = dtp_BillDate.Value;
            salesOrder.SalesOrederTotalPrice = double.Parse(numericTotalCost.Value.ToString());

            //  salesOrder.SalesRepresentative.ID = context.SalesRepresentatives.FirstOrDefault(s => s.ID == int.Parse(mandobCompobox.SelectedValue.ToString())).ID;
            context.SalesOrder.Add(salesOrder);
            context.SaveChanges();
            context = new store();
            ///sales order payment
            SalesOredersPaymment salesOredersPaymment = new SalesOredersPaymment();
            salesOredersPaymment.Paied = double.Parse(numericPaiedCost.Value.ToString());
            salesOredersPaymment.Rest = double.Parse(numericResCost.Value.ToString());
            salesOredersPaymment.SalesOrder_id = salesOrder.ID;
            context.SalesOredersPaymments.Add(salesOredersPaymment);
            context.SaveChanges();
            context = new store();
            for (var item = 0; item < dgv_SalesBill.Rows.Count - 1; item++)
            {
                SalesOrderDetails salesOrderDetails = new SalesOrderDetails();
                salesOrderDetails.products_id = int.Parse(dgv_SalesBill.Rows[item].Cells[4].Value.ToString());
                salesOrderDetails.quantity = int.Parse(dgv_SalesBill.Rows[item].Cells[2].Value.ToString());
                salesOrderDetails.salesOrder_id = salesOrder.ID;
                var product = context.products.FirstOrDefault(p => p.ID == salesOrderDetails.products_id);
                product.quantityPerProducts -= salesOrderDetails.quantity;
                context.SalesOrderDetails.Add(salesOrderDetails);
            }

            context.SaveChanges();
            MessageBox.Show("تم العمليه بنجاح");
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {

            var name = cmb_Category.SelectedValue.ToString();
            var product_query = (from p in context.products

                                 where p.categories.CategoryName == name && p.status == false
                                 select p.ProductName).ToList();
            cmb_ProductName.MaxDropDownItems = product_query.Count;
            cmb_ProductName.DataSource = product_query;
        }

        private void cmb_ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = cmb_ProductName.SelectedValue.ToString();
            var product_query = (from p in context.products

                                 where p.ProductName == name && p.status == false
                                 select new { p.Price_customer, p.ID, p.Discount }).FirstOrDefault();
            //cmb_ProductName.MaxDropDownItems = product_query.Count;
            textBoxProductPrice.Text = product_query.Price_customer.ToString();
            id = product_query.ID;
            numericDiscount.Value = decimal.Parse(product_query.Discount.ToString());


        }

        private void mandobCompobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_CustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
