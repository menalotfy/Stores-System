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
    public partial class GeneralBillForm : Form
    {
        store context = new store();
        int CID = 0;
        public GeneralBillForm()
        {
            InitializeComponent();

            cmb_CustomerN.ValueMember = "ID";
            cmb_CustomerN.DisplayMember = "Name";
            cmb_CustomerN.DataSource = context.customers.ToList();

            Cmb_Employee.ValueMember = "ID";
            Cmb_Employee.DisplayMember = "EmployeeName";
            Cmb_Employee.DataSource = context.employee.ToList();

            cmb_Category.ValueMember = "ID";
            cmb_Category.DisplayMember = "CategoryName";
            cmb_Category.DataSource = context.categories.ToList();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            CID = int.Parse(cmb_Category.SelectedValue.ToString());
            var pList = from b in context.products
                        where b.categories_id == CID
                        select new { b.ID, b.Price_customer, b.ProductName };
            DGV_Poducts.Rows.Clear();
            foreach (var item in pList)
            {
                DGV_Poducts.Rows.Add(item.ID, item.Price_customer, item.ProductName);
            }
        }

        private void btn_AddToBills_Click(object sender, EventArgs e)
        {
            int PID = int.Parse(DGV_Poducts.SelectedRows[0].Cells[0].Value.ToString());
            double price = double.Parse(DGV_Poducts.SelectedRows[0].Cells[1].Value.ToString());
            string pName = DGV_Poducts.SelectedRows[0].Cells[2].Value.ToString();
            double quantity = context.products.FirstOrDefault(c => c.ID == PID).quantityPerProducts;
            if (quantity > double.Parse ( numericQuantity.Value.ToString()))
            {
                dgv_SalesBill.Rows.Add(numericDiscount.Value, price, numericQuantity.Value, pName, PID);
                numTotalCost.Value += decimal.Parse((price * int.Parse(numericQuantity.Value.ToString()) - double.Parse(numericDiscount.Value.ToString())).ToString());
            }
            else
            {
                MessageBox.Show("لا يوجد كمية كافية ");
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            numTotalCost.Value = decimal.Parse(numTotalCost.Value.ToString());
            numResCost.Value = numTotalCost.Value - numericPaiedCost.Value;
            GeneralBill generalBill = new GeneralBill();
            generalBill.customers_Id = int.Parse(cmb_CustomerN.SelectedValue.ToString());
            generalBill.employee_Id = int.Parse(Cmb_Employee.SelectedValue.ToString());
            generalBill.BillDate = dtp_GBillDate.Value;
            generalBill.totalCost = double.Parse(numTotalCost.Value.ToString());
            generalBill.status = false;
            context.GeneralBills.Add(generalBill);
            context.SaveChanges();
            context = new store();
            ///sales order payment
            GeneralBillPayment billPayment = new GeneralBillPayment();
            billPayment.Paied = double.Parse(numericPaiedCost.Value.ToString());
            billPayment.Rest = double.Parse(numResCost.Value.ToString());
            billPayment.generalBill_Id = generalBill.ID;
            context.GeneralBillPayments.Add(billPayment);
            context.SaveChanges();
            context = new store();
            for (var item = 0; item <= dgv_SalesBill.Rows.Count - 1; item++)
            {
                GeneralBillDetails billDetail = new GeneralBillDetails();
                billDetail.Product_Id = int.Parse(dgv_SalesBill.Rows[item].Cells[4].Value.ToString());
                billDetail.Quantity = int.Parse(dgv_SalesBill.Rows[item].Cells[2].Value.ToString());
                billDetail.generalBill_Id = generalBill.ID;
                context.GeneralBillDetails.Add(billDetail);
                var product = context.products.FirstOrDefault(p=>p.ID ==billDetail.Product_Id);
                product.quantityPerProducts -= billDetail.Quantity;
                
            }

            context.SaveChanges();

            context = new store();
            for (var item = 0; item < dgv_SalesBill.Rows.Count - 1; item++)
            {
                int pidd = Int32.Parse(dgv_SalesBill.Rows[item].Cells[4].Value.ToString());
                Products product = context.products.FirstOrDefault(d => d.ID == pidd);
                product.quantityPerGroup -= int.Parse(dgv_SalesBill.Rows[item].Cells[2].Value.ToString());
            }
            context.SaveChanges();

            MessageBox.Show("تم العمليه بنجاح");
            numericPaiedCost.Value = 0;
            numericDiscount.Value = 0;
            numericQuantity.Value = 0;
            numResCost.Value = 0;
            numTotalCost.Value = 0;
            dgv_SalesBill.Rows.Clear();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string prostr = textBox1.Text;
            CID = int.Parse(cmb_Category.SelectedValue.ToString());
            var pList = from b in context.products
                        where (b.categories_id == CID && b.ProductName.Contains(prostr))
                        select new { b.ID, b.Price_customer, b.ProductName };
            DGV_Poducts.Rows.Clear();
            foreach (var item in pList)
            {
                DGV_Poducts.Rows.Add(item.ID, item.Price_customer, item.ProductName);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_CustomerN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericPaiedCost_ValueChanged(object sender, EventArgs e)
        {
   
            numResCost.Value = numTotalCost.Value - numericPaiedCost.Value;
        }

        private void numResCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (dgv_SalesBill.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {
                //ShowD("هل تريد المسح؟");
                //if(DialogResult.OK);
                var cost = decimal.Parse (dgv_SalesBill.SelectedRows[0].Cells[1].Value.ToString());
                dgv_SalesBill.Rows.RemoveAt(this.dgv_SalesBill.SelectedRows[0].Index);
                numTotalCost.Value = numTotalCost.Value - cost;


            }

        }
    }
}
