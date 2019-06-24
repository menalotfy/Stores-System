namespace StoreCSharpProject
{
    partial class retunedFromSalesCustomer
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
            this.numericTotalCost = new System.Windows.Forms.NumericUpDown();
            this.numericPaiedCost = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFound = new System.Windows.Forms.Button();
            this.MandobtextBox = new System.Windows.Forms.TextBox();
            this.CustomerNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_BillDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_AddToBills = new System.Windows.Forms.Button();
            this.numericResCost = new System.Windows.Forms.NumericUpDown();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productNametextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dgv_SalesBill = new System.Windows.Forms.DataGridView();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.SearchtextBox3 = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaiedCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericResCost)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericTotalCost
            // 
            this.numericTotalCost.DecimalPlaces = 2;
            this.numericTotalCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTotalCost.Location = new System.Drawing.Point(21, 14);
            this.numericTotalCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericTotalCost.Name = "numericTotalCost";
            this.numericTotalCost.Size = new System.Drawing.Size(120, 27);
            this.numericTotalCost.TabIndex = 34;
            this.numericTotalCost.ValueChanged += new System.EventHandler(this.numericTotalCost_ValueChanged);
            // 
            // numericPaiedCost
            // 
            this.numericPaiedCost.DecimalPlaces = 2;
            this.numericPaiedCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPaiedCost.Location = new System.Drawing.Point(509, 11);
            this.numericPaiedCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericPaiedCost.Name = "numericPaiedCost";
            this.numericPaiedCost.Size = new System.Drawing.Size(120, 27);
            this.numericPaiedCost.TabIndex = 32;
            this.numericPaiedCost.ValueChanged += new System.EventHandler(this.numericPaiedCost_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(682, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "سعر المنتج";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(509, 95);
            this.textBoxProductPrice.Multiline = true;
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.ReadOnly = true;
            this.textBoxProductPrice.Size = new System.Drawing.Size(155, 34);
            this.textBoxProductPrice.TabIndex = 25;
            // 
            // numericDiscount
            // 
            this.numericDiscount.DecimalPlaces = 2;
            this.numericDiscount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiscount.Location = new System.Drawing.Point(170, 50);
            this.numericDiscount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(152, 27);
            this.numericDiscount.TabIndex = 24;
            // 
            // numericQuantity
            // 
            this.numericQuantity.DecimalPlaces = 2;
            this.numericQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantity.Location = new System.Drawing.Point(170, 8);
            this.numericQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(152, 27);
            this.numericQuantity.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnFound);
            this.panel1.Controls.Add(this.MandobtextBox);
            this.panel1.Controls.Add(this.CustomerNametextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp_BillDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(197, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 116);
            this.panel1.TabIndex = 23;
            // 
            // btnFound
            // 
            this.btnFound.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFound.Location = new System.Drawing.Point(435, 64);
            this.btnFound.Name = "btnFound";
            this.btnFound.Size = new System.Drawing.Size(104, 36);
            this.btnFound.TabIndex = 37;
            this.btnFound.Text = "بحث";
            this.btnFound.UseVisualStyleBackColor = true;
            this.btnFound.Click += new System.EventHandler(this.btnFound_Click);
            // 
            // MandobtextBox
            // 
            this.MandobtextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MandobtextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.MandobtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MandobtextBox.Location = new System.Drawing.Point(20, 70);
            this.MandobtextBox.Name = "MandobtextBox";
            this.MandobtextBox.Size = new System.Drawing.Size(138, 30);
            this.MandobtextBox.TabIndex = 10;
            // 
            // CustomerNametextBox
            // 
            this.CustomerNametextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerNametextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CustomerNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNametextBox.Location = new System.Drawing.Point(20, 10);
            this.CustomerNametextBox.Name = "CustomerNametextBox";
            this.CustomerNametextBox.Size = new System.Drawing.Size(138, 30);
            this.CustomerNametextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم المندوب";
            // 
            // dtp_BillDate
            // 
            this.dtp_BillDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_BillDate.Location = new System.Drawing.Point(375, 3);
            this.dtp_BillDate.Name = "dtp_BillDate";
            this.dtp_BillDate.Size = new System.Drawing.Size(262, 27);
            this.dtp_BillDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(666, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ الفاتوره";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم العميل";
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(231, 567);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(104, 36);
            this.btn_Print.TabIndex = 30;
            this.btn_Print.Text = "طباعه";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Visible = false;
            // 
            // btn_AddToBills
            // 
            this.btn_AddToBills.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToBills.Location = new System.Drawing.Point(170, 95);
            this.btn_AddToBills.Name = "btn_AddToBills";
            this.btn_AddToBills.Size = new System.Drawing.Size(150, 44);
            this.btn_AddToBills.TabIndex = 1;
            this.btn_AddToBills.Text = "إضافة";
            this.btn_AddToBills.UseVisualStyleBackColor = true;
            this.btn_AddToBills.Click += new System.EventHandler(this.btn_AddToBills_Click);
            // 
            // numericResCost
            // 
            this.numericResCost.DecimalPlaces = 2;
            this.numericResCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericResCost.Location = new System.Drawing.Point(267, 11);
            this.numericResCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericResCost.Name = "numericResCost";
            this.numericResCost.Size = new System.Drawing.Size(120, 27);
            this.numericResCost.TabIndex = 33;
            this.numericResCost.ValueChanged += new System.EventHandler(this.numericResCost_ValueChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(231, 378);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(104, 36);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(166, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "اجمالي التكلفه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(665, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "المبلغ المدفوع";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(422, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "المبلغ المتبقي";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(371, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "الخصم";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productNametextBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxProductPrice);
            this.panel2.Controls.Add(this.numericDiscount);
            this.panel2.Controls.Add(this.numericQuantity);
            this.panel2.Controls.Add(this.btn_AddToBills);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(194, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 147);
            this.panel2.TabIndex = 24;
            this.panel2.Visible = false;
            // 
            // productNametextBox1
            // 
            this.productNametextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNametextBox1.Location = new System.Drawing.Point(491, 30);
            this.productNametextBox1.Name = "productNametextBox1";
            this.productNametextBox1.Size = new System.Drawing.Size(173, 30);
            this.productNametextBox1.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(685, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "اسم المنتج";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "الكميه";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(231, 525);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(104, 36);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Text = "الغاء";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // dgv_SalesBill
            // 
            this.dgv_SalesBill.AllowUserToAddRows = false;
            this.dgv_SalesBill.AllowUserToDeleteRows = false;
            this.dgv_SalesBill.AllowUserToOrderColumns = true;
            this.dgv_SalesBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SalesBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_SalesBill.ColumnHeadersHeight = 40;
            this.dgv_SalesBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.discount,
            this.price,
            this.productQuantity,
            this.productName,
            this.ProductID});
            this.dgv_SalesBill.Location = new System.Drawing.Point(380, 329);
            this.dgv_SalesBill.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.dgv_SalesBill.Name = "dgv_SalesBill";
            this.dgv_SalesBill.ReadOnly = true;
            this.dgv_SalesBill.RowHeadersWidth = 30;
            this.dgv_SalesBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SalesBill.Size = new System.Drawing.Size(580, 513);
            this.dgv_SalesBill.TabIndex = 26;
            this.dgv_SalesBill.Visible = false;
            // 
            // discount
            // 
            this.discount.HeaderText = "الخصم";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 120;
            // 
            // price
            // 
            this.price.HeaderText = "سعر المنتج";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 120;
            // 
            // productQuantity
            // 
            this.productQuantity.HeaderText = "الكميه";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            this.productQuantity.Width = 120;
            // 
            // productName
            // 
            this.productName.HeaderText = "اسم المنتج";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 220;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "رقم المنتج";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            this.ProductID.Width = 50;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.numericTotalCost);
            this.panel3.Controls.Add(this.numericPaiedCost);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.numericResCost);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(194, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(766, 56);
            this.panel3.TabIndex = 35;
            this.panel3.Visible = false;
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(231, 430);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(104, 36);
            this.editBtn.TabIndex = 36;
            this.editBtn.Text = "تعديل";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Visible = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // SearchtextBox3
            // 
            this.SearchtextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchtextBox3.Location = new System.Drawing.Point(217, 329);
            this.SearchtextBox3.Name = "SearchtextBox3";
            this.SearchtextBox3.Size = new System.Drawing.Size(138, 30);
            this.SearchtextBox3.TabIndex = 37;
            this.SearchtextBox3.Visible = false;
            this.SearchtextBox3.TextChanged += new System.EventHandler(this.SearchtextBox3_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(84, 328);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 36);
            this.searchBtn.TabIndex = 38;
            this.searchBtn.Text = "بحث عن منتج";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Visible = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(231, 483);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(104, 36);
            this.DeleteBtn.TabIndex = 39;
            this.DeleteBtn.Text = "مسح";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Visible = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // retunedFromSalesCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 625);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.SearchtextBox3);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.dgv_SalesBill);
            this.Name = "retunedFromSalesCustomer";
            this.Text = "retunedFromSalesCustomer";
            this.Load += new System.EventHandler(this.retunedFromSalesCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaiedCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericResCost)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericTotalCost;
        private System.Windows.Forms.NumericUpDown numericPaiedCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_BillDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_AddToBills;
        private System.Windows.Forms.NumericUpDown numericResCost;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView dgv_SalesBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox MandobtextBox;
        private System.Windows.Forms.TextBox CustomerNametextBox;
        private System.Windows.Forms.Button btnFound;
        private System.Windows.Forms.TextBox SearchtextBox3;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox productNametextBox1;
        private System.Windows.Forms.Button DeleteBtn;
    }
}