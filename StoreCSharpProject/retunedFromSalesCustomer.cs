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
    public partial class retunedFromSalesCustomer : Form
    {
        store store = new store();
        public List<SalesOrderDetails> details { get; set; } = new List<SalesOrderDetails>();
        public int p_id { get; set; }
        SalesOrder SalesOrder = new SalesOrder();
        SalesOredersPaymment SalesOredersPaymment = new SalesOredersPaymment();
        public retunedFromSalesCustomer()
        {
            InitializeComponent();
            MandobtextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            MandobtextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            var q1 = from emp in store.employee
                     from s in store.SalesRepresentatives
                     where (s.Employee_Id == emp.ID)
                     select emp.EmployeeName;
            foreach (var item in q1)
            {
                DataCollection.Add(item);
            }
            MandobtextBox.AutoCompleteCustomSource = DataCollection;
            CustomerNametextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            CustomerNametextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection2 = new AutoCompleteStringCollection();
            var q2 = store.customers.ToList();
            foreach (var item in q2)
            {
                DataCollection2.Add(item.Name);
            }
            CustomerNametextBox.AutoCompleteCustomSource = DataCollection2;

       
    }





    

    private void retunedFromSalesCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnFound_Click(object sender, EventArgs e)
        {
            
            var billDate = dtp_BillDate.Value;
            var salesRep = store.employee.FirstOrDefault(m => m.EmployeeName == MandobtextBox.Text);
                           
            var customer =store.customers.FirstOrDefault(c=>c.Name==CustomerNametextBox.Text);
             SalesOrder = (
                from s in store.SalesOrder
                where (s.SalesRepresentative.Employee_Id == salesRep.ID /*&& s.SalesOrderDate == billDate*/ && s.customers_Id == customer.ID)
                select s
                ).FirstOrDefault();
            if (SalesOrder != null)
            {
                panel1.Show();
                panel2.Show();
                panel3.Show();
                btn_AddToBills.Show();
                btn_Cancel.Show();
                btn_Print.Show();
                btn_Save.Show();
                editBtn.Show();
                searchBtn.Show();
                SearchtextBox3.Show();
                DeleteBtn.Show();
                dgv_SalesBill.Show();
                details = store.SalesOrderDetails.Where(s => s.salesOrder_id == SalesOrder.ID).ToList();
                //dgv_SalesBill.Rows.Add();
                
                int row = 0;
                //row = dgv_SalesBill.Rows.Count - 2;
                SalesOredersPaymment = store.SalesOredersPaymments.FirstOrDefault(s => s.SalesOrder_id == SalesOrder.ID);
                numericPaiedCost.Value = decimal.Parse(SalesOredersPaymment.Paied.ToString());
                numericResCost.Value = decimal.Parse(SalesOredersPaymment.Rest.ToString());
                numericTotalCost.Value= decimal.Parse(SalesOrder.SalesOrederTotalPrice.ToString());

                foreach (var item in details)
                {
                   
                    dgv_SalesBill.Rows.Add();
                   
                    var product = new Products();
                    product = store.products.FirstOrDefault(p => p.ID == item.products_id);

                    //dgv_SalesBill["ProductID", row].Value = product.ID.ToString();
                    //dgv_SalesBill["productName", row].Value = product.ProductName.ToString();
                    //dgv_SalesBill["price", row].Value = product.Price_customer.ToString();
                    //dgv_SalesBill["discount", row].Value = product.Discount.ToString();
                    //dgv_SalesBill["productQuantity", row].Value = item.quantity.ToString();
                    dgv_SalesBill.Rows[row].Cells[4].Value = product.ID.ToString();
                    dgv_SalesBill.Rows[row].Cells[3].Value = product.ProductName.ToString();
                    dgv_SalesBill.Rows[row].Cells[1].Value = product.Price_customer.ToString();
                    dgv_SalesBill.Rows[row].Cells[0].Value = product.Discount.ToString();
                    dgv_SalesBill.Rows[row].Cells[2].Value = item.quantity.ToString();

                    row++;
                }





            }
            else
            {
                MessageBox.Show("هذه  الفاتوره ليست موجوده");
            }



        }

        private void SearchtextBox3_TextChanged(object sender, EventArgs e)
        {
            




        }

        private void searchBtn_Click(object sender, EventArgs e)
        {


            dgv_SalesBill.RowCount = 1;
                var product = new Products();
                product = (from p in store.products
                           where (p.ProductName.Contains(SearchtextBox3.Text))
                           select p).FirstOrDefault();
                dgv_SalesBill.Rows[0].Cells[4].Value = product.ID.ToString();
                dgv_SalesBill.Rows[0].Cells[3].Value = product.ProductName.ToString();
                dgv_SalesBill.Rows[0].Cells[1].Value = product.Price_customer.ToString();
                dgv_SalesBill.Rows[0].Cells[0].Value = product.Discount.ToString();

                dgv_SalesBill.Rows[0].Cells[2].Value = product.quantityPerGroup.ToString();
            
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            textBoxProductPrice.Text = null;
            productNametextBox1.Text =null;
            numericDiscount.Value.ToString();
            numericQuantity.Value.ToString();

            var row = 0;
            details = store.SalesOrderDetails.Where(s => s.salesOrder_id == SalesOrder.ID).ToList();

            foreach (var item in details)
            {

                
                var product = new Products();
                product = store.products.FirstOrDefault(p => p.ID == item.products_id);
                //CustomerNametextBox.Text = product.ProductName;

                 dgv_SalesBill.Rows[row].Cells[3].Value = product.ProductName.ToString();
                dgv_SalesBill.Rows[row].Cells[1].Value = product.Price_customer.ToString();
                dgv_SalesBill.Rows[row].Cells[0].Value = product.Discount.ToString();
                dgv_SalesBill.Rows[row].Cells[2].Value = item.quantity.ToString();

                row++;
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dgv_SalesBill.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {
                

                p_id = int.Parse(dgv_SalesBill.SelectedRows[0].Cells[4].Value.ToString());
                var product = store.products.FirstOrDefault(p => p.ID == p_id);
                textBoxProductPrice.Text = product.Price_customer.ToString();
                productNametextBox1.Text = product.ProductName;
                numericDiscount.Value = decimal.Parse(product.Discount.ToString());
                numericQuantity.Value = decimal.Parse(dgv_SalesBill.SelectedRows[0].Cells[2].Value.ToString());


            }


        }

        private void btn_AddToBills_Click(object sender, EventArgs e)
        {

            if (dgv_SalesBill.SelectedRows.Count==0)
            {

            }
            else
            {
                int PID = int.Parse(dgv_SalesBill.SelectedRows[0].Cells[4].Value.ToString());
                double quantity = store.products.FirstOrDefault(c => c.ID == PID).quantityPerProducts;
                if (quantity > double.Parse(numericQuantity.Value.ToString()))
                {
                   // dgv_SalesBill.Rows.RemoveAt(this.dgv_SalesBill.SelectedRows[0].Index);
                    var row = dgv_SalesBill.Rows.Count - 1;
                    dgv_SalesBill.Rows.Add();

                    dgv_SalesBill.SelectedRows[0].Cells[3].Value = productNametextBox1.Text.ToString();
                    dgv_SalesBill.SelectedRows[0].Cells[1].Value = textBoxProductPrice.Text.ToString();
                    dgv_SalesBill.SelectedRows[0].Cells[0].Value = numericDiscount.Value.ToString();
                    dgv_SalesBill.SelectedRows[0].Cells[2].Value = numericQuantity.Value.ToString();
                    dgv_SalesBill.SelectedRows[0].Cells[4].Value = p_id.ToString();
                    var pro = store.products.FirstOrDefault(p => p.ID == PID);
                    var quantitiy = dgv_SalesBill.SelectedRows[0].Cells[1].Value;
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

                    textBoxProductPrice.Text = null;
                    productNametextBox1.Text = null;
                    numericDiscount.Value.ToString();
                    numericQuantity.Value.ToString();

                }
                else
                {
                    MessageBox.Show("لا يوجد كمية كافية ");
                    numericQuantity.Value = decimal.Parse (quantity.ToString());
                }

            }
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
                var query = (from d in store.SalesOrderDetails
                             where (d.products_id == id && d.quantity == q)
                             select d).FirstOrDefault();

                store.SalesOrderDetails.Remove(query);
                dgv_SalesBill.Rows.RemoveAt(this.dgv_SalesBill.SelectedRows[0].Index);



            }




        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            store.SaveChanges();
            details = store.SalesOrderDetails.Where(s => s.salesOrder_id == SalesOrder.ID).ToList();

            double totalCost = 0;
            numericResCost.Value.ToString();
            numericTotalCost.Value.ToString();
            for (var item = 0; item < dgv_SalesBill.Rows.Count - 1; item++)
            {

                totalCost +=
                     double.Parse(dgv_SalesBill.Rows[item].Cells[1].Value.ToString()) *
                     double.Parse(dgv_SalesBill.Rows[item].Cells[2].Value.ToString()) -
                     double.Parse(dgv_SalesBill.Rows[item].Cells[0].Value.ToString());


            }
            numericTotalCost.Value = decimal.Parse(totalCost.ToString());
            numericResCost.Value = numericTotalCost.Value - numericPaiedCost.Value;

            /// salesOrder.customers_Id = store.customers.FirstOrDefault(c => c.Name == cmb_CustomerName.Text).ID;
            SalesOrder.SalesOrderDate = dtp_BillDate.Value;
            SalesOrder.SalesOrederTotalPrice = double.Parse(numericTotalCost.Value.ToString());
            
            //  salesOrder.SalesRepresentative.ID = store.SalesRepresentatives.FirstOrDefault(s => s.ID == int.Parse(mandobCompobox.SelectedValue.ToString())).ID;
          
            store.SaveChanges();
           // store = new store();
            ///sales order payment
            //SalesOredersPaymment salesOredersPaymment = new SalesOredersPaymment();
            SalesOredersPaymment.Paied = double.Parse(numericPaiedCost.Value.ToString());
            SalesOredersPaymment.Rest = double.Parse(numericResCost.Value.ToString());
          //  SalesOredersPaymment.SalesOrder_id = SalesOrder.ID;
            //store.SalesOredersPaymments.Add(SalesOredersPaymment);
            store.SaveChanges();
            //store = new store();
            var i = 0;
            
            foreach (var item in details)
            {
              //  SalesOrderDetails salesOrderDetails = new SalesOrderDetails();
                item.products_id = int.Parse(dgv_SalesBill.Rows[i].Cells[4].Value.ToString());
                item.quantity = int.Parse(dgv_SalesBill.Rows[i].Cells[2].Value.ToString());
                //item.salesOrder_id = SalesOrder.ID;
                i++;

               // store.SalesOrderDetails.Add(salesOrderDetails);
            }

            store.SaveChanges();
            MessageBox.Show("تم العمليه بنجاح");

        }

        private void numericResCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericTotalCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericPaiedCost_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
