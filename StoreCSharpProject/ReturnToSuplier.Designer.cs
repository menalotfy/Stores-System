namespace StoreCSharpProject
{
    partial class ReturnToSuplier
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
            this.txt_suplierName = new System.Windows.Forms.TextBox();
            this.dgv_Bills = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numResCost = new System.Windows.Forms.NumericUpDown();
            this.numericPaiedCost = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_SuplierBill = new System.Windows.Forms.DataGridView();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_GBillDate = new System.Windows.Forms.DateTimePicker();
            this.numTotalCost = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_SaveEdit = new System.Windows.Forms.Button();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.btn_SaveChanges = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_EditProduct = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_CancelEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaiedCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuplierBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCost)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "اسم المورد";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_suplierName);
            this.panel1.Controls.Add(this.dgv_Bills);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(855, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 649);
            this.panel1.TabIndex = 10;
            // 
            // txt_suplierName
            // 
            this.txt_suplierName.Location = new System.Drawing.Point(48, 13);
            this.txt_suplierName.Multiline = true;
            this.txt_suplierName.Name = "txt_suplierName";
            this.txt_suplierName.Size = new System.Drawing.Size(169, 33);
            this.txt_suplierName.TabIndex = 11;
            this.txt_suplierName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.Column3.HeaderText = "اسم المورد";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Enabled = false;
            this.txt_ProductName.Location = new System.Drawing.Point(513, 22);
            this.txt_ProductName.Multiline = true;
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(158, 29);
            this.txt_ProductName.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(372, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "سعر المنتج";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(706, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "الكميه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(682, 26);
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
            // dgv_SuplierBill
            // 
            this.dgv_SuplierBill.AllowUserToAddRows = false;
            this.dgv_SuplierBill.AllowUserToDeleteRows = false;
            this.dgv_SuplierBill.AllowUserToOrderColumns = true;
            this.dgv_SuplierBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_SuplierBill.ColumnHeadersHeight = 40;
            this.dgv_SuplierBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.discount,
            this.price,
            this.productQuantity,
            this.productName,
            this.ProductID});
            this.dgv_SuplierBill.Location = new System.Drawing.Point(285, 196);
            this.dgv_SuplierBill.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.dgv_SuplierBill.Name = "dgv_SuplierBill";
            this.dgv_SuplierBill.ReadOnly = true;
            this.dgv_SuplierBill.RowHeadersWidth = 30;
            this.dgv_SuplierBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SuplierBill.Size = new System.Drawing.Size(540, 286);
            this.dgv_SuplierBill.TabIndex = 38;
            this.dgv_SuplierBill.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_SalesBill_RowHeaderMouseClick);
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
            // dtp_GBillDate
            // 
            this.dtp_GBillDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_GBillDate.Location = new System.Drawing.Point(376, 6);
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
            this.panel2.Controls.Add(this.btn_CancelEdit);
            this.panel2.Controls.Add(this.btn_SaveEdit);
            this.panel2.Controls.Add(this.numericDiscount);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_ProductName);
            this.panel2.Controls.Add(this.numericPrice);
            this.panel2.Controls.Add(this.numericQuantity);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(58, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 177);
            this.panel2.TabIndex = 36;
            this.panel2.Visible = false;
            // 
            // btn_SaveEdit
            // 
            this.btn_SaveEdit.Location = new System.Drawing.Point(427, 126);
            this.btn_SaveEdit.Name = "btn_SaveEdit";
            this.btn_SaveEdit.Size = new System.Drawing.Size(127, 48);
            this.btn_SaveEdit.TabIndex = 49;
            this.btn_SaveEdit.Text = "تعديل";
            this.btn_SaveEdit.UseVisualStyleBackColor = true;
            this.btn_SaveEdit.Click += new System.EventHandler(this.btn_SaveEdit_Click);
            // 
            // numericDiscount
            // 
            this.numericDiscount.DecimalPlaces = 2;
            this.numericDiscount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiscount.Location = new System.Drawing.Point(186, 76);
            this.numericDiscount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(159, 27);
            this.numericDiscount.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "الخصم";
            // 
            // numericPrice
            // 
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPrice.Location = new System.Drawing.Point(186, 18);
            this.numericPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(159, 27);
            this.numericPrice.TabIndex = 24;
            // 
            // numericQuantity
            // 
            this.numericQuantity.DecimalPlaces = 2;
            this.numericQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantity.Location = new System.Drawing.Point(512, 73);
            this.numericQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(159, 27);
            this.numericQuantity.TabIndex = 23;
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChanges.Location = new System.Drawing.Point(75, 342);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(127, 43);
            this.btn_SaveChanges.TabIndex = 1;
            this.btn_SaveChanges.Text = "حفظ";
            this.btn_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtp_GBillDate);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(58, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 116);
            this.panel3.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم المورد";
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(75, 196);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(127, 48);
            this.btn_DeleteProduct.TabIndex = 47;
            this.btn_DeleteProduct.Text = "حذف";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // btn_EditProduct
            // 
            this.btn_EditProduct.Location = new System.Drawing.Point(75, 269);
            this.btn_EditProduct.Name = "btn_EditProduct";
            this.btn_EditProduct.Size = new System.Drawing.Size(127, 48);
            this.btn_EditProduct.TabIndex = 48;
            this.btn_EditProduct.Text = "تعديل";
            this.btn_EditProduct.UseVisualStyleBackColor = true;
            this.btn_EditProduct.Click += new System.EventHandler(this.btn_EditProduct_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(75, 410);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(127, 43);
            this.btn_cancel.TabIndex = 49;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_CancelEdit
            // 
            this.btn_CancelEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelEdit.Location = new System.Drawing.Point(227, 125);
            this.btn_CancelEdit.Name = "btn_CancelEdit";
            this.btn_CancelEdit.Size = new System.Drawing.Size(127, 48);
            this.btn_CancelEdit.TabIndex = 50;
            this.btn_CancelEdit.Text = "الغاء";
            this.btn_CancelEdit.UseVisualStyleBackColor = true;
            this.btn_CancelEdit.Click += new System.EventHandler(this.btn_CancelEdit_Click);
            // 
            // ReturnToSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 676);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_EditProduct);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.numResCost);
            this.Controls.Add(this.numericPaiedCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_SaveChanges);
            this.Controls.Add(this.dgv_SuplierBill);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numTotalCost);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ReturnToSuplier";
            this.Text = "ReturnToSuplier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaiedCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SuplierBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCost)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
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
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numResCost;
        private System.Windows.Forms.NumericUpDown numericPaiedCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_SuplierBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_GBillDate;
        private System.Windows.Forms.NumericUpDown numTotalCost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Button btn_SaveChanges;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_suplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_SaveEdit;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Button btn_EditProduct;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_CancelEdit;
    }
}