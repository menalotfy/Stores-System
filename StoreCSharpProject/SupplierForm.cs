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
    public partial class SupplierForm : Form
    {
        store store = new store();
        bool flagSave = false;

        public SupplierForm()
        {
            InitializeComponent();
        }

        private void btn_supplier_add_Click(object sender, EventArgs e)
        {
            panel_add_Edit_Supplier.Show();
            flagSave = false;
            Txt_companyReponSupplier.Text = "";
            Txt_SupplierAdress.Text = "";
            Txt_SupplierName.Text = "";
            Txt_SupplierPhone.Text = "";
            //Btn_SaveSupplier.Show();
            //metroLabel1.Show();
            //metroLabel2.Show();
            //metroLabel3.Show();
            //metroLabel4.Show();
            
            //if(flagSave == false)
            //{
            //    btn_supplier_add.Show();
            //}
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridViewSupplier();

        }

        public void RefreshDataGridViewSupplier()
        {
            store = new store();

            var query = (from p in store.suppliers
                         where (p.status == false)
                         select new { p }
                   ).ToList();
            DGV_SupplierHome.RowCount = query.Count;
            int i = 0;
            foreach (var item in query)
            {
                DGV_SupplierHome.Rows[i].Cells[0].Value = item.p.Address;
                DGV_SupplierHome.Rows[i].Cells[1].Value = item.p.SupplierPhone.ToString();
                DGV_SupplierHome.Rows[i].Cells[2].Value = item.p.CompanyRepresentative.ToString();
                DGV_SupplierHome.Rows[i].Cells[3].Value = item.p.Name.ToString();
                DGV_SupplierHome.Rows[i].Cells[4].Value = item.p.ID.ToString();
                i++;
            }
        }

        private void DGV_SupplierHome_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deleteBtnSupplier.Show();
            editBtnSupplier.Show();
        }

        private void editBtnSupplier_Click(object sender, EventArgs e)
        {
            flagSave = true;
            if (DGV_SupplierHome.SelectedRows.Count == 0)
            {
                MessageBoxIcon.Warning.ToString();
                MessageBox.Show("يجب ان تختار مورد");
            }
            else
            {
                panel_add_Edit_Supplier.Show();
                Txt_SupplierName.Text = DGV_SupplierHome.SelectedRows[0].Cells[3].Value.ToString();
                Txt_companyReponSupplier.Text = DGV_SupplierHome.SelectedRows[0].Cells[2].Value.ToString();
                Txt_SupplierAdress.Text = DGV_SupplierHome.SelectedRows[0].Cells[0].Value.ToString();
                Txt_SupplierPhone.Text = DGV_SupplierHome.SelectedRows[0].Cells[1].Value.ToString();

                RefreshDataGridViewSupplier();
            }
        }

        private void deleteBtnSupplier_Click(object sender, EventArgs e)
        {
            store = new store();
            DGV_SupplierHome.DataSource = null;
            DGV_SupplierHome.Update();
            DGV_SupplierHome.Refresh();
            var id = int.Parse(DGV_SupplierHome.SelectedRows[0].Cells[4].Value.ToString());
            var query = store.suppliers.FirstOrDefault(p => p.ID == id);
            query.status = true;
            store.SaveChanges();
            RefreshDataGridViewSupplier();

        }

        private void textBox1Supplier_TextChanged(object sender, EventArgs e)
        {

            var query = (from p in store.suppliers
                         where (p.status == false && p.Name.Contains(textBox1Supplier.Text))
                         select new { p }
                       ).ToList();
            if (query.Count != 0)
            {

                DGV_SupplierHome.RowCount = query.Count;


                int i = 0;
                foreach (var item in query)
                {



                    DGV_SupplierHome.Rows[i].Cells[0].Value = item.p.Address;
                    DGV_SupplierHome.Rows[i].Cells[1].Value = item.p.SupplierPhone;
                    DGV_SupplierHome.Rows[i].Cells[2].Value = item.p.CompanyRepresentative;
                    DGV_SupplierHome.Rows[i].Cells[3].Value = item.p.Name;
                    DGV_SupplierHome.Rows[i].Cells[4].Value = item.p.ID;


                    i++;
                }
            }
            else
            {

                DGV_SupplierHome.Rows.Clear();
            }
        }

        private void SearchSupplierGridView_Click(object sender, EventArgs e)
        {

        }

        private void Btn_SaveSupplier_Click(object sender, EventArgs e)
        {
            if (Txt_SupplierName.Text == "" || Txt_SupplierPhone.Text == "" ||
            Txt_SupplierAdress.Text == "" ||
           Txt_companyReponSupplier.Text == "")
            {
                MessageBox.Show("يجب إدخال جميع البيانات بشكل صحيح");
            }
            else
            {
                if (flagSave == false)
                {
                    Suppliers suppliers = new Suppliers();
                    suppliers.Name = Txt_SupplierName.Text;
                    suppliers.SupplierPhone = Txt_SupplierPhone.Text;
                    suppliers.Address = Txt_SupplierAdress.Text;
                    suppliers.CompanyRepresentative = Txt_companyReponSupplier.Text;
                    store.suppliers.Add(suppliers);
                    store.SaveChanges();
                    Txt_companyReponSupplier.Text = "";
                    Txt_SupplierAdress.Text = "";
                    Txt_SupplierName.Text = "";
                    Txt_SupplierPhone.Text = "";
                    RefreshDataGridViewSupplier();
                }
                else
                {
                    int id = int.Parse(DGV_SupplierHome.SelectedRows[0].Cells[4].Value.ToString());
                    Suppliers suppliers = store.suppliers.FirstOrDefault(s => s.ID == id);
                    suppliers.Name = Txt_SupplierName.Text;
                    suppliers.SupplierPhone = Txt_SupplierPhone.Text;
                    suppliers.Address = Txt_SupplierAdress.Text;
                    suppliers.CompanyRepresentative = Txt_companyReponSupplier.Text;
                    store.SaveChanges();

                    Txt_companyReponSupplier.Text = "";
                    Txt_SupplierAdress.Text = "";
                    Txt_SupplierName.Text = "";
                    Txt_SupplierPhone.Text = "";

                    RefreshDataGridViewSupplier();
                }
            }
        }

        private void Txt_SupplierPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
