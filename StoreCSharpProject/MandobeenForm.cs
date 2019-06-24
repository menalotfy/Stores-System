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
    public partial class MandobeenForm : Form
    {
        store store = new store();
        public int p_id { get; set; }
        AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

        public MandobeenForm()
        {
            InitializeComponent();
        }

        public void bindGridView()
        {
            bt_addCustomer.Show();
            BtupdateCustomer.Hide();
            DGV_Customer.Rows.Clear();

            store = new store();

            var query = (from s in store.SalesRepresentatives
                         from m in store.employee
                         where (s.Employee_Id == m.ID && s.status == false)
                         select new { m, s }
                         ).ToList();
            if (query.Count != 0)
            {

                DGV_Customer.RowCount = query.Count;


                int i = 0;
                foreach (var item in query)
                {



                    DGV_Customer.Rows[i].Cells[0].Value = item.s.ID.ToString();
                    DGV_Customer.Rows[i].Cells[1].Value = item.m.EmployeeName.ToString();

                    DGV_Customer.Rows[i].Cells[2].Value = item.m.Phone.ToString();
                    DGV_Customer.Rows[i].Cells[3].Value = item.m.Address;

                    i++;
                }
            }
            DGV_Customer.Refresh();
            DGV_Customer.Update();
        }


        private void BtupdateCustomer_Click(object sender, EventArgs e)
        {
            var query2 = store.employee.FirstOrDefault(m => m.EmployeeName == MandobNametextBox1.Text);
            var check = store.SalesRepresentatives.FirstOrDefault(s => s.Employee_Id == query2.ID);
            if (check != null)
            {
                store = new store();
                p_id = int.Parse(DGV_Customer.SelectedRows[0].Cells[0].Value.ToString());
                var query = store.SalesRepresentatives.FirstOrDefault(p => p.ID == p_id);
                var q = store.employee.FirstOrDefault(m => m.ID == query.Employee_Id);
                q.EmployeeName = MandobNametextBox1.Text.ToString();
                q.Address = CustomerAddressTxt.Text.ToString();
                q.Phone = CustomerPhoneTxt.Text.ToString();

                store.SaveChanges();
                
                bindGridView();
                CustomerAddressTxt.Text = "";
                CustomerPhoneTxt.Text = "";
                MandobNametextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("هذا المندوب موجود  بالفعل");
                MandobNametextBox1.Text = "";
            }
        }

        private void MandobeenForm_Load(object sender, EventArgs e)
        {
            bindGridView();
            List<string> query = (from s in store.SalesRepresentatives
                                  from m in store.employee
                                  where (s.Employee_Id == m.ID)
                                  select m.EmployeeName
                          ).ToList();
            AutoCompleteStringCollection names = new AutoCompleteStringCollection();
            foreach (var item in query)
            {
                names.Add(item);
            }
            MandobNametextBox1.AutoCompleteCustomSource.AddRange(query.ToArray());
        }

        private void TXT_customerSearch_TextChanged(object sender, EventArgs e)
        {
            store = new store();
            var query = (from s in store.SalesRepresentatives
                         from m in store.employee
                         where (s.Employee_Id == m.ID && s.status == false && m.EmployeeName.Contains(TXT_customerSearch.Text))
                         select new { s, m }
                                    ).ToList();

            if (query.Count != 0)
            {

                DGV_Customer.RowCount = query.Count;


                int i = 0;
                foreach (var item in query)
                {



                    DGV_Customer.Rows[i].Cells[0].Value = item.s.ID.ToString();
                    DGV_Customer.Rows[i].Cells[1].Value = item.m.EmployeeName.ToString();

                    DGV_Customer.Rows[i].Cells[2].Value = item.m.Phone.ToString();
                    DGV_Customer.Rows[i].Cells[3].Value = item.m.Address;

                    i++;
                }
            }
            else
            {

                DGV_Customer.Rows.Clear();
            }
        }

        private void showAddCustomerBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_editCustomer_Click(object sender, EventArgs e)
        {

            
        }

        private void delCustomer_Click(object sender, EventArgs e)
        {
        
        }

        private void bt_addCustomer_Click(object sender, EventArgs e)
        {
            var query = store.employee.FirstOrDefault(m => m.EmployeeName == MandobNametextBox1.Text);
            var check = store.SalesRepresentatives.FirstOrDefault(s => s.Employee_Id == query.ID);
            if (check == null)
            {

                SalesRepresentative SalesRepresentative = new SalesRepresentative();
                SalesRepresentative.Employee_Id = query.ID;
                SalesRepresentative.status = false;
                store.SalesRepresentatives.Add(SalesRepresentative);
                store.SaveChanges();
                bindGridView();
            }
            else
            {
                MessageBox.Show("هذا المندوب موجود  بالفعل");
                MandobNametextBox1.Text = "";
            }
        }

        private void DGV_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MandobNametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGV_Customer.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار المندوب من المندوبين");
                bt_addCustomer.Show();
            }
            store = new store();
            DGV_Customer.DataSource = null;
            DGV_Customer.Update();
            DGV_Customer.Refresh();
            var id = int.Parse(DGV_Customer.SelectedRows[0].Cells[0].Value.ToString());
            var query = store.SalesRepresentatives.FirstOrDefault(p => p.ID == id);

            query.status = true;
            store.SaveChanges();
            bindGridView();
        }

        private void bt_editCustomer_Click_1(object sender, EventArgs e)
        {
            if (DGV_Customer.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار المندوب من المندوبين");
                bt_addCustomer.Show();
            }
            else

            {
                metroPanel1.Show();
                BtupdateCustomer.Show();
                bt_addCustomer.Hide();
                CustomerAddressTxt.Visible = true;
                CustomerPhoneTxt.Visible = true;
                addressLabel.Visible = true;
                phoneLabel.Visible = true;
                p_id = int.Parse(DGV_Customer.SelectedRows[0].Cells[0].Value.ToString());
                var query = store.SalesRepresentatives.FirstOrDefault(p => p.ID == p_id);

                MandobNametextBox1.Text = query.Employee.EmployeeName;
                CustomerPhoneTxt.Text = query.Employee.Phone;
                CustomerAddressTxt.Text = query.Employee.Address;


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            metroPanel1.Show();
            BtupdateCustomer.Hide();
            bt_addCustomer.Show();
            CustomerAddressTxt.Visible = false;
            CustomerPhoneTxt.Visible = false;
            addressLabel.Visible = false;
            phoneLabel.Visible = false;
        }
    }
}
