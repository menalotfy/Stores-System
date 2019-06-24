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
    public partial class CustomerForm1 : Form
    {
        store store = new store();
        public int p_id { get; set; }
        public CustomerForm1()
        {
            InitializeComponent();
        }

        public void bindGridView()
        {
            store = new store();
            var query = store.customers.Where(p => p.Status == false).ToList();

            if (query.Count != 0)
            {

                DGV_Customer.RowCount = query.Count;

                int i = 0;
                foreach (var item in query)
                {
                    DGV_Customer.Rows[i].Cells[0].Value = item.ID.ToString();
                    DGV_Customer.Rows[i].Cells[1].Value = item.Name.ToString();
                    DGV_Customer.Rows[i].Cells[2].Value = item.Phone.ToString();
                    // DGV_Customer.Rows[i].Cells[3].Value = item.a.ToString();
                    DGV_Customer.Rows[i].Cells[3].Value = item.addrees;

                    i++;
                }
            }


        }

        private void DGV_Customer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            delCustomer.Show();
            bt_editCustomer.Show();
        }

        //private void delCustomer_Click(object sender, EventArgs e)
        //{
        //    store = new store();
        //    DGV_Customer.DataSource = null;
        //    DGV_Customer.Update();
        //    DGV_Customer.Refresh();
        //    var id = int.Parse(DGV_Customer.SelectedRows[0].Cells[0].Value.ToString());
        //    var query = store.customers.FirstOrDefault(p => p.ID == id);

        //    query.Status = true;
        //    store.SaveChanges();
        //    bindGridView();
        //}

        //private void bt_editCustomer_Click(object sender, EventArgs e)
        //{

        //}

        //private void TXT_customerSearch_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void CustomerForm1_Load(object sender, EventArgs e)
        //{
        //    bindGridView();
        //}

        //private void BtupdateCustomer_Click(object sender, EventArgs e)
        //{
        //    store = new store();
        //    p_id = int.Parse(DGV_Customer.SelectedRows[0].Cells[0].Value.ToString());
        //    var query = store.customers.FirstOrDefault(p => p.ID == p_id);
        //    query.Name = CustomerNameTxt.Text.ToString();
        //    query.addrees = CustomerAddressTxt.Text.ToString();
        //    query.Phone = CustomerPhoneTxt.Text.ToString();
        //    query.type = CustomerTypecomboBox.SelectedItem.ToString();
        //    store.SaveChanges();
        //    bindGridView();
        //}

        //private void bt_addCustomer_Click(object sender, EventArgs e)
        //{


        //}

        private void showAddCustomerBtn_Click(object sender, EventArgs e)
        {
            bt_addCustomer.Show();
            BtupdateCustomer.Hide();
            CustomerNameTxt.Text = null;
            CustomerPhoneTxt.Text = null;
            CustomerAddressTxt.Text = null;


        }

        //private void bt_addCustomer_Click(object sender, EventArgs e)
        //{

        //}

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_editCustomer_Click_1(object sender, EventArgs e)
        {
          
         

            }

        

        private void delCustomer_Click_1(object sender, EventArgs e)
        {
           
        }

        private void bt_addCustomer_Click_1(object sender, EventArgs e)
        {
            if (CustomerNameTxt.Text == null || CustomerAddressTxt.Text == null || CustomerPhoneTxt.Text == null ||
              CustomerTypecomboBox.SelectedItem == null)

            {
                MessageBox.Show("يجب ان تدخل كل البيانات");
            }
            else
            {
                // add
                var nameFilter = store.customers.FirstOrDefault(p => p.Name == CustomerNameTxt.Text);
                if (nameFilter == null)
                {
                    var date = new DateTime();
                    Customers customers = new Customers();
                    customers.addrees = CustomerAddressTxt.Text;
                    customers.Name = CustomerNameTxt.Text;
                    customers.PurchaseDate = date;
                    customers.Phone = CustomerPhoneTxt.Text;
                    // employee.Salary = float.Parse(Txt_EmployeeSalary.Text);
                    customers.type = CustomerTypecomboBox.SelectedItem.ToString();
                    customers.Status = false;

                    store.customers.Add(customers);

                    store.SaveChanges();
                    MessageBox.Show("تم الحفظ بنجاح");
                    CustomerNameTxt.Text = "";
                    CustomerAddressTxt.Text = "";
                    CustomerPhoneTxt.Text = "";
                    bindGridView();
                }
                else
                {
                    MessageBox.Show("هذا الموظف  موجود  بالفعل");
                    CustomerNameTxt.Text = null;
                    // AllPro allPro = new AllPro();
                }
            }
        }

        private void BtupdateCustomer_Click(object sender, EventArgs e)
        {
            if (CustomerNameTxt.Text == null || CustomerAddressTxt.Text == null || CustomerPhoneTxt.Text == null ||
               CustomerTypecomboBox.SelectedItem == null)

            {
                MessageBox.Show("يجب ان تدخل كل البيانات");
            }
            else
            {
                store = new store();
                p_id = int.Parse(DGV_Customer.SelectedRows[0].Cells[0].Value.ToString());
                var query = store.customers.FirstOrDefault(p => p.ID == p_id);
                query.Name = CustomerNameTxt.Text.ToString();
                query.addrees = CustomerAddressTxt.Text.ToString();
                query.Phone = CustomerPhoneTxt.Text.ToString();
                query.type = CustomerTypecomboBox.SelectedItem.ToString();
                store.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
                CustomerNameTxt.Text = "";
                CustomerAddressTxt.Text = "";
                CustomerPhoneTxt.Text = "";
                bindGridView();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXT_customerSearch_Click(object sender, EventArgs e)
        {
            // search


        }

        private void CustomerForm1_Load_1(object sender, EventArgs e)
        {
            bindGridView();
        }

        private void bt_resCustomer_Click(object sender, EventArgs e)
        {
            CustomerNameTxt.Text = "";
            CustomerAddressTxt.Text = "";
            CustomerPhoneTxt.Text = "";
        }

        private void CustomerTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXT_customerSearch_TextChanged(object sender, EventArgs e)
        {
            store = new store();
            var query = store.customers.Where(p => p.Status == false && p.Name.Contains(TXT_customerSearch.Text)).ToList();

            if (query.Count != 0)
            {

                DGV_Customer.RowCount = query.Count;

                int i = 0;
                foreach (var item in query)
                {
                    DGV_Customer.Rows[i].Cells[0].Value = item.ID.ToString();
                    DGV_Customer.Rows[i].Cells[1].Value = item.Name.ToString();
                    DGV_Customer.Rows[i].Cells[2].Value = item.Phone.ToString();
                    // DGV_Customer.Rows[i].Cells[3].Value = item.a.ToString();
                    DGV_Customer.Rows[i].Cells[3].Value = item.addrees;

                    i++;
                }
            }
            else
            {

                DGV_Customer.Rows.Clear();
            }
        }

        private void CustomerPhoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void delCustomer_Click(object sender, EventArgs e)
        {
            store = new store();
            DGV_Customer.DataSource = null;
            DGV_Customer.Update();
            DGV_Customer.Refresh();
            var id = int.Parse(DGV_Customer.SelectedRows[0].Cells[0].Value.ToString());
            var query = store.customers.FirstOrDefault(p => p.ID == id);

            query.Status = true;
            store.SaveChanges();
            bindGridView();
        }

        private void bt_editCustomer_Click(object sender, EventArgs e)
        {
            //edit
            BtupdateCustomer.Show();
            bt_addCustomer.Hide();
            if (DGV_Customer.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار منتج من المنتجات");
                bt_addCustomer.Show();
            }
            else
            {
                p_id = int.Parse(DGV_Customer.SelectedRows[0].Cells[0].Value.ToString());
                var query = store.customers.FirstOrDefault(p => p.ID == p_id);

                CustomerNameTxt.Text = query.Name;
                CustomerPhoneTxt.Text = query.Phone;
                CustomerAddressTxt.Text = query.addrees;
                CustomerTypecomboBox.SelectedValue = query.type.ToString();

            }
        }
    }
}
