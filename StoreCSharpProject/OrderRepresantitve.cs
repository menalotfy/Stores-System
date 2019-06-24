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
    public partial class OrderRepresantitve : Form
    {
        store store = new store();
        public OrderRepresantitve()
        {
            InitializeComponent();
        }

        private void CMB_Catogry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var catName = CMB_Catogry.SelectedItem.ToString();
        
            var query =
                (from a in store.products
                 where a.categories.CategoryName == catName
                 select new { a.ProductName, a.ID,a.Price_customer }).ToList();

            DataTable table = new DataTable();
            table.Columns.Add("رقم المنتج", typeof(string));
            table.Columns.Add("اسم المنتج", typeof(string));
            table.Columns.Add("سعر المنتج", typeof(string));

            foreach (var item in query)
            {

                table.Rows.Add(item.ID, item.ProductName,item.Price_customer);

            }
            DGV_SelectedProduct.DataSource = table;


        }

        private void OrderRepresantitve_Load(object sender, EventArgs e)
        {
            var mnd = (from MDB in store.SalesRepresentatives
                       where MDB.Employee.ID == MDB.Employee_Id
                       select new { MDB.Employee.EmployeeName, MDB.ID }).ToArray();
            CMB_MndobName.DisplayMember = "EmployeeName";
            CMB_MndobName.ValueMember = "ID";
            CMB_MndobName.DataSource = mnd;
            //catogries name
            var catogries = (from MDB in store.categories
                             select  MDB.CategoryName).ToArray();
            
            CMB_Catogry.DataSource = catogries;

        }

        private void BT_AddProductSpend_Click(object sender, EventArgs e)
        {
            if (DGV_SelectedProduct.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            {
                decimal quantity = numericCountity.Value;



                int productID = int.Parse(DGV_SelectedProduct.SelectedRows[0].Cells[0].Value.ToString());
                string productName = (DGV_SelectedProduct.SelectedRows[0].Cells[1].Value.ToString());
                double price = int.Parse(DGV_SelectedProduct.SelectedRows[0].Cells[2].Value.ToString())*(store.products.FirstOrDefault(p=>p.ID ==productID ).quantityPerGroup);
                DGV_SpendProducts.Rows.Add( price,  quantity, productName, productID);
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
                //ShowD("هل تريد المسح؟");
                //if(DialogResult.OK)
                DGV_SpendProducts.Rows.RemoveAt(this.DGV_SpendProducts.SelectedRows[0].Index);



            }


        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            if (DGV_SpendProducts.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
            }
            else
            { 

                int productID = int.Parse(DGV_SpendProducts.SelectedRows[0].Cells[0].Value.ToString());
                var catId = store.products.FirstOrDefault(p => p.ID == productID).categories_id;
                CMB_Catogry.SelectedItem = store.categories.FirstOrDefault(c => c.ID == catId).CategoryName;
                numericCountity.Value = decimal.Parse(DGV_SpendProducts.SelectedRows[0].Cells[2].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalCost = 0;

            for (var item = 0; item < DGV_SpendProducts.Rows.Count - 1; item++)
            {

                totalCost +=
                     double.Parse(DGV_SpendProducts.Rows[item].Cells[0].Value.ToString()) *
                     double.Parse(DGV_SpendProducts.Rows[item].Cells[1].Value.ToString());
                  


            }
            Orders Orders = new Orders();
            var id = int.Parse(CMB_MndobName.SelectedValue.ToString());
           var SaleID =store.SalesRepresentatives.FirstOrDefault(c => c.ID == id ).ID;
            Orders.SalesRepresentative_Id =SaleID;
            Orders.OrderDate =DTV_ٍSpendDate.Value;
            Orders.TotalCost = totalCost;

            //  salesOrder.SalesRepresentative.ID = context.SalesRepresentatives.FirstOrDefault(s => s.ID == int.Parse(mandobCompobox.SelectedValue.ToString())).ID;
            store.Orders.Add(Orders);
            store.SaveChanges();
            store = new store();
            ///sales order payment
            for (var item = 0; item <= DGV_SpendProducts.Rows.Count - 1; item++)
            {
                OrderDetails  OrderDetails = new OrderDetails();
                OrderDetails.products_id = int.Parse(DGV_SpendProducts.Rows[item].Cells[3].Value.ToString());
                OrderDetails.quantity = int.Parse(DGV_SpendProducts.Rows[item].Cells[1].Value.ToString());
               OrderDetails.Order_id = Orders.ID;
             store.OrderDetails.Add(OrderDetails);
                var product = store.products.FirstOrDefault(p => p.ID == OrderDetails.products_id);
                product.quantityPerProducts -= OrderDetails.quantity;

            }

            store.SaveChanges();
            MessageBox.Show("تم العمليه بنجاح");

        }


    
    }
}
