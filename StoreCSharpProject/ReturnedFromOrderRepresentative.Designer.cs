namespace StoreCSharpProject
{
    partial class ReturnedFromOrderRepresentative
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
            this.SaveBTn = new System.Windows.Forms.Button();
            this.BT_AddProductSpend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CMB_MndobName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTV_ٍSpendDate = new System.Windows.Forms.DateTimePicker();
            this.DGV_SpendProducts = new System.Windows.Forms.DataGridView();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancleBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.btnFound = new System.Windows.Forms.Button();
            this.priceNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductNametextBox2 = new System.Windows.Forms.TextBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SpendProducts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBTn
            // 
            this.SaveBTn.BackColor = System.Drawing.Color.DarkGreen;
            this.SaveBTn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.SaveBTn.Location = new System.Drawing.Point(256, 320);
            this.SaveBTn.Name = "SaveBTn";
            this.SaveBTn.Size = new System.Drawing.Size(550, 46);
            this.SaveBTn.TabIndex = 39;
            this.SaveBTn.Text = "حفظ  ";
            this.SaveBTn.UseVisualStyleBackColor = false;
            this.SaveBTn.Visible = false;
            this.SaveBTn.Click += new System.EventHandler(this.SaveBTn_Click);
            // 
            // BT_AddProductSpend
            // 
            this.BT_AddProductSpend.BackColor = System.Drawing.Color.OliveDrab;
            this.BT_AddProductSpend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddProductSpend.ForeColor = System.Drawing.Color.Maroon;
            this.BT_AddProductSpend.Location = new System.Drawing.Point(30, 146);
            this.BT_AddProductSpend.Name = "BT_AddProductSpend";
            this.BT_AddProductSpend.Size = new System.Drawing.Size(646, 41);
            this.BT_AddProductSpend.TabIndex = 36;
            this.BT_AddProductSpend.Text = "تعديل";
            this.BT_AddProductSpend.UseVisualStyleBackColor = false;
            this.BT_AddProductSpend.Click += new System.EventHandler(this.BT_AddProductSpend_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.priceNumericUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProductNametextBox2);
            this.panel1.Controls.Add(this.numericQuantity);
            this.panel1.Controls.Add(this.BT_AddProductSpend);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(197, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 234);
            this.panel1.TabIndex = 38;
            this.panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "تاريخ اذن الصرف";
            // 
            // CMB_MndobName
            // 
            this.CMB_MndobName.FormattingEnabled = true;
            this.CMB_MndobName.Location = new System.Drawing.Point(643, 13);
            this.CMB_MndobName.Name = "CMB_MndobName";
            this.CMB_MndobName.Size = new System.Drawing.Size(199, 21);
            this.CMB_MndobName.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(864, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "اسم المندوب";
            // 
            // DTV_ٍSpendDate
            // 
            this.DTV_ٍSpendDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTV_ٍSpendDate.Location = new System.Drawing.Point(230, 10);
            this.DTV_ٍSpendDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DTV_ٍSpendDate.Name = "DTV_ٍSpendDate";
            this.DTV_ٍSpendDate.Size = new System.Drawing.Size(271, 26);
            this.DTV_ٍSpendDate.TabIndex = 34;
            // 
            // DGV_SpendProducts
            // 
            this.DGV_SpendProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SpendProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Price,
            this.quantity,
            this.productName,
            this.productNumber});
            this.DGV_SpendProducts.Location = new System.Drawing.Point(211, 71);
            this.DGV_SpendProducts.Name = "DGV_SpendProducts";
            this.DGV_SpendProducts.Size = new System.Drawing.Size(478, 243);
            this.DGV_SpendProducts.TabIndex = 42;
            this.DGV_SpendProducts.Visible = false;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.cancleBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(695, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 243);
            this.panel2.TabIndex = 43;
            this.panel2.Visible = false;
            // 
            // cancleBtn
            // 
            this.cancleBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.cancleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleBtn.ForeColor = System.Drawing.Color.White;
            this.cancleBtn.Location = new System.Drawing.Point(49, 171);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(102, 48);
            this.cancleBtn.TabIndex = 2;
            this.cancleBtn.Text = "الغاء";
            this.cancleBtn.UseVisualStyleBackColor = false;
            this.cancleBtn.Click += new System.EventHandler(this.cancleBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(49, 88);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(102, 48);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "مسح";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.Maroon;
            this.EditBtn.Location = new System.Drawing.Point(49, 13);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(102, 48);
            this.EditBtn.TabIndex = 0;
            this.EditBtn.Text = "تعديل";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // btnFound
            // 
            this.btnFound.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFound.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFound.Location = new System.Drawing.Point(85, 9);
            this.btnFound.Name = "btnFound";
            this.btnFound.Size = new System.Drawing.Size(104, 36);
            this.btnFound.TabIndex = 44;
            this.btnFound.Text = "بحث";
            this.btnFound.UseVisualStyleBackColor = false;
            this.btnFound.Click += new System.EventHandler(this.btnFound_Click);
            // 
            // priceNumericUpDown1
            // 
            this.priceNumericUpDown1.DecimalPlaces = 2;
            this.priceNumericUpDown1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumericUpDown1.Location = new System.Drawing.Point(14, 35);
            this.priceNumericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceNumericUpDown1.Name = "priceNumericUpDown1";
            this.priceNumericUpDown1.Size = new System.Drawing.Size(159, 27);
            this.priceNumericUpDown1.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "السعر";
            // 
            // ProductNametextBox2
            // 
            this.ProductNametextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductNametextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProductNametextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNametextBox2.Location = new System.Drawing.Point(489, 35);
            this.ProductNametextBox2.Name = "ProductNametextBox2";
            this.ProductNametextBox2.ReadOnly = true;
            this.ProductNametextBox2.Size = new System.Drawing.Size(169, 35);
            this.ProductNametextBox2.TabIndex = 36;
            // 
            // numericQuantity
            // 
            this.numericQuantity.DecimalPlaces = 2;
            this.numericQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantity.Location = new System.Drawing.Point(249, 35);
            this.numericQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(159, 27);
            this.numericQuantity.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "الكميه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(682, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "اسم المنتج";
            // 
            // ReturnedFromOrderRepresentative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 680);
            this.Controls.Add(this.btnFound);
            this.Controls.Add(this.DGV_SpendProducts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SaveBTn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CMB_MndobName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTV_ٍSpendDate);
            this.Name = "ReturnedFromOrderRepresentative";
            this.Text = "ReturnedFromOrderRepresentative";
            this.Load += new System.EventHandler(this.ReturnedFromOrderRepresentative_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SpendProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBTn;
        private System.Windows.Forms.Button BT_AddProductSpend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMB_MndobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTV_ٍSpendDate;
        private System.Windows.Forms.DataGridView DGV_SpendProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button cancleBtn;
        private System.Windows.Forms.Button btnFound;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductNametextBox2;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}