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
    public partial class ProductForm : Form
    {
        store store = new store();
        public ProductForm()
        {
            InitializeComponent();
        }


        public void bindGridView()
        {

            store = new store();
            var query = (from p in store.products
                         where (p.status == false && p.categories_id != null)
                         select new { p, s = p.Supplier.Name, q = p.categories.CategoryName }
                        ).ToList();
            dgv_SalesBill.RowCount = query.Count;
            int i = 0;
            foreach (var item in query)
            {



                dgv_SalesBill.Rows[i].Cells[0].Value = item.s;
                dgv_SalesBill.Rows[i].Cells[1].Value = item.p.Discount.ToString();
                dgv_SalesBill.Rows[i].Cells[2].Value = item.p.IncomePrice.ToString();
                dgv_SalesBill.Rows[i].Cells[3].Value = item.p.quantityPerProducts.ToString();
                dgv_SalesBill.Rows[i].Cells[4].Value = item.q;
                dgv_SalesBill.Rows[i].Cells[5].Value = item.p.ProductName;
                dgv_SalesBill.Rows[i].Cells[6].Value = item.p.ID.ToString();
                i++;
            }
            }
        private void Product_Load(object sender, EventArgs e)
        {

            bindGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            var query = (from p in store.products
                         where (p.status == false && p.ProductName.Contains(textBox1.Text))
                         select new { p, s = p.Supplier.Name, q = p.categories.CategoryName }
                       ).ToList();
            if (query.Count != 0)
            {

                dgv_SalesBill.RowCount = query.Count;


                int i = 0;
                foreach (var item in query)
                {



                    dgv_SalesBill.Rows[i].Cells[0].Value = item.s;
                    dgv_SalesBill.Rows[i].Cells[1].Value = item.p.Discount.ToString();
                    dgv_SalesBill.Rows[i].Cells[2].Value = item.p.IncomePrice.ToString();
                    dgv_SalesBill.Rows[i].Cells[3].Value = item.p.quantityPerProducts.ToString();
                    dgv_SalesBill.Rows[i].Cells[4].Value = item.q;
                    dgv_SalesBill.Rows[i].Cells[5].Value = item.p.ProductName;
                    dgv_SalesBill.Rows[i].Cells[6].Value = item.p.ID.ToString();
                    i++;
                }
            }
            else
            {

                dgv_SalesBill.Rows.Clear();
            }
        }

        private void deleteBtnProduct_Click(object sender, EventArgs e)
        {
            if (dgv_SalesBill.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {
                store = new store();
                dgv_SalesBill.DataSource = null;
                dgv_SalesBill.Update();
                dgv_SalesBill.Refresh();
                var id = int.Parse(dgv_SalesBill.SelectedRows[0].Cells[6].Value.ToString());
                var query = store.products.FirstOrDefault(p => p.ID == id);
                query.status = true;
                store.SaveChanges();

                bindGridView();
            }
        }

        private void editBtnProduct_Click(object sender, EventArgs e)
        {
            if (dgv_SalesBill.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {
                AddProPanel.Show();
                Btn_SaveProduct.Hide();
                EditBtn.Show();
               var P_id = int.Parse(dgv_SalesBill.SelectedRows[0].Cells[6].Value.ToString());

                Como_productCategoryUpdate.DataSource = store.categories.ToList();
                Como_productCategoryUpdate.DisplayMember = "CategoryName";
                Como_productCategoryUpdate.ValueMember = "ID";

                //////suplier
                Como_productBuySupplierUp.DataSource = store.suppliers.ToList();
                Como_productBuySupplierUp.DisplayMember = "Name";
                Como_productBuySupplierUp.ValueMember = "ID";
                ////unt
                Como_productUnitUpdate.DataSource = store.ProductUnits.ToList();
                Como_productUnitUpdate.DisplayMember = "Name";
                Como_productUnitUpdate.ValueMember = "ID";

                var query = store.products.FirstOrDefault(d => d.ID == P_id);


                Txt_ProductNameUp.Text = query.ProductName;
                numericDiscountProUp.Text = query.Discount.ToString();
                numericIncomingPriceProUp.Text = query.IncomePrice.ToString();
                numericIndvidualPriceProUp.Text = query.Price_individual.ToString();
                numericQuantityProUp.Text = query.quantityPerProducts.ToString();
                numericQuantityPackageProUp.Value = query.quantityPerGroup;
                Como_productCategoryUpdate.SelectedText = query.categories.CategoryName.ToString();
                Como_productBuySupplierUp.SelectedText = query.Supplier.Name.ToString();
                Como_productUnitUpdate.SelectedText = query.ProductUnit.Name.ToString();
            }
        }

        private void btn_addPro_Click(object sender, EventArgs e)
        {
            AddProPanel.Show();
            EditBtn.Hide();
            Btn_SaveProduct.Show();

            Txt_ProductNameUp.Text = "";
            numericDiscountProUp.Text ="";
            numericIncomingPriceProUp.Text = "";
            numericIndvidualPriceProUp.Text = "";
            numericQuantityProUp.Text = "";
            numericQuantityPackageProUp.Text = "";
            Como_productCategoryUpdate.SelectedText = "";
            Como_productBuySupplierUp.SelectedText = "";
            Como_productUnitUpdate.SelectedText = "";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var P_id = int.Parse(dgv_SalesBill.SelectedRows[0].Cells[6].Value.ToString());
            Products products = store.products.FirstOrDefault(p => p.ID == P_id);

            products.ProductName = Txt_ProductNameUp.Text;
            products.Discount = double.Parse(numericDiscountProUp.Text);
            products.IncomePrice = double.Parse(numericIncomingPriceProUp.Text);
            products.NumberOfProductInGroup = int.Parse(numericQuantityPackageProUp.Value.ToString());
            products.quantityPerProducts = int.Parse(numericQuantityProUp.Value.ToString());
            products.Price_customer = double.Parse(numericIndvidualPriceProUp.Text);
            int s_id = int.Parse(Como_productBuySupplierUp.SelectedValue.ToString());
            products.supplier_id = s_id;
            products.categories_id = int.Parse(Como_productCategoryUpdate.SelectedValue.ToString());
            products.ProductUnit_id = int.Parse(Como_productUnitUpdate.SelectedValue.ToString());
            // store.products.Add(products);
            store.SaveChanges();
            MessageBox.Show("تم تعديل المنتج");
            AddProPanel.Hide();

            bindGridView();



        }

        private void Btn_SaveProduct_Click(object sender, EventArgs e)
        {
            var nameFilter = store.products.FirstOrDefault(p => p.ProductName == Txt_ProductNameUp.Text);
            if (nameFilter == null)
            {

                Products product = new Products();
                product.ProductName = Txt_ProductNameUp.Text;
                product.Discount = double.Parse(numericDiscountProUp.Text);
                product.IncomePrice = double.Parse(numericIncomingPriceProUp.Text);
                product.NumberOfProductInGroup = double.Parse(numericQuantityPackageProUp.Value.ToString());
                product.quantityPerProducts = double.Parse(numericQuantityPackageProUp.Text);
                product.Price_customer = double.Parse(numericTotalPriceProUp.Text);
                //string n = Como_productBillBuySupplier.SelectedIndex.ToString();
                // MessageBox.Show();
                //product.Supplier =
                int s_id = int.Parse(Como_productBuySupplierUp.SelectedValue.ToString());
                product.supplier_id = s_id;

                product.categories_id = int.Parse(Como_productCategoryUpdate.SelectedValue.ToString());
                product.ProductUnit_id = int.Parse(Como_productUnitUpdate.SelectedValue.ToString());


                store.products.Add(product);
                store.SaveChanges();
                AddProPanel.Hide();
                bindGridView();
            }
            else
            {
                MessageBox.Show("هذا المنتج  موجود  بالفعل");
                Txt_ProductNameUp.Text = null;
                // AllPro allPro = new AllPro();
            }


        }

        private void dgv_SalesBill_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deleteBtnProduct.Show();
            editBtnProduct.Show();
        }
    }
}
