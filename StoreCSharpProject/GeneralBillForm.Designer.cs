namespace StoreCSharpProject
{
    partial class GeneralBillForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numResCost = new System.Windows.Forms.NumericUpDown();
            this.btn_Print = new System.Windows.Forms.Button();
            this.numericPaiedCost = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_SalesBill = new System.Windows.Forms.DataGridView();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.cmb_Category = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Employee = new MetroFramework.Controls.MetroComboBox();
            this.dtp_GBillDate = new System.Windows.Forms.DateTimePicker();
            this.numTotalCost = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.DGV_Poducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.btn_AddToBills = new System.Windows.Forms.Button();
            this.cmb_CustomerN = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numResCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaiedCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCost)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Poducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 36);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1148, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "الخصم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1147, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "الكميه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1147, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "الفئه";
            // 
            // numResCost
            // 
            this.numResCost.DecimalPlaces = 2;
            this.numResCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResCost.Location = new System.Drawing.Point(148, 468);
            this.numResCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numResCost.Name = "numResCost";
            this.numResCost.Size = new System.Drawing.Size(178, 27);
            this.numResCost.TabIndex = 45;
            this.numResCost.ValueChanged += new System.EventHandler(this.numResCost_ValueChanged);
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(62, 626);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(104, 36);
            this.btn_Print.TabIndex = 42;
            this.btn_Print.Text = "طباعه";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // numericPaiedCost
            // 
            this.numericPaiedCost.DecimalPlaces = 2;
            this.numericPaiedCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPaiedCost.Location = new System.Drawing.Point(148, 409);
            this.numericPaiedCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericPaiedCost.Name = "numericPaiedCost";
            this.numericPaiedCost.Size = new System.Drawing.Size(178, 27);
            this.numericPaiedCost.TabIndex = 44;
            this.numericPaiedCost.ValueChanged += new System.EventHandler(this.numericPaiedCost_ValueChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(415, 626);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(104, 36);
            this.btn_Save.TabIndex = 39;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(356, 521);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 43;
            this.label11.Text = "اجمالي التكلفه";
            // 
            // dgv_SalesBill
            // 
            this.dgv_SalesBill.AllowUserToAddRows = false;
            this.dgv_SalesBill.AllowUserToDeleteRows = false;
            this.dgv_SalesBill.AllowUserToOrderColumns = true;
            this.dgv_SalesBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_SalesBill.ColumnHeadersHeight = 40;
            this.dgv_SalesBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.discount,
            this.price,
            this.productQuantity,
            this.productName,
            this.ProductID});
            this.dgv_SalesBill.Location = new System.Drawing.Point(699, 385);
            this.dgv_SalesBill.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.dgv_SalesBill.Name = "dgv_SalesBill";
            this.dgv_SalesBill.ReadOnly = true;
            this.dgv_SalesBill.RowHeadersWidth = 30;
            this.dgv_SalesBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SalesBill.Size = new System.Drawing.Size(533, 304);
            this.dgv_SalesBill.TabIndex = 38;
            // 
            // discount
            // 
            this.discount.HeaderText = "الخصم";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "سعر المنتج";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // productQuantity
            // 
            this.productQuantity.HeaderText = "الكمية";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "اسم المنتج";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "رقم المنتج";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(354, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 37;
            this.label9.Text = "المبلغ المدفوع";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(358, 468);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "المبلغ المتبقي";
            // 
            // btn_del
            // 
            this.btn_del.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(222, 626);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(104, 36);
            this.btn_del.TabIndex = 41;
            this.btn_del.Text = "مسح";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cmb_Category
            // 
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.ItemHeight = 23;
            this.cmb_Category.Location = new System.Drawing.Point(886, 60);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(218, 29);
            this.cmb_Category.TabIndex = 6;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم الموظف";
            // 
            // Cmb_Employee
            // 
            this.Cmb_Employee.FormattingEnabled = true;
            this.Cmb_Employee.ItemHeight = 23;
            this.Cmb_Employee.Location = new System.Drawing.Point(39, 39);
            this.Cmb_Employee.Name = "Cmb_Employee";
            this.Cmb_Employee.Size = new System.Drawing.Size(217, 29);
            this.Cmb_Employee.TabIndex = 6;
            // 
            // dtp_GBillDate
            // 
            this.dtp_GBillDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_GBillDate.Location = new System.Drawing.Point(842, 42);
            this.dtp_GBillDate.Name = "dtp_GBillDate";
            this.dtp_GBillDate.Size = new System.Drawing.Size(262, 27);
            this.dtp_GBillDate.TabIndex = 5;
            // 
            // numTotalCost
            // 
            this.numTotalCost.DecimalPlaces = 2;
            this.numTotalCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotalCost.Location = new System.Drawing.Point(148, 518);
            this.numTotalCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTotalCost.Name = "numTotalCost";
            this.numTotalCost.Size = new System.Drawing.Size(178, 27);
            this.numTotalCost.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.DGV_Poducts);
            this.panel2.Controls.Add(this.numericDiscount);
            this.panel2.Controls.Add(this.numericQuantity);
            this.panel2.Controls.Add(this.btn_AddToBills);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmb_Category);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 241);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sakkal Majalla", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(621, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 44);
            this.label6.TabIndex = 27;
            this.label6.Text = "بحث";
            // 
            // DGV_Poducts
            // 
            this.DGV_Poducts.AllowUserToAddRows = false;
            this.DGV_Poducts.AllowUserToDeleteRows = false;
            this.DGV_Poducts.AllowUserToOrderColumns = true;
            this.DGV_Poducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Poducts.ColumnHeadersHeight = 40;
            this.DGV_Poducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.dataGridViewTextBoxColumn3});
            this.DGV_Poducts.Location = new System.Drawing.Point(14, 8);
            this.DGV_Poducts.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.DGV_Poducts.Name = "DGV_Poducts";
            this.DGV_Poducts.ReadOnly = true;
            this.DGV_Poducts.RowHeadersWidth = 30;
            this.DGV_Poducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Poducts.Size = new System.Drawing.Size(434, 208);
            this.DGV_Poducts.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "سعر المنتج";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "اسم المنتج";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // numericDiscount
            // 
            this.numericDiscount.DecimalPlaces = 2;
            this.numericDiscount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiscount.Location = new System.Drawing.Point(886, 129);
            this.numericDiscount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(219, 27);
            this.numericDiscount.TabIndex = 24;
            // 
            // numericQuantity
            // 
            this.numericQuantity.DecimalPlaces = 2;
            this.numericQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantity.Location = new System.Drawing.Point(886, 95);
            this.numericQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(219, 27);
            this.numericQuantity.TabIndex = 23;
            // 
            // btn_AddToBills
            // 
            this.btn_AddToBills.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToBills.Location = new System.Drawing.Point(936, 182);
            this.btn_AddToBills.Name = "btn_AddToBills";
            this.btn_AddToBills.Size = new System.Drawing.Size(150, 44);
            this.btn_AddToBills.TabIndex = 1;
            this.btn_AddToBills.Text = "إضافة";
            this.btn_AddToBills.UseVisualStyleBackColor = true;
            this.btn_AddToBills.Click += new System.EventHandler(this.btn_AddToBills_Click);
            // 
            // cmb_CustomerN
            // 
            this.cmb_CustomerN.FormattingEnabled = true;
            this.cmb_CustomerN.ItemHeight = 23;
            this.cmb_CustomerN.Location = new System.Drawing.Point(426, 42);
            this.cmb_CustomerN.Name = "cmb_CustomerN";
            this.cmb_CustomerN.Size = new System.Drawing.Size(206, 29);
            this.cmb_CustomerN.TabIndex = 4;
            this.cmb_CustomerN.SelectedIndexChanged += new System.EventHandler(this.cmb_CustomerN_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1133, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ الفاتوره";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم العميل";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Cmb_Employee);
            this.panel1.Controls.Add(this.dtp_GBillDate);
            this.panel1.Controls.Add(this.cmb_CustomerN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 116);
            this.panel1.TabIndex = 35;
            // 
            // GeneralBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 703);
            this.Controls.Add(this.numResCost);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.numericPaiedCost);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgv_SalesBill);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.numTotalCost);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GeneralBillForm";
            this.Text = "GeneralBillForm";
            ((System.ComponentModel.ISupportInitialize)(this.numResCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaiedCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCost)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Poducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numResCost;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.NumericUpDown numericPaiedCost;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_SalesBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_del;
        private MetroFramework.Controls.MetroComboBox cmb_Category;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox Cmb_Employee;
        private System.Windows.Forms.DateTimePicker dtp_GBillDate;
        private System.Windows.Forms.NumericUpDown numTotalCost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGV_Poducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Button btn_AddToBills;
        private MetroFramework.Controls.MetroComboBox cmb_CustomerN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}