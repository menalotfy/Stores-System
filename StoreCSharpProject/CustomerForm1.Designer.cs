namespace StoreCSharpProject
{
    partial class CustomerForm1
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
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.customerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtupdateCustomer = new MetroFramework.Controls.MetroButton();
            this.bt_addCustomer = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_customerSearch = new MetroFramework.Controls.MetroTextBox();
            this.CustomerTypecomboBox = new System.Windows.Forms.ComboBox();
            this.CustomerAddressTxt = new MetroFramework.Controls.MetroTextBox();
            this.CustomerPhoneTxt = new MetroFramework.Controls.MetroTextBox();
            this.CustomerNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.delCustomer = new System.Windows.Forms.Button();
            this.bt_editCustomer = new System.Windows.Forms.Button();
            this.bt_resCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.AllowUserToAddRows = false;
            this.DGV_Customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerPhone,
            this.customerAddress,
            this.customerName,
            this.CustomerID});
            this.DGV_Customer.Location = new System.Drawing.Point(594, 228);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.ReadOnly = true;
            this.DGV_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Customer.Size = new System.Drawing.Size(653, 432);
            this.DGV_Customer.TabIndex = 30;
            // 
            // customerPhone
            // 
            this.customerPhone.FillWeight = 150F;
            this.customerPhone.HeaderText = "رقم التليفون";
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.ReadOnly = true;
            this.customerPhone.Width = 200;
            // 
            // customerAddress
            // 
            this.customerAddress.HeaderText = "العنوان";
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.ReadOnly = true;
            this.customerAddress.Width = 200;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "الاسم";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 200;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtupdateCustomer);
            this.panel1.Controls.Add(this.bt_addCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TXT_customerSearch);
            this.panel1.Controls.Add(this.CustomerTypecomboBox);
            this.panel1.Controls.Add(this.CustomerAddressTxt);
            this.panel1.Controls.Add(this.CustomerPhoneTxt);
            this.panel1.Controls.Add(this.CustomerNameTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 206);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1162, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 49;
            this.label5.Text = ":العنوان ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(755, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "رقم التليفون";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(755, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "نوع العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1162, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = " : الاسم";
            // 
            // BtupdateCustomer
            // 
            this.BtupdateCustomer.Highlight = true;
            this.BtupdateCustomer.Location = new System.Drawing.Point(816, 143);
            this.BtupdateCustomer.Name = "BtupdateCustomer";
            this.BtupdateCustomer.Size = new System.Drawing.Size(122, 48);
            this.BtupdateCustomer.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtupdateCustomer.TabIndex = 45;
            this.BtupdateCustomer.Text = "حفظ";
            this.BtupdateCustomer.Visible = false;
            this.BtupdateCustomer.Click += new System.EventHandler(this.BtupdateCustomer_Click);
            // 
            // bt_addCustomer
            // 
            this.bt_addCustomer.Highlight = true;
            this.bt_addCustomer.Location = new System.Drawing.Point(816, 143);
            this.bt_addCustomer.Name = "bt_addCustomer";
            this.bt_addCustomer.Size = new System.Drawing.Size(122, 48);
            this.bt_addCustomer.Style = MetroFramework.MetroColorStyle.Blue;
            this.bt_addCustomer.TabIndex = 42;
            this.bt_addCustomer.Text = "حفظ";
            this.bt_addCustomer.Click += new System.EventHandler(this.bt_addCustomer_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(78, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 36);
            this.label1.TabIndex = 44;
            this.label1.Text = "       بحث       ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT_customerSearch
            // 
            this.TXT_customerSearch.Location = new System.Drawing.Point(33, 84);
            this.TXT_customerSearch.Name = "TXT_customerSearch";
            this.TXT_customerSearch.Size = new System.Drawing.Size(263, 40);
            this.TXT_customerSearch.TabIndex = 43;
            this.TXT_customerSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_customerSearch.TextChanged += new System.EventHandler(this.TXT_customerSearch_TextChanged);
            this.TXT_customerSearch.Click += new System.EventHandler(this.TXT_customerSearch_Click);
            // 
            // CustomerTypecomboBox
            // 
            this.CustomerTypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTypecomboBox.FormattingEnabled = true;
            this.CustomerTypecomboBox.Items.AddRange(new object[] {
            "قطاعي",
            "جملة"});
            this.CustomerTypecomboBox.Location = new System.Drawing.Point(524, 84);
            this.CustomerTypecomboBox.Name = "CustomerTypecomboBox";
            this.CustomerTypecomboBox.Size = new System.Drawing.Size(209, 28);
            this.CustomerTypecomboBox.TabIndex = 40;
            this.CustomerTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerTypecomboBox_SelectedIndexChanged);
            // 
            // CustomerAddressTxt
            // 
            this.CustomerAddressTxt.Location = new System.Drawing.Point(920, 77);
            this.CustomerAddressTxt.Name = "CustomerAddressTxt";
            this.CustomerAddressTxt.Size = new System.Drawing.Size(205, 30);
            this.CustomerAddressTxt.TabIndex = 34;
            this.CustomerAddressTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomerPhoneTxt
            // 
            this.CustomerPhoneTxt.Location = new System.Drawing.Point(524, 33);
            this.CustomerPhoneTxt.Name = "CustomerPhoneTxt";
            this.CustomerPhoneTxt.Size = new System.Drawing.Size(209, 30);
            this.CustomerPhoneTxt.TabIndex = 35;
            this.CustomerPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerPhoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerPhoneTxt_KeyPress);
            // 
            // CustomerNameTxt
            // 
            this.CustomerNameTxt.Location = new System.Drawing.Point(920, 28);
            this.CustomerNameTxt.Name = "CustomerNameTxt";
            this.CustomerNameTxt.Size = new System.Drawing.Size(205, 30);
            this.CustomerNameTxt.TabIndex = 36;
            this.CustomerNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delCustomer
            // 
            this.delCustomer.BackColor = System.Drawing.Color.Red;
            this.delCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCustomer.ForeColor = System.Drawing.Color.White;
            this.delCustomer.Location = new System.Drawing.Point(173, 528);
            this.delCustomer.Name = "delCustomer";
            this.delCustomer.Size = new System.Drawing.Size(123, 51);
            this.delCustomer.TabIndex = 38;
            this.delCustomer.Text = "حذف";
            this.delCustomer.UseVisualStyleBackColor = false;
            this.delCustomer.Click += new System.EventHandler(this.delCustomer_Click);
            // 
            // bt_editCustomer
            // 
            this.bt_editCustomer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_editCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editCustomer.ForeColor = System.Drawing.Color.White;
            this.bt_editCustomer.Location = new System.Drawing.Point(173, 346);
            this.bt_editCustomer.Name = "bt_editCustomer";
            this.bt_editCustomer.Size = new System.Drawing.Size(123, 47);
            this.bt_editCustomer.TabIndex = 39;
            this.bt_editCustomer.Text = "تعديل";
            this.bt_editCustomer.UseVisualStyleBackColor = false;
            this.bt_editCustomer.Click += new System.EventHandler(this.bt_editCustomer_Click);
            // 
            // bt_resCustomer
            // 
            this.bt_resCustomer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_resCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_resCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_resCustomer.ForeColor = System.Drawing.Color.White;
            this.bt_resCustomer.Location = new System.Drawing.Point(173, 444);
            this.bt_resCustomer.Name = "bt_resCustomer";
            this.bt_resCustomer.Size = new System.Drawing.Size(123, 47);
            this.bt_resCustomer.TabIndex = 40;
            this.bt_resCustomer.Text = "إلغاء";
            this.bt_resCustomer.UseVisualStyleBackColor = false;
            // 
            // CustomerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 672);
            this.Controls.Add(this.bt_resCustomer);
            this.Controls.Add(this.bt_editCustomer);
            this.Controls.Add(this.delCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_Customer);
            this.Name = "CustomerForm1";
            this.Text = "CustomerForm1";
            this.Load += new System.EventHandler(this.CustomerForm1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView DGV_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton bt_addCustomer;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox TXT_customerSearch;
        private System.Windows.Forms.ComboBox CustomerTypecomboBox;
        private MetroFramework.Controls.MetroTextBox CustomerAddressTxt;
        private MetroFramework.Controls.MetroTextBox CustomerPhoneTxt;
        private MetroFramework.Controls.MetroTextBox CustomerNameTxt;
        private MetroFramework.Controls.MetroButton BtupdateCustomer;
        private System.Windows.Forms.Button delCustomer;
        private System.Windows.Forms.Button bt_editCustomer;
        private System.Windows.Forms.Button bt_resCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}