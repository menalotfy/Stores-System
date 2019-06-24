namespace StoreCSharpProject
{
    partial class MandobeenForm
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
            this.MandobNametextBox1 = new System.Windows.Forms.TextBox();
            this.BtupdateCustomer = new MetroFramework.Controls.MetroButton();
            this.bt_addCustomer = new MetroFramework.Controls.MetroButton();
            this.CustomerPhoneTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CustomerAddressTxt = new MetroFramework.Controls.MetroTextBox();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXT_customerSearch = new MetroFramework.Controls.MetroTextBox();
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delCustomer = new System.Windows.Forms.Button();
            this.showAddCustomerBtn = new System.Windows.Forms.Button();
            this.bt_editCustomer = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // MandobNametextBox1
            // 
            this.MandobNametextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MandobNametextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.MandobNametextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MandobNametextBox1.Location = new System.Drawing.Point(134, 14);
            this.MandobNametextBox1.Name = "MandobNametextBox1";
            this.MandobNametextBox1.Size = new System.Drawing.Size(259, 35);
            this.MandobNametextBox1.TabIndex = 10;
            this.MandobNametextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MandobNametextBox1.TextChanged += new System.EventHandler(this.MandobNametextBox1_TextChanged);
            // 
            // BtupdateCustomer
            // 
            this.BtupdateCustomer.Highlight = true;
            this.BtupdateCustomer.Location = new System.Drawing.Point(212, 202);
            this.BtupdateCustomer.Name = "BtupdateCustomer";
            this.BtupdateCustomer.Size = new System.Drawing.Size(122, 48);
            this.BtupdateCustomer.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtupdateCustomer.TabIndex = 9;
            this.BtupdateCustomer.Text = "حفظ";
            this.BtupdateCustomer.Visible = false;
            this.BtupdateCustomer.Click += new System.EventHandler(this.BtupdateCustomer_Click);
            // 
            // bt_addCustomer
            // 
            this.bt_addCustomer.Highlight = true;
            this.bt_addCustomer.Location = new System.Drawing.Point(212, 202);
            this.bt_addCustomer.Name = "bt_addCustomer";
            this.bt_addCustomer.Size = new System.Drawing.Size(122, 48);
            this.bt_addCustomer.Style = MetroFramework.MetroColorStyle.Blue;
            this.bt_addCustomer.TabIndex = 8;
            this.bt_addCustomer.Text = "حفظ";
            this.bt_addCustomer.Click += new System.EventHandler(this.bt_addCustomer_Click);
            // 
            // CustomerPhoneTxt
            // 
            this.CustomerPhoneTxt.Location = new System.Drawing.Point(134, 70);
            this.CustomerPhoneTxt.Name = "CustomerPhoneTxt";
            this.CustomerPhoneTxt.Size = new System.Drawing.Size(259, 30);
            this.CustomerPhoneTxt.TabIndex = 4;
            this.CustomerPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerPhoneTxt.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.phoneLabel);
            this.metroPanel1.Controls.Add(this.addressLabel);
            this.metroPanel1.Controls.Add(this.MandobNametextBox1);
            this.metroPanel1.Controls.Add(this.BtupdateCustomer);
            this.metroPanel1.Controls.Add(this.bt_addCustomer);
            this.metroPanel1.Controls.Add(this.CustomerAddressTxt);
            this.metroPanel1.Controls.Add(this.CustomerPhoneTxt);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(659, 197);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(588, 333);
            this.metroPanel1.TabIndex = 51;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // CustomerAddressTxt
            // 
            this.CustomerAddressTxt.Location = new System.Drawing.Point(134, 129);
            this.CustomerAddressTxt.Name = "CustomerAddressTxt";
            this.CustomerAddressTxt.Size = new System.Drawing.Size(259, 30);
            this.CustomerAddressTxt.TabIndex = 4;
            this.CustomerAddressTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CustomerAddressTxt.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // customerAddress
            // 
            this.customerAddress.HeaderText = "العنوان";
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.ReadOnly = true;
            this.customerAddress.Width = 200;
            // 
            // customerPhone
            // 
            this.customerPhone.FillWeight = 150F;
            this.customerPhone.HeaderText = "رقم التليفون";
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.ReadOnly = true;
            this.customerPhone.Width = 200;
            // 
            // TXT_customerSearch
            // 
            this.TXT_customerSearch.Location = new System.Drawing.Point(143, 61);
            this.TXT_customerSearch.Name = "TXT_customerSearch";
            this.TXT_customerSearch.Size = new System.Drawing.Size(263, 40);
            this.TXT_customerSearch.TabIndex = 46;
            this.TXT_customerSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_customerSearch.TextChanged += new System.EventHandler(this.TXT_customerSearch_TextChanged);
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.AllowUserToAddRows = false;
            this.DGV_Customer.AllowUserToDeleteRows = false;
            this.DGV_Customer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerPhone,
            this.customerAddress,
            this.customerName,
            this.CustomerID});
            this.DGV_Customer.Location = new System.Drawing.Point(5, 197);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.ReadOnly = true;
            this.DGV_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Customer.Size = new System.Drawing.Size(648, 333);
            this.DGV_Customer.TabIndex = 45;
            this.DGV_Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_CellContentClick);
            // 
            // customerName
            // 
            this.customerName.HeaderText = "الاسم";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 200;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.White;
            this.addressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(426, 136);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 23);
            this.addressLabel.TabIndex = 48;
            this.addressLabel.Text = ":العنوان ";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.White;
            this.phoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(407, 77);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(90, 23);
            this.phoneLabel.TabIndex = 49;
            this.phoneLabel.Text = "رقم التليفون";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 50;
            this.label2.Text = " : الاسم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 51;
            this.label3.Text = "بحث";
            // 
            // delCustomer
            // 
            this.delCustomer.BackColor = System.Drawing.Color.Red;
            this.delCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCustomer.ForeColor = System.Drawing.Color.White;
            this.delCustomer.Location = new System.Drawing.Point(62, 584);
            this.delCustomer.Name = "delCustomer";
            this.delCustomer.Size = new System.Drawing.Size(114, 41);
            this.delCustomer.TabIndex = 52;
            this.delCustomer.Text = "حذف";
            this.delCustomer.UseVisualStyleBackColor = false;
            this.delCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // showAddCustomerBtn
            // 
            this.showAddCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showAddCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAddCustomerBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAddCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.showAddCustomerBtn.Location = new System.Drawing.Point(412, 584);
            this.showAddCustomerBtn.Name = "showAddCustomerBtn";
            this.showAddCustomerBtn.Size = new System.Drawing.Size(114, 41);
            this.showAddCustomerBtn.TabIndex = 53;
            this.showAddCustomerBtn.Text = "اضافه";
            this.showAddCustomerBtn.UseVisualStyleBackColor = false;
            this.showAddCustomerBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt_editCustomer
            // 
            this.bt_editCustomer.BackColor = System.Drawing.Color.Blue;
            this.bt_editCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editCustomer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editCustomer.ForeColor = System.Drawing.Color.White;
            this.bt_editCustomer.Location = new System.Drawing.Point(237, 584);
            this.bt_editCustomer.Name = "bt_editCustomer";
            this.bt_editCustomer.Size = new System.Drawing.Size(114, 41);
            this.bt_editCustomer.TabIndex = 54;
            this.bt_editCustomer.Text = "تعديل";
            this.bt_editCustomer.UseVisualStyleBackColor = false;
            this.bt_editCustomer.Click += new System.EventHandler(this.bt_editCustomer_Click_1);
            // 
            // MandobeenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 700);
            this.Controls.Add(this.bt_editCustomer);
            this.Controls.Add(this.showAddCustomerBtn);
            this.Controls.Add(this.delCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.DGV_Customer);
            this.Controls.Add(this.TXT_customerSearch);
            this.Name = "MandobeenForm";
            this.Text = "MandobeenForm";
            this.Load += new System.EventHandler(this.MandobeenForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MandobNametextBox1;
        private MetroFramework.Controls.MetroButton BtupdateCustomer;
        private MetroFramework.Controls.MetroButton bt_addCustomer;
        private MetroFramework.Controls.MetroTextBox CustomerPhoneTxt;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox CustomerAddressTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhone;
        private MetroFramework.Controls.MetroTextBox TXT_customerSearch;
        public System.Windows.Forms.DataGridView DGV_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button delCustomer;
        private System.Windows.Forms.Button showAddCustomerBtn;
        private System.Windows.Forms.Button bt_editCustomer;
    }
}