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
    public partial class EmployeeFormNew : Form
    {
        store store = new store();
        public int p_id { get; set; }

        public EmployeeFormNew()
        {
            InitializeComponent();
        }


        public void bindGridView()
        {
           // Btn_SaveEmp.Show();
            UpdateBtnEmployee.Hide();
            DGV_EmployeeHome.DataSource = null;
            DGV_EmployeeHome.Refresh();
            store = new store();
            var query = store.employee.Where(p => p.Status == false).ToList();
            DGV_EmployeeHome.RowCount = query.Count;


            if (query.Count != 0)
            {

                DGV_EmployeeHome.RowCount = query.Count;


                int i = 0;
                foreach (var item in query)
                {
                    DGV_EmployeeHome.Rows[i].Cells[4].Value = item.ID.ToString();
                    DGV_EmployeeHome.Rows[i].Cells[3].Value = item.EmployeeName.ToString();
                    DGV_EmployeeHome.Rows[i].Cells[1].Value = item.Salary.ToString();
                    DGV_EmployeeHome.Rows[i].Cells[2].Value = item.Phone.ToString();
                    DGV_EmployeeHome.Rows[i].Cells[0].Value = item.Address;

                    i++;
                }
            
        }
    }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            // text changed
            store = new store();
            var query = store.employee.Where(p => p.Status == false && p.EmployeeName.Contains(textBox1.Text)).ToList();


            if (query.Count != 0)
            {

                DGV_EmployeeHome.RowCount = query.Count;


                int i = 0;
                foreach (var item in query)
                {
                    DGV_EmployeeHome.Rows[i].Cells[4].Value = item.ID.ToString();
                    DGV_EmployeeHome.Rows[i].Cells[3].Value = item.EmployeeName.ToString();
                    DGV_EmployeeHome.Rows[i].Cells[1].Value = item.Salary.ToString();
                    DGV_EmployeeHome.Rows[i].Cells[2].Value = item.Phone.ToString();
                    DGV_EmployeeHome.Rows[i].Cells[0].Value = item.Address;

                    i++;
                }
            }
            else
            {

                DGV_EmployeeHome.Rows.Clear();
            }
        }

        private void EmployeeFormNew_Load(object sender, EventArgs e)
        {
            // load
            bindGridView();
            DGV_EmployeeHome.Refresh();
        }

        private void DGV_EmployeeHome_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // rowheader
            deleteBtnEmp.Show();
            editBtnEmp.Show();
        }

        private void editBtnEmp_Click_1(object sender, EventArgs e)
        {
            // edit
            if (DGV_EmployeeHome.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار موظف من الموظفين");
            }
            else
            {
                if (Txt_Ee.Visible == false)
                {
                    Txt_Ee.Show();
                }
                if(Btn_SaveEmp.Visible == true)
                {
                    Btn_SaveEmp.Hide();
                }
                UpdateBtnEmployee.Show();
                Btn_SaveEmp.Hide();
                p_id = int.Parse(DGV_EmployeeHome.SelectedRows[0].Cells[4].Value.ToString());
                var query = store.employee.FirstOrDefault(p => p.ID == p_id);
                EmployeeNamrTxt.Text = query.EmployeeName;
                EmployeeAddressTxt.Text = query.Address;
                EmployeePhoneTxt.Text = query.Phone;
                EmployeeSalaryTxt.Text = query.Salary.ToString();
                EmployeeNationalIDTxt.Text = query.NationalId;
            }
        }

        private void deleteBtnEmp_Click_1(object sender, EventArgs e)
        {
            store = new store();
            DGV_EmployeeHome.DataSource = null;
            DGV_EmployeeHome.Update();
            DGV_EmployeeHome.Refresh();
            var id = int.Parse(DGV_EmployeeHome.SelectedRows[0].Cells[4].Value.ToString());
            var query = store.employee.FirstOrDefault(p => p.ID == id);

            query.Status = true;
            store.SaveChanges();
            bindGridView();
        }

        private void BtnAddEmp_Click_1(object sender, EventArgs e)
        {
            // add
            if (Txt_Ee.Visible == false)
            {
                Txt_Ee.Show();
                
            }
            if (Btn_SaveEmp.Visible == false)
            {
                Btn_SaveEmp.Show();
            }
            UpdateBtnEmployee.Hide();
            EmployeeAddressTxt.Text = "";
            EmployeeNamrTxt.Text = "";
            EmployeeSalaryTxt.Text = "";
            EmployeeNationalIDTxt.Text = "";
            EmployeePhoneTxt.Text = "";
        }

        private void UpdateBtnEmployee_Click_1(object sender, EventArgs e)
        {
            // save
            var query = store.employee.FirstOrDefault(p => p.ID == p_id);
            query.EmployeeName = EmployeeNamrTxt.Text.ToString();
            query.Address = EmployeeAddressTxt.Text.ToString();
            query.NationalId = EmployeeNationalIDTxt.Text.ToString();
            query.Salary = float.Parse(EmployeeSalaryTxt.Text.ToString());
            query.Phone = EmployeePhoneTxt.Text.ToString();
            store.SaveChanges();
            bindGridView();
            EmployeeAddressTxt.Text = "";
            EmployeeNamrTxt.Text = "";
            EmployeeSalaryTxt.Text = "";
            EmployeeNationalIDTxt.Text = "";
            EmployeePhoneTxt.Text = "";
            UpdateBtnEmployee.Show();

        }

        private void Btn_SaveEmp_Click_1(object sender, EventArgs e)
        {
            // save

            if (Btn_SaveEmp.Visible == false)
            {
                Btn_SaveEmp.Show();
            }
                UpdateBtnEmployee.Hide();
                var nameFilter = store.employee.FirstOrDefault(p => p.EmployeeName == EmployeeNamrTxt.Text);
                if (nameFilter == null)
                {
                    Employee employee = new Employee();
                    employee.Address = EmployeeAddressTxt.Text;
                    employee.NationalId = EmployeeNationalIDTxt.Text;
                    employee.EmployeeName = EmployeeNamrTxt.Text;
                    employee.HireDate = Txt_EmployeeHireDate.Value;
                    employee.Phone = EmployeePhoneTxt.Text;
                    employee.Salary = float.Parse(EmployeeSalaryTxt.Text);
                    store.employee.Add(employee);
                    store.SaveChanges();
                    bindGridView();
                    EmployeeAddressTxt.Text = "";
                    EmployeeNamrTxt.Text = "";
                    EmployeeSalaryTxt.Text = "";
                    EmployeeNationalIDTxt.Text = "";
                    EmployeePhoneTxt.Text = "";
            }
                else
                {
                    MessageBox.Show("هذا الموظف  موجود  بالفعل");
                    EmployeeNamrTxt.Text = null;
                    // AllPro allPro = new AllPro();
                }
            
        }
   

        private void EmployeePhoneTxt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EmployeeSalaryTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EmployeeNationalIDTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
