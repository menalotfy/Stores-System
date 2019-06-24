namespace StoreCSharpProject
{
    partial class SalesBillMandob
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
            this.btn_AddToBills = new System.Windows.Forms.Button();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Category = new MetroFramework.Controls.MetroComboBox();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_SalesBill = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericPaiedCost = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_ProductName = new MetroFramework.Controls.MetroComboBox();
            this.numericTotalCost = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericResCost = new System.Windows.Forms.NumericUpDown();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mandobCompobox = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_BillDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_CustomerName = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaiedCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResCost)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // discount
            // 
            this.discount.HeaderText = "الخصم";
            this.discount.Name = "discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(695, 50);
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
            // cmb_Category
            // 
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.ItemHeight = 23;
            this.cmb_Category.Location = new System.Drawing.Point(509, 6);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(151, 29);
            this.cmb_Category.TabIndex = 6;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // price
            // 
            this.price.HeaderText = "سعر المنتج";
            this.price.Name = "price";
            // 
            // productQuantity
            // 
            this.productQuantity.HeaderText = "الكميه";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Width = 60;
            // 
            // productName
            // 
            this.productName.HeaderText = "اسم المنتج";
            this.productName.Name = "productName";
            this.productName.Width = 200;
            // 
            // dgv_SalesBill
            // 
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
            this.dgv_SalesBill.Location = new System.Drawing.Point(701, 329);
            this.dgv_SalesBill.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.dgv_SalesBill.Name = "dgv_SalesBill";
            this.dgv_SalesBill.RowHeadersWidth = 30;
            this.dgv_SalesBill.Size = new System.Drawing.Size(487, 513);
            this.dgv_SalesBill.TabIndex = 26;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "رقم المنتج";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            this.ProductID.Width = 50;
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
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(152, 27);
            this.numericDiscount.TabIndex = 24;
            // 
            // numericQuantity
            // 
            this.numericQuantity.DecimalPlaces = 2;
            this.numericQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantity.Location = new System.Drawing.Point(170, 8);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(152, 27);
            this.numericQuantity.TabIndex = 23;
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
            // numericPaiedCost
            // 
            this.numericPaiedCost.DecimalPlaces = 2;
            this.numericPaiedCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPaiedCost.Location = new System.Drawing.Point(986, 293);
            this.numericPaiedCost.Name = "numericPaiedCost";
            this.numericPaiedCost.Size = new System.Drawing.Size(120, 27);
            this.numericPaiedCost.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(604, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "اجمالي التكلفه";
            // 
            // cmb_ProductName
            // 
            this.cmb_ProductName.FormattingEnabled = true;
            this.cmb_ProductName.ItemHeight = 23;
            this.cmb_ProductName.Location = new System.Drawing.Point(509, 50);
            this.cmb_ProductName.Name = "cmb_ProductName";
            this.cmb_ProductName.Size = new System.Drawing.Size(152, 29);
            this.cmb_ProductName.TabIndex = 10;
            this.cmb_ProductName.SelectedIndexChanged += new System.EventHandler(this.cmb_ProductName_SelectedIndexChanged);
            // 
            // numericTotalCost
            // 
            this.numericTotalCost.DecimalPlaces = 2;
            this.numericTotalCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTotalCost.Location = new System.Drawing.Point(462, 293);
            this.numericTotalCost.Name = "numericTotalCost";
            this.numericTotalCost.Size = new System.Drawing.Size(120, 27);
            this.numericTotalCost.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "الفئه";
            // 
            // numericResCost
            // 
            this.numericResCost.DecimalPlaces = 2;
            this.numericResCost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericResCost.Location = new System.Drawing.Point(716, 294);
            this.numericResCost.Name = "numericResCost";
            this.numericResCost.Size = new System.Drawing.Size(120, 27);
            this.numericResCost.TabIndex = 33;
            // 
            // btn_Print
            // 
            this.btn_Print.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(489, 564);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(104, 36);
            this.btn_Print.TabIndex = 31;
            this.btn_Print.Text = "طباعه";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(489, 467);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(104, 36);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم المندوب";
            // 
            // mandobCompobox
            // 
            this.mandobCompobox.FormattingEnabled = true;
            this.mandobCompobox.ItemHeight = 23;
            this.mandobCompobox.Location = new System.Drawing.Point(20, 59);
            this.mandobCompobox.Name = "mandobCompobox";
            this.mandobCompobox.Size = new System.Drawing.Size(121, 29);
            this.mandobCompobox.TabIndex = 6;
            this.mandobCompobox.SelectedIndexChanged += new System.EventHandler(this.mandobCompobox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mandobCompobox);
            this.panel1.Controls.Add(this.dtp_BillDate);
            this.panel1.Controls.Add(this.cmb_CustomerName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(452, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 116);
            this.panel1.TabIndex = 23;
            // 
            // dtp_BillDate
            // 
            this.dtp_BillDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_BillDate.Location = new System.Drawing.Point(375, 3);
            this.dtp_BillDate.Name = "dtp_BillDate";
            this.dtp_BillDate.Size = new System.Drawing.Size(262, 27);
            this.dtp_BillDate.TabIndex = 5;
            // 
            // cmb_CustomerName
            // 
            this.cmb_CustomerName.FormattingEnabled = true;
            this.cmb_CustomerName.ItemHeight = 23;
            this.cmb_CustomerName.Location = new System.Drawing.Point(20, 3);
            this.cmb_CustomerName.Name = "cmb_CustomerName";
            this.cmb_CustomerName.Size = new System.Drawing.Size(121, 29);
            this.cmb_CustomerName.TabIndex = 4;
            this.cmb_CustomerName.SelectedIndexChanged += new System.EventHandler(this.cmb_CustomerName_SelectedIndexChanged);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1121, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "المبلغ المدفوع";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(852, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "المبلغ المتبقي";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(489, 395);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(104, 36);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Text = "الغاء";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxProductPrice);
            this.panel2.Controls.Add(this.numericDiscount);
            this.panel2.Controls.Add(this.numericQuantity);
            this.panel2.Controls.Add(this.btn_AddToBills);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmb_ProductName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmb_Category);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(452, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 147);
            this.panel2.TabIndex = 24;
            // 
            // SalesBillMandob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 648);
            this.Controls.Add(this.dgv_SalesBill);
            this.Controls.Add(this.numericPaiedCost);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericTotalCost);
            this.Controls.Add(this.numericResCost);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.panel2);
            this.Name = "SalesBillMandob";
            this.Text = "SalesBillMandob";
            this.Load += new System.EventHandler(this.SalesBillMandob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPaiedCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResCost)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddToBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cmb_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridView dgv_SalesBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericPaiedCost;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroComboBox cmb_ProductName;
        private System.Windows.Forms.NumericUpDown numericTotalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericResCost;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox mandobCompobox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_BillDate;
        private MetroFramework.Controls.MetroComboBox cmb_CustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel panel2;
    }
}