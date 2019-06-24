namespace StoreCSharpProject
{
    partial class SupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_SupplierHome = new System.Windows.Forms.DataGridView();
            this.supplieraddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyRep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppllierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtnSupplier = new MetroFramework.Controls.MetroButton();
            this.deleteBtnSupplier = new MetroFramework.Controls.MetroButton();
            this.textBox1Supplier = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Txt_companyReponSupplier = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Txt_SupplierAdress = new MetroFramework.Controls.MetroTextBox();
            this.Txt_SupplierPhone = new MetroFramework.Controls.MetroTextBox();
            this.Txt_SupplierName = new MetroFramework.Controls.MetroTextBox();
            this.Btn_SaveSupplier = new MetroFramework.Controls.MetroButton();
            this.btn_supplier_add = new MetroFramework.Controls.MetroButton();
            this.panel_add_Edit_Supplier = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SupplierHome)).BeginInit();
            this.panel_add_Edit_Supplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_SupplierHome
            // 
            this.DGV_SupplierHome.AllowUserToAddRows = false;
            this.DGV_SupplierHome.AllowUserToDeleteRows = false;
            this.DGV_SupplierHome.BackgroundColor = System.Drawing.Color.White;
            this.DGV_SupplierHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SupplierHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplieraddress,
            this.supplierPhone,
            this.companyRep,
            this.SuppllierName,
            this.NumberSupplier});
            this.DGV_SupplierHome.Location = new System.Drawing.Point(428, 152);
            this.DGV_SupplierHome.Name = "DGV_SupplierHome";
            this.DGV_SupplierHome.ReadOnly = true;
            this.DGV_SupplierHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SupplierHome.Size = new System.Drawing.Size(753, 458);
            this.DGV_SupplierHome.TabIndex = 35;
            this.DGV_SupplierHome.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_SupplierHome_RowHeaderMouseClick);
            // 
            // supplieraddress
            // 
            this.supplieraddress.HeaderText = "العنوان";
            this.supplieraddress.Name = "supplieraddress";
            this.supplieraddress.ReadOnly = true;
            this.supplieraddress.Width = 150;
            // 
            // supplierPhone
            // 
            this.supplierPhone.HeaderText = "رقم التليفون";
            this.supplierPhone.Name = "supplierPhone";
            this.supplierPhone.ReadOnly = true;
            this.supplierPhone.Width = 150;
            // 
            // companyRep
            // 
            this.companyRep.HeaderText = "مندوب الشركة";
            this.companyRep.Name = "companyRep";
            this.companyRep.ReadOnly = true;
            this.companyRep.Width = 150;
            // 
            // SuppllierName
            // 
            this.SuppllierName.HeaderText = "اسم الشركة";
            this.SuppllierName.Name = "SuppllierName";
            this.SuppllierName.ReadOnly = true;
            this.SuppllierName.Width = 200;
            // 
            // NumberSupplier
            // 
            this.NumberSupplier.HeaderText = "الرقم";
            this.NumberSupplier.Name = "NumberSupplier";
            this.NumberSupplier.ReadOnly = true;
            this.NumberSupplier.Width = 50;
            // 
            // editBtnSupplier
            // 
            this.editBtnSupplier.Location = new System.Drawing.Point(1080, 85);
            this.editBtnSupplier.Name = "editBtnSupplier";
            this.editBtnSupplier.Size = new System.Drawing.Size(70, 40);
            this.editBtnSupplier.TabIndex = 39;
            this.editBtnSupplier.Text = "تعديل";
            this.editBtnSupplier.Visible = false;
            this.editBtnSupplier.Click += new System.EventHandler(this.editBtnSupplier_Click);
            // 
            // deleteBtnSupplier
            // 
            this.deleteBtnSupplier.Location = new System.Drawing.Point(946, 85);
            this.deleteBtnSupplier.Name = "deleteBtnSupplier";
            this.deleteBtnSupplier.Size = new System.Drawing.Size(70, 40);
            this.deleteBtnSupplier.TabIndex = 38;
            this.deleteBtnSupplier.Text = "مسح";
            this.deleteBtnSupplier.Visible = false;
            this.deleteBtnSupplier.Click += new System.EventHandler(this.deleteBtnSupplier_Click);
            // 
            // textBox1Supplier
            // 
            this.textBox1Supplier.Location = new System.Drawing.Point(445, 84);
            this.textBox1Supplier.Multiline = true;
            this.textBox1Supplier.Name = "textBox1Supplier";
            this.textBox1Supplier.Size = new System.Drawing.Size(209, 48);
            this.textBox1Supplier.TabIndex = 36;
            this.textBox1Supplier.TextChanged += new System.EventHandler(this.textBox1Supplier_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(230, 235);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 47;
            this.metroLabel4.Text = "مندوب الشركة";
            // 
            // Txt_companyReponSupplier
            // 
            this.Txt_companyReponSupplier.Location = new System.Drawing.Point(74, 231);
            this.Txt_companyReponSupplier.Name = "Txt_companyReponSupplier";
            this.Txt_companyReponSupplier.Size = new System.Drawing.Size(142, 23);
            this.Txt_companyReponSupplier.TabIndex = 46;
            this.Txt_companyReponSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(261, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 43;
            this.metroLabel2.Text = ":العنوان ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(242, 184);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 44;
            this.metroLabel3.Text = "رقم التليفون";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(244, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "اسم الشركة";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_SupplierAdress
            // 
            this.Txt_SupplierAdress.Location = new System.Drawing.Point(74, 123);
            this.Txt_SupplierAdress.Name = "Txt_SupplierAdress";
            this.Txt_SupplierAdress.Size = new System.Drawing.Size(142, 23);
            this.Txt_SupplierAdress.TabIndex = 40;
            this.Txt_SupplierAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_SupplierPhone
            // 
            this.Txt_SupplierPhone.Location = new System.Drawing.Point(74, 180);
            this.Txt_SupplierPhone.Name = "Txt_SupplierPhone";
            this.Txt_SupplierPhone.Size = new System.Drawing.Size(142, 23);
            this.Txt_SupplierPhone.TabIndex = 41;
            this.Txt_SupplierPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_SupplierPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SupplierPhone_KeyPress);
            // 
            // Txt_SupplierName
            // 
            this.Txt_SupplierName.Location = new System.Drawing.Point(74, 81);
            this.Txt_SupplierName.Name = "Txt_SupplierName";
            this.Txt_SupplierName.Size = new System.Drawing.Size(142, 23);
            this.Txt_SupplierName.TabIndex = 42;
            this.Txt_SupplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_SaveSupplier
            // 
            this.Btn_SaveSupplier.Location = new System.Drawing.Point(141, 308);
            this.Btn_SaveSupplier.Name = "Btn_SaveSupplier";
            this.Btn_SaveSupplier.Size = new System.Drawing.Size(75, 23);
            this.Btn_SaveSupplier.TabIndex = 48;
            this.Btn_SaveSupplier.Text = "حفظ";
            this.Btn_SaveSupplier.Click += new System.EventHandler(this.Btn_SaveSupplier_Click);
            // 
            // btn_supplier_add
            // 
            this.btn_supplier_add.Location = new System.Drawing.Point(801, 85);
            this.btn_supplier_add.Name = "btn_supplier_add";
            this.btn_supplier_add.Size = new System.Drawing.Size(70, 40);
            this.btn_supplier_add.TabIndex = 49;
            this.btn_supplier_add.Text = "إضافة";
            this.btn_supplier_add.Click += new System.EventHandler(this.btn_supplier_add_Click);
            // 
            // panel_add_Edit_Supplier
            // 
            this.panel_add_Edit_Supplier.Controls.Add(this.Txt_SupplierName);
            this.panel_add_Edit_Supplier.Controls.Add(this.Txt_SupplierPhone);
            this.panel_add_Edit_Supplier.Controls.Add(this.Btn_SaveSupplier);
            this.panel_add_Edit_Supplier.Controls.Add(this.Txt_SupplierAdress);
            this.panel_add_Edit_Supplier.Controls.Add(this.metroLabel4);
            this.panel_add_Edit_Supplier.Controls.Add(this.metroLabel1);
            this.panel_add_Edit_Supplier.Controls.Add(this.Txt_companyReponSupplier);
            this.panel_add_Edit_Supplier.Controls.Add(this.metroLabel3);
            this.panel_add_Edit_Supplier.Controls.Add(this.metroLabel2);
            this.panel_add_Edit_Supplier.Location = new System.Drawing.Point(12, 152);
            this.panel_add_Edit_Supplier.Name = "panel_add_Edit_Supplier";
            this.panel_add_Edit_Supplier.Size = new System.Drawing.Size(375, 404);
            this.panel_add_Edit_Supplier.TabIndex = 50;
            this.panel_add_Edit_Supplier.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Arabic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "بحث";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_add_Edit_Supplier);
            this.Controls.Add(this.btn_supplier_add);
            this.Controls.Add(this.DGV_SupplierHome);
            this.Controls.Add(this.editBtnSupplier);
            this.Controls.Add(this.deleteBtnSupplier);
            this.Controls.Add(this.textBox1Supplier);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SupplierHome)).EndInit();
            this.panel_add_Edit_Supplier.ResumeLayout(false);
            this.panel_add_Edit_Supplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_SupplierHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieraddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyRep;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppllierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberSupplier;
        public MetroFramework.Controls.MetroButton editBtnSupplier;
        public MetroFramework.Controls.MetroButton deleteBtnSupplier;
        private System.Windows.Forms.TextBox textBox1Supplier;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox Txt_companyReponSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Txt_SupplierAdress;
        private MetroFramework.Controls.MetroTextBox Txt_SupplierPhone;
        private MetroFramework.Controls.MetroTextBox Txt_SupplierName;
        public MetroFramework.Controls.MetroButton Btn_SaveSupplier;
        private MetroFramework.Controls.MetroButton btn_supplier_add;
        private System.Windows.Forms.Panel panel_add_Edit_Supplier;
        private System.Windows.Forms.Label label1;
    }
}