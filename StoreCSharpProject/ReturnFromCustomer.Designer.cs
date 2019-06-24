namespace StoreCSharpProject
{
    partial class ReturnFromCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.dgv_Bills = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Employee = new MetroFramework.Controls.MetroComboBox();
            this.dtp_GBillDate = new System.Windows.Forms.DateTimePicker();
            this.numTotalCost = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.priceNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductNametextBox2 = new System.Windows.Forms.TextBox();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.btn_AddToBills = new System.Windows.Forms.Button();
            this.cmb_CustomerN = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaiedCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCost)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "اسم العميل";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_customerName);
            this.panel1.Controls.Add(this.dgv_Bills);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(855, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 649);
            this.panel1.TabIndex = 10;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Location = new System.Drawing.Point(48, 13);
            this.txt_customerName.Multiline = true;
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(169, 33);
            this.txt_customerName.TabIndex = 11;
            this.txt_customerName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dgv_Bills
            // 
            this.dgv_Bills.AllowUserToAddRows = false;
            this.dgv_Bills.AllowUserToDeleteRows = false;
            this.dgv_Bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.BillDate,
            this.Column3});
            this.dgv_Bills.Location = new System.Drawing.Point(48, 69);
            this.dgv_Bills.Name = "dgv_Bills";
            this.dgv_Bills.ReadOnly = true;
            this.dgv_Bills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Bills.Size = new System.Drawing.Size(239, 437);
            this.dgv_Bills.TabIndex = 10;
            this.dgv_Bills.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Bills_RowHeaderMouseClick);
            // 
            // BillID
            // 
            this.BillID.HeaderText = "رقم الفاتورة";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            this.BillID.Visible = false;
            // 
            // BillDate
            // 
            this.BillDate.HeaderText = "تاريخ الفاتورة";
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "اسم العميل";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(707, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "الخصم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "الكميه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(685, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "اسم المنتج";
            // 
            // numResCost
            // 
            this.numResCost.DecimalPlaces = 2;
            this.numResCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResCost.Location = new System.Drawing.Point(329, 141);
            this.numResCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numResCost.Name = "numResCost";
            this.numResCost.Size = new System.Drawing.Size(127, 27);
            this.numResCost.TabIndex = 45;
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(102, 411);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(111, 36);
            this.btn_Print.TabIndex = 42;
            this.btn_Print.Text = "طباعه";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // numericPaiedCost
            // 
            this.numericPaiedCost.DecimalPlaces = 2;
            this.numericPaiedCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPaiedCost.Location = new System.Drawing.Point(599, 140);
            this.numericPaiedCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericPaiedCost.Name = "numericPaiedCost";
            this.numericPaiedCost.Size = new System.Drawing.Size(127, 27);
            this.numericPaiedCost.TabIndex = 44;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(103, 205);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 36);
            this.btn_Save.TabIndex = 39;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(217, 143);
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
            this.dgv_SalesBill.Location = new System.Drawing.Point(285, 178);
            this.dgv_SalesBill.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.dgv_SalesBill.Name = "dgv_SalesBill";
            this.dgv_SalesBill.ReadOnly = true;
            this.dgv_SalesBill.RowHeadersWidth = 30;
            this.dgv_SalesBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SalesBill.Size = new System.Drawing.Size(540, 304);
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
            this.label9.Location = new System.Drawing.Point(734, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 37;
            this.label9.Text = "المبلغ المدفوع";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(465, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "المبلغ المتبقي";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(103, 360);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(111, 36);
            this.btn_Cancel.TabIndex = 41;
            this.btn_Cancel.Text = "الغاء";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم الموظف";
            // 
            // Cmb_Employee
            // 
            this.Cmb_Employee.FormattingEnabled = true;
            this.Cmb_Employee.ItemHeight = 23;
            this.Cmb_Employee.Location = new System.Drawing.Point(28, 62);
            this.Cmb_Employee.Name = "Cmb_Employee";
            this.Cmb_Employee.Size = new System.Drawing.Size(128, 29);
            this.Cmb_Employee.TabIndex = 6;
            // 
            // dtp_GBillDate
            // 
            this.dtp_GBillDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_GBillDate.Location = new System.Drawing.Point(383, 6);
            this.dtp_GBillDate.Name = "dtp_GBillDate";
            this.dtp_GBillDate.Size = new System.Drawing.Size(269, 27);
            this.dtp_GBillDate.TabIndex = 5;
            // 
            // numTotalCost
            // 
            this.numTotalCost.DecimalPlaces = 2;
            this.numTotalCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotalCost.Location = new System.Drawing.Point(75, 140);
            this.numTotalCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTotalCost.Name = "numTotalCost";
            this.numTotalCost.Size = new System.Drawing.Size(127, 27);
            this.numTotalCost.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.priceNumericUpDown1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ProductNametextBox2);
            this.panel2.Controls.Add(this.numericDiscount);
            this.panel2.Controls.Add(this.numericQuantity);
            this.panel2.Controls.Add(this.btn_AddToBills);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(58, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 177);
            this.panel2.TabIndex = 36;
            // 
            // priceNumericUpDown1
            // 
            this.priceNumericUpDown1.DecimalPlaces = 2;
            this.priceNumericUpDown1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpDown1.Location = new System.Drawing.Point(17, 10);
            this.priceNumericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceNumericUpDown1.Name = "priceNumericUpDown1";
            this.priceNumericUpDown1.Size = new System.Drawing.Size(159, 27);
            this.priceNumericUpDown1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "السعر";
            // 
            // ProductNametextBox2
            // 
            this.ProductNametextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductNametextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProductNametextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNametextBox2.Location = new System.Drawing.Point(502, 10);
            this.ProductNametextBox2.Name = "ProductNametextBox2";
            this.ProductNametextBox2.Size = new System.Drawing.Size(169, 35);
            this.ProductNametextBox2.TabIndex = 27;
            // 
            // numericDiscount
            // 
            this.numericDiscount.DecimalPlaces = 2;
            this.numericDiscount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiscount.Location = new System.Drawing.Point(511, 62);
            this.numericDiscount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(159, 27);
            this.numericDiscount.TabIndex = 24;
            // 
            // numericQuantity
            // 
            this.numericQuantity.DecimalPlaces = 2;
            this.numericQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantity.Location = new System.Drawing.Point(239, 9);
            this.numericQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(159, 27);
            this.numericQuantity.TabIndex = 23;
            // 
            // btn_AddToBills
            // 
            this.btn_AddToBills.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToBills.Location = new System.Drawing.Point(251, 62);
            this.btn_AddToBills.Name = "btn_AddToBills";
            this.btn_AddToBills.Size = new System.Drawing.Size(157, 44);
            this.btn_AddToBills.TabIndex = 1;
            this.btn_AddToBills.Text = "تعديل";
            this.btn_AddToBills.UseVisualStyleBackColor = true;
            this.btn_AddToBills.Click += new System.EventHandler(this.btn_AddToBills_Click);
            // 
            // cmb_CustomerN
            // 
            this.cmb_CustomerN.FormattingEnabled = true;
            this.cmb_CustomerN.ItemHeight = 23;
            this.cmb_CustomerN.Location = new System.Drawing.Point(28, 6);
            this.cmb_CustomerN.Name = "cmb_CustomerN";
            this.cmb_CustomerN.Size = new System.Drawing.Size(128, 29);
            this.cmb_CustomerN.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(651, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "تاريخ الفاتوره";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "اسم العميل";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Cmb_Employee);
            this.panel3.Controls.Add(this.dtp_GBillDate);
            this.panel3.Controls.Add(this.cmb_CustomerN);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(58, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 116);
            this.panel3.TabIndex = 35;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(102, 265);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(111, 36);
            this.EditBtn.TabIndex = 47;
            this.EditBtn.Text = "تعديل";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(102, 307);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(111, 36);
            this.DeleteBtn.TabIndex = 48;
            this.DeleteBtn.Text = "مسح";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ReturnFromCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 676);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.numResCost);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.numericPaiedCost);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgv_SalesBill);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.numTotalCost);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ReturnFromCustomer";
            this.Text = "ReturnFromCustomer";
            this.Load += new System.EventHandler(this.ReturnFromCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaiedCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCost)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Bills;
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
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox Cmb_Employee;
        private System.Windows.Forms.DateTimePicker dtp_GBillDate;
        private System.Windows.Forms.NumericUpDown numTotalCost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Button btn_AddToBills;
        private MetroFramework.Controls.MetroComboBox cmb_CustomerN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox ProductNametextBox2;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown1;
    }
}