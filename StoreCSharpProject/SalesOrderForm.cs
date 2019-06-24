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
    public partial class SalesOrderForm : Form
    {
        store context = new store();

        public SalesOrderForm()
        {
            InitializeComponent();
            fillBillFormComboBoxes();
        }

        private void btn_AddNewProduct_Click(object sender, EventArgs e)
        {
            fillAddProductComboBoxes();
            Txt_Ee.Visible = true;
        }

        private void clearDataFromForm()
        {
            Txt_AddProductName.Text = "";
            numericQuantiyPro.Value = 0;
            Como_productBillBuySupplier.SelectedIndex = -1;
            Como_productBillBuyCategory.SelectedIndex = -1;
            Como_productBillBuyunit.SelectedIndex = -1;
            numericDiscountPro.Value = 0;
            numericIncomingPricePro.Value = 0;
            numericIndvidualPricePro.Value = 0;
            numericTotalPricePro.Value = 0;
            numericQuantityPackagePro.Value = 0;
        }
        private void fillAddProductComboBoxes()
        {
            Como_productBillBuySupplier.DataSource = context.suppliers.ToList();
            Como_productBillBuySupplier.DisplayMember = "Name";
            Como_productBillBuySupplier.ValueMember = "ID";

            Como_productBillBuyCategory.DataSource = context.categories.ToList();
            Como_productBillBuyCategory.DisplayMember = "CategoryName";
            Como_productBillBuyCategory.ValueMember = "ID";

            Como_productBillBuyunit.DataSource = context.ProductUnits.ToList();
            Como_productBillBuyunit.DisplayMember = "Name";
            Como_productBillBuyunit.ValueMember = "ID";
        }
        private void fillBillFormComboBoxes()
        {
            cmb_companyName.DisplayMember = "Name";
            cmb_companyName.ValueMember = "ID";
            cmb_companyName.DataSource = context.suppliers.ToList();

            cmb_Categorybuy.DisplayMember = "CategoryName";
            cmb_Categorybuy.ValueMember = "ID";
            cmb_Categorybuy.DataSource = context.categories.ToList();

            //cmb_ProductNameBuy.SelectedIndex = -1;
        }

        private void clearFields()
        {
            dgv_SalesBillbuy.Rows.Clear();
            numericQuantitybuy.Value = 0;
            numericDiscountbuy.Value = 0;
            numericPaiedCostbuy.Value = 0;
            numericResCostbuy.Value = 0;
            numericTotalCostbuy.Value = 0;
        }

        private void btn_AddToBillsbuy_Click(object sender, EventArgs e)
        {
            int PID = int.Parse(cmb_ProductNameBuy.SelectedValue.ToString());
            double price = double.Parse(numericProductPricebuy.Value.ToString());
            string pName = cmb_ProductNameBuy.Text;
            int quantity = int.Parse(numericQuantitybuy.Value.ToString());
            dgv_SalesBillbuy.Rows.Add(numericDiscountbuy.Value, price, quantity, pName, PID);
            numericTotalCostbuy.Value += decimal.Parse((price * quantity - double.Parse(numericDiscountbuy.Value.ToString())).ToString());
        }

        private void btn_Cancelbuy_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btn_Savebuy_Click(object sender, EventArgs e)
        {
            if (dgv_SalesBillbuy.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("قائمة المنتجات فارغة");
            }
            else
            {
                //numTotalCost.Value = decimal.Parse(numTotalCost.Value.ToString());
                //numResCost.Value = numTotalCost.Value - numericPaiedCost.Value;
                SalesOrder salesOrder = new SalesOrder();
                salesOrder.SalesRepresentative_id = int.Parse(cmb_companyName.SelectedValue.ToString());
                // check==> salesOrder.salesRepresentative_ID = int.Parse(cmb_companyName.SelectedValue.ToString());
                salesOrder.SalesOrderDate = dtp_BillDate.Value;
                salesOrder.SalesOrederTotalPrice = double.Parse(numericResCostbuy.Value.ToString());
                salesOrder.status = false;
                context.SalesOrder.Add(salesOrder);
                context.SaveChanges();
                context = new store();
                ///sales order payment
                SalesOredersPaymment oredersPaymment = new SalesOredersPaymment();
                oredersPaymment.Paied = double.Parse(numericPaiedCostbuy.Value.ToString());
                oredersPaymment.Rest = double.Parse(numericResCostbuy.Value.ToString());
                oredersPaymment.SalesOrder_id = salesOrder.ID;
                context.SalesOredersPaymments.Add(oredersPaymment);
                context.SaveChanges();
                context = new store();
                for (var item = 0; item < dgv_SalesBillbuy.Rows.Count - 1; item++)
                {
                    SalesOrderDetails orderDetail = new SalesOrderDetails();
                    orderDetail.products_id = int.Parse(dgv_SalesBillbuy.Rows[item].Cells[4].Value.ToString());
                    orderDetail.quantity = int.Parse(dgv_SalesBillbuy.Rows[item].Cells[2].Value.ToString());
                    orderDetail.salesOrder_id = salesOrder.ID;
                    context.SalesOrderDetails.Add(orderDetail);
                }

                context.SaveChanges();

                context = new store();
                for (var item = 0; item <= dgv_SalesBillbuy.Rows.Count - 1; item++)
                {
                    int pidd = Int32.Parse(dgv_SalesBillbuy.Rows[item].Cells[4].Value.ToString());
                    Products product = context.products.FirstOrDefault(d => d.ID == pidd);
                    product.quantityPerProducts += int.Parse(dgv_SalesBillbuy.Rows[item].Cells[2].Value.ToString());
                }
                context.SaveChanges();

                MessageBox.Show("تم العمليه بنجاح");
                clearFields();
            }
        }

        private void Btn_SaveProduct_Click(object sender, EventArgs e)
        {
            if (Txt_AddProductName.Text == null ||
                 numericQuantiyPro.Value == 0 ||
                 numericDiscountPro.Value == 0 ||
                 numericIncomingPricePro.Value == 0 ||
                 numericQuantityPackagePro.Value == 0 ||
                 numericTotalPricePro.Value == 0 ||
                 numericIndvidualPricePro.Value == 0 )
            {
                MessageBox.Show("لم يتم ادخال كل تفاصيل المنتج");
            }
            else
            {
                Products product = new Products();
                product.ProductName = Txt_AddProductName.Text;
                product.quantityPerProducts = double.Parse(numericQuantiyPro.Value.ToString());
                product.supplier_id = int.Parse(Como_productBillBuySupplier.SelectedValue.ToString());
                product.categories_id = int.Parse(Como_productBillBuyCategory.SelectedValue.ToString());
                product.ProductUnit_id = int.Parse(Como_productBillBuyunit.SelectedValue.ToString());
                product.Discount = double.Parse(numericDiscountPro.Value.ToString());
                product.IncomePrice = double.Parse(numericIncomingPricePro.Value.ToString());
                product.Price_individual = double.Parse(numericIndvidualPricePro.Value.ToString());
                product.NumberOfProductInGroup = double.Parse(numericTotalPricePro.Value.ToString());
                product.quantityPerGroup = int.Parse(numericQuantityPackagePro.Value.ToString());
                context.products.Add(product);
                context.SaveChanges();
                MessageBox.Show("تم اضافة المنتج");
                //fillGrid();
                clearDataFromForm();
                fillBillFormComboBoxes();
                Txt_Ee.Visible = false;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clearDataFromForm();
            Txt_Ee.Visible = false;
        }

        private void cmb_Categorybuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int catID = int.Parse(cmb_Categorybuy.SelectedValue.ToString());
            cmb_ProductNameBuy.ValueMember = "ID";
            cmb_ProductNameBuy.DisplayMember = "ProductName";
            cmb_ProductNameBuy.DataSource = context.products.Where(p => p.categories_id == catID).ToList();
        }

        private void cmb_ProductNameBuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pid = int.Parse(cmb_ProductNameBuy.SelectedValue.ToString());
            decimal price = Convert.ToDecimal(context.products.FirstOrDefault(c => c.ID == pid).IncomePrice);
            numericProductPricebuy.Value = price;

        }

        private void cmb_companyName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_delBuy_Click(object sender, EventArgs e)
        {
            if (dgv_SalesBillbuy.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج علي الاقل");
            }
            else
            {
               // var id = int.Parse(dgv_SalesBillbuy.SelectedRows[0].Cells[4].Value.ToString());
                var priceDel = decimal.Parse(dgv_SalesBillbuy.SelectedRows[0].Cells[1].Value.ToString());
                dgv_SalesBillbuy.Rows.RemoveAt(this.dgv_SalesBillbuy.SelectedRows[0].Index);
                numericTotalCostbuy.Value -= priceDel;
            }
        }

        private void numericPaiedCostbuy_ValueChanged(object sender, EventArgs e)
        {
            if (numericPaiedCostbuy.Value == numericTotalCostbuy.Value || (numericTotalCostbuy.Value - numericPaiedCostbuy.Value == 0))
            {
                MessageBox.Show("تم دفع المبلغ بالكامل");
                numericResCostbuy.Value = 0;
            }
            else
                numericResCostbuy.Value = numericTotalCostbuy.Value - numericPaiedCostbuy.Value;
        }

        private void Como_productBillBuySupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
