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
    public partial class ReturnFromCustomer : Form
    {
        store context = new store();
        GeneralBill GeneralBill = new GeneralBill();
        GeneralBillPayment GeneralBillPayment = new GeneralBillPayment();

        public List<GeneralBillDetails> details { get; set; } = new List<GeneralBillDetails>();

        public ReturnFromCustomer()
        {
            InitializeComponent();
            var pList = from b in context.GeneralBills
                        select new { b.ID, b.BillDate, b.customers.Name };
            dgv_Bills.Rows.Clear();
            foreach (var item in pList)
            {
                dgv_Bills.Rows.Add(item.ID, item.BillDate, item.Name);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var pList = from b in context.GeneralBills
                        where b.customers.Name.Contains(txt_customerName.Text)
                        select new { b.ID, b.BillDate, b.customers.Name };
            dgv_Bills.Rows.Clear();
            foreach (var item in pList)
            {
                dgv_Bills.Rows.Add(item.ID, item.BillDate, item.Name);
            }
        }

        private void dgv_Bills_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            fillComboBoxes();
            int billID = int.Parse(dgv_Bills.SelectedRows[0].Cells[0].Value.ToString());
            GeneralBill = context.GeneralBills.FirstOrDefault(b => b.ID == billID);


            cmb_CustomerN.SelectedValue = GeneralBill.customers_Id;
            Cmb_Employee.SelectedValue = GeneralBill.employee_Id;
            dtp_GBillDate.Value = GeneralBill.BillDate;
            numTotalCost.Value = Convert.ToDecimal(GeneralBill.totalCost);

            ///sales order payment

             GeneralBillPayment = context.GeneralBillPayments.FirstOrDefault(b => b.generalBill_Id == billID);
            numericPaiedCost.Value = Convert.ToDecimal(GeneralBillPayment.Paied);
            numResCost.Value = Convert.ToDecimal(GeneralBillPayment.Rest);

            var GeneralBillDetail = context.GeneralBillDetails.Where(b => b.generalBill_Id == billID).ToList();
            dgv_SalesBill.Rows.Clear();
            for (var item = 0; item < GeneralBillDetail.Count; item++)
            {

                int pID = GeneralBillDetail[item].Product_Id;
                var product = context.products.FirstOrDefault(p => p.ID == pID);
                string pName = product.ProductName;
                double quantity = GeneralBillDetail[item].Quantity;
                double price = product.Price_individual;
                double discount = product.Discount; // error we have to add discount column to generalBillDetail table
                dgv_SalesBill.Rows.Add(discount, price, quantity, pName, pID);
            }

        }

        private void fillComboBoxes()
        {
            cmb_CustomerN.DisplayMember = "Name";
            cmb_CustomerN.ValueMember = "ID";
            cmb_CustomerN.DataSource = context.customers.ToList();

            Cmb_Employee.DisplayMember = "EmployeeName";
            Cmb_Employee.ValueMember = "ID";
            Cmb_Employee.DataSource = context.employee.ToList();
        }

        private void ReturnFromCustomer_Load(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgv_SalesBill.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {
                //ShowD("هل تريد المسح؟");
                //if(DialogResult.OK)
                var id = int.Parse(dgv_SalesBill.SelectedRows[0].Cells[4].Value.ToString());
                var q = int.Parse(dgv_SalesBill.SelectedRows[0].Cells[2].Value.ToString());
                var query = (from d in context.GeneralBillDetails
                             where (d.Product_Id == id && d.Quantity == q)
                             select d).FirstOrDefault();

                context.GeneralBillDetails.Remove(query);
                dgv_SalesBill.Rows.RemoveAt(this.dgv_SalesBill.SelectedRows[0].Index);



            }




        }


        private void btn_AddToBills_Click(object sender, EventArgs e)
        {


            if (dgv_SalesBill.SelectedRows.Count == 0)
            {
                MessageBox.Show("يجب اختيار منتج");
            }
            else
            {
                int PID = int.Parse(dgv_SalesBill.SelectedRows[0].Cells[4].Value.ToString());
                double quantity = context.products.FirstOrDefault(c => c.ID == PID).quantityPerProducts;

                if (quantity >= double.Parse(numericQuantity.Value.ToString()))
                {
                    var row = dgv_SalesBill.Rows.Count - 1;
             //       dgv_SalesBill.Rows.Add();

                    dgv_SalesBill.Rows[row].Cells[3].Value = ProductNametextBox2.Text.ToString();
                    dgv_SalesBill.Rows[row].Cells[1].Value = priceNumericUpDown1.Value.ToString();
                    dgv_SalesBill.Rows[row].Cells[0].Value = numericDiscount.Value.ToString();
                    dgv_SalesBill.Rows[row].Cells[2].Value = numericQuantity.Value.ToString();
                    dgv_SalesBill.Rows[row].Cells[4].Value = PID.ToString();

                    var quantitiy = dgv_SalesBill.SelectedRows[0].Cells[2].Value;
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


                    ProductNametextBox2.Text = null;
                    priceNumericUpDown1.Text = null;
                    numericDiscount.Text=null;
                    numericQuantity.Text=null;

                }
                else
                {
                    MessageBox.Show("لا يوجد كمية كافية ");
                    numericQuantity.Value = decimal.Parse(quantity.ToString());
                }



            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ProductNametextBox2.Text = null;
            priceNumericUpDown1.Text = null;
            numericDiscount.Value.ToString();
            numericQuantity.Value.ToString();

            var row = 0;
            details = context.GeneralBillDetails.Where(s => s.generalBill_Id == GeneralBill.ID).ToList();
            dgv_SalesBill.Rows.Add();

            foreach (var item in details)
            {

                var product = new Products();
                product = context.products.FirstOrDefault(p => p.ID == item.Product_Id);
                //CustomerNametextBox.Text = product.ProductName;

                dgv_SalesBill.Rows[row].Cells[3].Value = product.ProductName.ToString();
                dgv_SalesBill.Rows[row].Cells[1].Value = product.Price_customer.ToString();
                dgv_SalesBill.Rows[row].Cells[0].Value = product.Discount.ToString();
                dgv_SalesBill.Rows[row].Cells[2].Value = item.Quantity.ToString();

                row++;
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            context.SaveChanges();
            details = context.GeneralBillDetails.Where(s => s.generalBill_Id == GeneralBill.ID).ToList();

            double totalCost = 0;
            numResCost.Value.ToString();
            numTotalCost.Value.ToString();
            for (var item = 0; item <= dgv_SalesBill.Rows.Count - 1; item++)
            {

                totalCost +=
                     double.Parse(dgv_SalesBill.Rows[item].Cells[1].Value.ToString()) *
                     double.Parse(dgv_SalesBill.Rows[item].Cells[2].Value.ToString()) -
                     double.Parse(dgv_SalesBill.Rows[item].Cells[0].Value.ToString());


            }
            numTotalCost.Value = decimal.Parse(totalCost.ToString());
            numResCost.Value = numTotalCost.Value - numericPaiedCost.Value;

            /// salesOrder.customers_Id = store.customers.FirstOrDefault(c => c.Name == cmb_CustomerName.Text).ID;
            GeneralBill.BillDate = dtp_GBillDate.Value;
            GeneralBill.totalCost = double.Parse(numTotalCost.Value.ToString());
            var id = int.Parse(Cmb_Employee.SelectedValue.ToString());

            GeneralBill.employee_Id = context.employee.FirstOrDefault(s => s.ID == id).ID;

            context.SaveChanges();
            GeneralBillPayment.Paied = double.Parse(numericPaiedCost.Value.ToString());
            GeneralBillPayment.Rest = double.Parse(numResCost.Value.ToString());
            //  SalesOredersPaymment.SalesOrder_id = SalesOrder.ID;
            //store.SalesOredersPaymments.Add(SalesOredersPaymment);
            context.SaveChanges();
            //store = new store();
            var i = 0;
            foreach (var item in details)
            {
                //  SalesOrderDetails salesOrderDetails = new SalesOrderDetails();
                item.Product_Id = int.Parse(dgv_SalesBill.Rows[i].Cells[4].Value.ToString());
                item.Quantity = int.Parse(dgv_SalesBill.Rows[i].Cells[2].Value.ToString());
                //item.salesOrder_id = SalesOrder.ID;
                i++;
                // store.SalesOrderDetails.Add(salesOrderDetails);
            }

            context.SaveChanges();
            MessageBox.Show("تم العمليه بنجاح");

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dgv_SalesBill.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {


              var   p_id = int.Parse(dgv_SalesBill.SelectedRows[0].Cells[4].Value.ToString());
                var product = context.products.FirstOrDefault(p => p.ID == p_id);
                priceNumericUpDown1.Text = product.Price_customer.ToString();
                ProductNametextBox2.Text = product.ProductName;
                numericDiscount.Value = decimal.Parse(product.Discount.ToString());
                numericQuantity.Value = decimal.Parse(dgv_SalesBill.SelectedRows[0].Cells[2].Value.ToString());


            }


        }
    }
}

