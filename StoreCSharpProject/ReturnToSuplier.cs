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
    public partial class ReturnToSuplier : Form
    {
        store context = new store();
        public List<SuppliersBillDetails> details { get; set; } = new List<SuppliersBillDetails>();
        public int p_id { get; set; }
        SupplierBill supplierBill = new SupplierBill();
        SupplierBillPayment supplierBillPayment = new SupplierBillPayment();

        public ReturnToSuplier()
        {
            InitializeComponent();
            var pList = from b in context.SupplierBills
                        select new { b.ID, b.BillDate, b.suppliers.Name };
            dgv_Bills.Rows.Clear();
            foreach (var item in pList)
            {
                dgv_Bills.Rows.Add(item.ID, item.BillDate, item.Name);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var pList = from b in context.SupplierBills
                        where b.suppliers.Name.Contains(txt_suplierName.Text)
                        select new { b.ID, b.BillDate, b.suppliers.Name };
            dgv_Bills.Rows.Clear();
            foreach (var item in pList)
            {
                dgv_Bills.Rows.Add(item.ID, item.BillDate, item.Name);
            }
        }

        private void dgv_Bills_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int billID = int.Parse(dgv_Bills.SelectedRows[0].Cells[0].Value.ToString());
            supplierBill = context.SupplierBills.FirstOrDefault(b => b.ID == billID);
            
            //label3.Text = supplierBill.suppliers.Name;
            dtp_GBillDate.Value = supplierBill.BillDate;
            numTotalCost.Value = 0;
            numTotalCost.Value = Convert.ToDecimal(supplierBill.BillValue);

            ///sales order payment

            supplierBillPayment = context.supplierBillPayment.FirstOrDefault(b => b.SupplierBill_Id == billID);
            numericPaiedCost.Value = 0;
            numericPaiedCost.Value = Convert.ToDecimal(supplierBillPayment.Paied);
            numResCost.Value = 0;
            numResCost.Value = Convert.ToDecimal(supplierBillPayment.Rest);

            details = context.SuppliersBillDetails.Where(b => b.SupplierBill_Id == billID).ToList();
            dgv_SuplierBill.Rows.Clear();
            for (var item = 0; item < details.Count; item++)
            {
                int pID = details[item].products_Id;
                var product = context.products.FirstOrDefault(p => p.ID == pID);
                string pName = product.ProductName;
                double quantity = product.quantityPerProducts;
                double price = product.Price_customer;
                double discount =product.Discount; // error we have to add discount column to generalBillDetail table
                dgv_SuplierBill.Rows.Add(discount, price, quantity, pName, pID);
            }

        }

        private void dgv_SalesBill_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_ProductName.Text = dgv_SuplierBill.SelectedRows[0].Cells[3].Value.ToString();
            numericQuantity.Value = decimal.Parse(dgv_SuplierBill.SelectedRows[0].Cells[2].Value.ToString());
            numericPrice.Value = decimal.Parse(dgv_SuplierBill.SelectedRows[0].Cells[1].Value.ToString());
            numericDiscount.Value = decimal.Parse(dgv_SuplierBill.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            details = context.SuppliersBillDetails.Where(s => s.SupplierBill_Id == supplierBill.ID).ToList();

            double totalCost = 0;
            numResCost.Value.ToString();
            numTotalCost.Value.ToString();
            for (var item = 0; item < dgv_SuplierBill.Rows.Count - 1; item++)
            {

                totalCost +=
                     double.Parse(dgv_SuplierBill.Rows[item].Cells[1].Value.ToString()) *
                     double.Parse(dgv_SuplierBill.Rows[item].Cells[2].Value.ToString()) -
                     double.Parse(dgv_SuplierBill.Rows[item].Cells[0].Value.ToString());


            }
            numTotalCost.Value = decimal.Parse(totalCost.ToString());
            numResCost.Value = numTotalCost.Value - numericPaiedCost.Value;

            /// salesOrder.customers_Id = store.customers.FirstOrDefault(c => c.Name == cmb_CustomerName.Text).ID;
            supplierBill.BillDate = dtp_GBillDate.Value;
            supplierBill.BillValue = double.Parse(numTotalCost.Value.ToString());

            //  salesOrder.SalesRepresentative.ID = store.SalesRepresentatives.FirstOrDefault(s => s.ID == int.Parse(mandobCompobox.SelectedValue.ToString())).ID;

            context.SaveChanges();
            // store = new store();
            ///sales order payment
            //SalesOredersPaymment salesOredersPaymment = new SalesOredersPaymment();
            supplierBillPayment.Paied = double.Parse(numericPaiedCost.Value.ToString());
            supplierBillPayment.Rest = double.Parse(numResCost.Value.ToString());
            //  SalesOredersPaymment.SalesOrder_id = SalesOrder.ID;
            //store.SalesOredersPaymments.Add(SalesOredersPaymment);
            context.SaveChanges();
            //store = new store();
            var i = 0;
            foreach (var item in details)
            {
                //  SalesOrderDetails salesOrderDetails = new SalesOrderDetails();
                item.products_Id = int.Parse(dgv_SuplierBill.Rows[i].Cells[4].Value.ToString());
                item.quantity = int.Parse(dgv_SuplierBill.Rows[i].Cells[2].Value.ToString());
                //item.salesOrder_id = SalesOrder.ID;
                i++;
                // store.SalesOrderDetails.Add(salesOrderDetails);
            }

            context.SaveChanges();
            MessageBox.Show("تم العمليه بنجاح");

        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgv_SuplierBill.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {
                //ShowD("هل تريد المسح؟");
                //if(DialogResult.OK)
                var id = int.Parse(dgv_SuplierBill.SelectedRows[0].Cells[4].Value.ToString());
                var q = int.Parse(dgv_SuplierBill.SelectedRows[0].Cells[2].Value.ToString());
                var query = (from d in context.SuppliersBillDetails
                             where (d.products_Id == id && d.quantity == q)
                             select d).FirstOrDefault();

                context.SuppliersBillDetails.Remove(query);
                dgv_SuplierBill.Rows.RemoveAt(this.dgv_SuplierBill.SelectedRows[0].Index);

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //  pri.Text = null;
            // productNametextBox1.Text = null;
            numericDiscount.Value.ToString();
            numericQuantity.Value.ToString();
            panel2.Visible = false;
          //  var row = -1;
            details = context.SuppliersBillDetails.Where(s => s.SupplierBill_Id == supplierBill.ID).ToList();
            for (int row = 0; row < details.Count; row++)
            {


               // row++;
                var product = new Products();
                var id = details[row].products_Id;
                product = context.products.FirstOrDefault(p => p.ID ==id);
                //CustomerNametextBox.Text = product.ProductName;
                dgv_SuplierBill.Rows.Add();
                dgv_SuplierBill.Rows[row].Cells[4].Value = product.ID.ToString();
                dgv_SuplierBill.Rows[row].Cells[3].Value = product.ProductName.ToString();
                dgv_SuplierBill.Rows[row].Cells[1].Value = product.Price_customer.ToString();
                dgv_SuplierBill.Rows[row].Cells[0].Value = product.Discount.ToString();
                dgv_SuplierBill.Rows[row].Cells[2].Value = details[row].quantity.ToString();
            }
        }

        private void btn_EditProduct_Click(object sender, EventArgs e)
        {

            if (dgv_SuplierBill.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {
                panel2.Visible = true;
                p_id = int.Parse(dgv_SuplierBill.SelectedRows[0].Cells[4].Value.ToString());
                var product = context.products.FirstOrDefault(p => p.ID == p_id);
                numericPrice.Text = product.Price_customer.ToString();
                txt_ProductName.Text = product.ProductName;
                numericDiscount.Value = decimal.Parse(product.Discount.ToString());
                numericQuantity.Value = decimal.Parse(dgv_SuplierBill.SelectedRows[0].Cells[2].Value.ToString());
            }


        }

        private void btn_SaveEdit_Click(object sender, EventArgs e)
        {
            if (dgv_SuplierBill.SelectedRows.Count == 0)
            {

            }
            else
            {
                int PID = int.Parse(dgv_SuplierBill.SelectedRows[0].Cells[4].Value.ToString());
                double quantity = context.products.FirstOrDefault(c => c.ID == PID).quantityPerProducts;
                if (quantity > double.Parse(numericQuantity.Value.ToString()))
                {
                    dgv_SuplierBill.Rows.RemoveAt(this.dgv_SuplierBill.SelectedRows[0].Index);
                    // var row = dgv_SuplierBill.Rows.Count - 1;
                    dgv_SuplierBill.Rows.Add();

                    dgv_SuplierBill.SelectedRows[0].Cells[3].Value = txt_ProductName.Text.ToString();
                    dgv_SuplierBill.SelectedRows[0].Cells[1].Value = numericPrice.Text.ToString();
                    dgv_SuplierBill.SelectedRows[0].Cells[0].Value = numericDiscount.Value.ToString();
                    dgv_SuplierBill.SelectedRows[0].Cells[2].Value = numericQuantity.Value.ToString();
                    dgv_SuplierBill.SelectedRows[0].Cells[4].Value = p_id.ToString();

                    var quantitiy = dgv_SuplierBill.SelectedRows[0].Cells[2].Value;
                    var pro = context.products.FirstOrDefault(p => p.ID == PID);

                    if (decimal.Parse(quantitiy.ToString()) > numericQuantity.Value)
                    {
                        var q = decimal.Parse(quantitiy.ToString()) - numericQuantity.Value;

                        pro.quantityPerProducts += double.Parse(q.ToString());

                    }
                    else
                    {
                        var q = numericQuantity.Value - decimal.Parse(quantitiy.ToString());

                        pro.quantityPerProducts -= double.Parse(q.ToString());

                    }

                    numericPrice.Text = null;
                    txt_ProductName.Text = null;
                    numericDiscount.Value.ToString();
                    numericQuantity.Value.ToString();
                }
            }
        }

        private void btn_CancelEdit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
