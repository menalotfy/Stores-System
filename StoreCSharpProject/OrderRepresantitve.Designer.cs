namespace StoreCSharpProject
{
    partial class OrderRepresantitve
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.CMB_MndobName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericCountity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.DTV_ٍSpendDate = new System.Windows.Forms.DateTimePicker();
            this.DGV_SelectedProduct = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CMB_Catogry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_AddProductSpend = new System.Windows.Forms.Button();
            this.DGV_SpendProducts = new System.Windows.Forms.DataGridView();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SelectedProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SpendProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(49, 111);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(102, 48);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "مسح";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(711, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 183);
            this.panel2.TabIndex = 32;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(49, 13);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(102, 48);
            this.EditBtn.TabIndex = 0;
            this.EditBtn.Text = "تعديل";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click_1);
            // 
            // CMB_MndobName
            // 
            this.CMB_MndobName.FormattingEnabled = true;
            this.CMB_MndobName.Location = new System.Drawing.Point(620, 17);
            this.CMB_MndobName.Name = "CMB_MndobName";
            this.CMB_MndobName.Size = new System.Drawing.Size(199, 21);
            this.CMB_MndobName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "اسم المندوب";
            // 
            // numericCountity
            // 
            this.numericCountity.DecimalPlaces = 2;
            this.numericCountity.Location = new System.Drawing.Point(417, 141);
            this.numericCountity.Maximum = new decimal(new int[] {
            1110,
            0,
            0,
            0});
            this.numericCountity.Name = "numericCountity";
            this.numericCountity.Size = new System.Drawing.Size(199, 20);
            this.numericCountity.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "المنتجات";
            // 
            // DTV_ٍSpendDate
            // 
            this.DTV_ٍSpendDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTV_ٍSpendDate.Location = new System.Drawing.Point(207, 14);
            this.DTV_ٍSpendDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DTV_ٍSpendDate.Name = "DTV_ٍSpendDate";
            this.DTV_ٍSpendDate.Size = new System.Drawing.Size(271, 26);
            this.DTV_ٍSpendDate.TabIndex = 25;
            // 
            // DGV_SelectedProduct
            // 
            this.DGV_SelectedProduct.AllowUserToAddRows = false;
            this.DGV_SelectedProduct.AllowUserToDeleteRows = false;
            this.DGV_SelectedProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SelectedProduct.Location = new System.Drawing.Point(20, 33);
            this.DGV_SelectedProduct.Name = "DGV_SelectedProduct";
            this.DGV_SelectedProduct.ReadOnly = true;
            this.DGV_SelectedProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SelectedProduct.Size = new System.Drawing.Size(331, 184);
            this.DGV_SelectedProduct.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "تاريخ اذن الصرف";
            // 
            // CMB_Catogry
            // 
            this.CMB_Catogry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Catogry.FormattingEnabled = true;
            this.CMB_Catogry.Location = new System.Drawing.Point(417, 75);
            this.CMB_Catogry.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CMB_Catogry.Name = "CMB_Catogry";
            this.CMB_Catogry.Size = new System.Drawing.Size(199, 27);
            this.CMB_Catogry.TabIndex = 5;
            this.CMB_Catogry.SelectedIndexChanged += new System.EventHandler(this.CMB_Catogry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "الكمية";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.numericCountity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DGV_SelectedProduct);
            this.panel1.Controls.Add(this.CMB_Catogry);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BT_AddProductSpend);
            this.panel1.Location = new System.Drawing.Point(203, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 234);
            this.panel1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "الفئة";
            // 
            // BT_AddProductSpend
            // 
            this.BT_AddProductSpend.BackColor = System.Drawing.Color.Cyan;
            this.BT_AddProductSpend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AddProductSpend.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddProductSpend.ForeColor = System.Drawing.Color.White;
            this.BT_AddProductSpend.Location = new System.Drawing.Point(476, 176);
            this.BT_AddProductSpend.Name = "BT_AddProductSpend";
            this.BT_AddProductSpend.Size = new System.Drawing.Size(113, 41);
            this.BT_AddProductSpend.TabIndex = 27;
            this.BT_AddProductSpend.Text = "اضافة";
            this.BT_AddProductSpend.UseVisualStyleBackColor = false;
            this.BT_AddProductSpend.Click += new System.EventHandler(this.BT_AddProductSpend_Click);
            // 
            // DGV_SpendProducts
            // 
            this.DGV_SpendProducts.AllowUserToAddRows = false;
            this.DGV_SpendProducts.AllowUserToDeleteRows = false;
            this.DGV_SpendProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SpendProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Price,
            this.quantity,
            this.productName,
            this.productNumber});
            this.DGV_SpendProducts.Location = new System.Drawing.Point(203, 347);
            this.DGV_SpendProducts.Name = "DGV_SpendProducts";
            this.DGV_SpendProducts.ReadOnly = true;
            this.DGV_SpendProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_SpendProducts.Size = new System.Drawing.Size(502, 186);
            this.DGV_SpendProducts.TabIndex = 28;
            // 
            // Price
            // 
            this.Price.HeaderText = "سعر المنتج";
            this.Price.Name = "Price";
            this.Price.Width = 120;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "الكمية";
            this.quantity.Name = "quantity";
            this.quantity.Width = 120;
            // 
            // productName
            // 
            this.productName.HeaderText = "اسم المنتج";
            this.productName.Name = "productName";
            this.productName.Width = 200;
            // 
            // productNumber
            // 
            this.productNumber.HeaderText = "رقم المنتج";
            this.productNumber.Name = "productNumber";
            this.productNumber.Width = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(460, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 46);
            this.button1.TabIndex = 30;
            this.button1.Text = "حفظ  ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderRepresantitve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CMB_MndobName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTV_ٍSpendDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_SpendProducts);
            this.Controls.Add(this.button1);
            this.Name = "OrderRepresantitve";
            this.Text = "OrderRepresantitve";
            this.Load += new System.EventHandler(this.OrderRepresantitve_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericCountity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SelectedProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SpendProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ComboBox CMB_MndobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericCountity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTV_ٍSpendDate;
        private System.Windows.Forms.DataGridView DGV_SelectedProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMB_Catogry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_AddProductSpend;
        private System.Windows.Forms.DataGridView DGV_SpendProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumber;
    }
}