namespace StoreCSharpProject
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.dgv_SalesBill = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchBtnInGridView = new MetroFramework.Controls.MetroButton();
            this.deleteBtnProduct = new MetroFramework.Controls.MetroButton();
            this.editBtnProduct = new MetroFramework.Controls.MetroButton();
            this.btn_addPro = new MetroFramework.Controls.MetroButton();
            this.Txt_AddProductName = new MetroFramework.Components.MetroStyleManager(this.components);
            this.AddProPanel = new MetroFramework.Controls.MetroPanel();
            this.numericDiscountProUp = new System.Windows.Forms.NumericUpDown();
            this.Como_productUnitUpdate = new MetroFramework.Controls.MetroComboBox();
            this.Como_productCategoryUpdate = new MetroFramework.Controls.MetroComboBox();
            this.Como_productBuySupplierUp = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.numericQuantityProUp = new System.Windows.Forms.NumericUpDown();
            this.numericIncomingPriceProUp = new System.Windows.Forms.NumericUpDown();
            this.numericIndvidualPriceProUp = new System.Windows.Forms.NumericUpDown();
            this.numericTotalPriceProUp = new System.Windows.Forms.NumericUpDown();
            this.numericQuantityPackageProUp = new System.Windows.Forms.NumericUpDown();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dd = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Txt_ProductNameUp = new MetroFramework.Controls.MetroTextBox();
            this.EditBtn = new MetroFramework.Controls.MetroButton();
            this.cancleBtn = new MetroFramework.Controls.MetroButton();
            this.Btn_SaveProduct = new MetroFramework.Controls.MetroButton();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priceorigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_AddProductName)).BeginInit();
            this.AddProPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscountProUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantityProUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIncomingPriceProUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndvidualPriceProUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalPriceProUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantityPackageProUp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SalesBill
            // 
            this.dgv_SalesBill.AllowUserToAddRows = false;
            this.dgv_SalesBill.AllowUserToDeleteRows = false;
            this.dgv_SalesBill.AllowUserToOrderColumns = true;
            this.dgv_SalesBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SalesBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SalesBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supplier,
            this.Discount,
            this.Priceorigin,
            this.Quantity,
            this.Category,
            this.ProName,
            this.ID});
            this.dgv_SalesBill.Location = new System.Drawing.Point(482, 87);
            this.dgv_SalesBill.Name = "dgv_SalesBill";
            this.dgv_SalesBill.ReadOnly = true;
            this.dgv_SalesBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SalesBill.Size = new System.Drawing.Size(749, 633);
            this.dgv_SalesBill.TabIndex = 28;
            this.dgv_SalesBill.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_SalesBill_RowHeaderMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(482, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 38);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchBtnInGridView
            // 
            this.SearchBtnInGridView.Location = new System.Drawing.Point(654, 38);
            this.SearchBtnInGridView.Name = "SearchBtnInGridView";
            this.SearchBtnInGridView.Size = new System.Drawing.Size(69, 38);
            this.SearchBtnInGridView.TabIndex = 31;
            this.SearchBtnInGridView.Text = "بحث";
            // 
            // deleteBtnProduct
            // 
            this.deleteBtnProduct.Location = new System.Drawing.Point(857, 38);
            this.deleteBtnProduct.Name = "deleteBtnProduct";
            this.deleteBtnProduct.Size = new System.Drawing.Size(69, 38);
            this.deleteBtnProduct.TabIndex = 30;
            this.deleteBtnProduct.Text = "مسح";
            this.deleteBtnProduct.Visible = false;
            this.deleteBtnProduct.Click += new System.EventHandler(this.deleteBtnProduct_Click);
            // 
            // editBtnProduct
            // 
            this.editBtnProduct.Location = new System.Drawing.Point(983, 38);
            this.editBtnProduct.Name = "editBtnProduct";
            this.editBtnProduct.Size = new System.Drawing.Size(69, 38);
            this.editBtnProduct.TabIndex = 29;
            this.editBtnProduct.Text = "تعديل";
            this.editBtnProduct.Visible = false;
            this.editBtnProduct.Click += new System.EventHandler(this.editBtnProduct_Click);
            // 
            // btn_addPro
            // 
            this.btn_addPro.Location = new System.Drawing.Point(1120, 38);
            this.btn_addPro.Name = "btn_addPro";
            this.btn_addPro.Size = new System.Drawing.Size(69, 38);
            this.btn_addPro.TabIndex = 33;
            this.btn_addPro.Text = "إضافة";
            this.btn_addPro.Click += new System.EventHandler(this.btn_addPro_Click);
            // 
            // Txt_AddProductName
            // 
            this.Txt_AddProductName.Owner = null;
            // 
            // AddProPanel
            // 
            this.AddProPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddProPanel.Controls.Add(this.numericDiscountProUp);
            this.AddProPanel.Controls.Add(this.Como_productUnitUpdate);
            this.AddProPanel.Controls.Add(this.Como_productCategoryUpdate);
            this.AddProPanel.Controls.Add(this.Como_productBuySupplierUp);
            this.AddProPanel.Controls.Add(this.metroLabel8);
            this.AddProPanel.Controls.Add(this.metroLabel9);
            this.AddProPanel.Controls.Add(this.metroLabel10);
            this.AddProPanel.Controls.Add(this.metroLabel11);
            this.AddProPanel.Controls.Add(this.numericQuantityProUp);
            this.AddProPanel.Controls.Add(this.numericIncomingPriceProUp);
            this.AddProPanel.Controls.Add(this.numericIndvidualPriceProUp);
            this.AddProPanel.Controls.Add(this.numericTotalPriceProUp);
            this.AddProPanel.Controls.Add(this.numericQuantityPackageProUp);
            this.AddProPanel.Controls.Add(this.metroLabel4);
            this.AddProPanel.Controls.Add(this.metroLabel5);
            this.AddProPanel.Controls.Add(this.dd);
            this.AddProPanel.Controls.Add(this.metroLabel2);
            this.AddProPanel.Controls.Add(this.metroLabel3);
            this.AddProPanel.Controls.Add(this.metroLabel1);
            this.AddProPanel.Controls.Add(this.Txt_ProductNameUp);
            this.AddProPanel.Controls.Add(this.EditBtn);
            this.AddProPanel.Controls.Add(this.cancleBtn);
            this.AddProPanel.Controls.Add(this.Btn_SaveProduct);
            this.AddProPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProPanel.HorizontalScrollbarBarColor = true;
            this.AddProPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AddProPanel.HorizontalScrollbarSize = 10;
            this.AddProPanel.Location = new System.Drawing.Point(12, 38);
            this.AddProPanel.Name = "AddProPanel";
            this.AddProPanel.Size = new System.Drawing.Size(430, 645);
            this.AddProPanel.TabIndex = 34;
            this.AddProPanel.VerticalScrollbarBarColor = true;
            this.AddProPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AddProPanel.VerticalScrollbarSize = 10;
            this.AddProPanel.Visible = false;
            // 
            // numericDiscountProUp
            // 
            this.numericDiscountProUp.DecimalPlaces = 2;
            this.numericDiscountProUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiscountProUp.Location = new System.Drawing.Point(49, 478);
            this.numericDiscountProUp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericDiscountProUp.Name = "numericDiscountProUp";
            this.numericDiscountProUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericDiscountProUp.Size = new System.Drawing.Size(200, 27);
            this.numericDiscountProUp.TabIndex = 69;
            // 
            // Como_productUnitUpdate
            // 
            this.Como_productUnitUpdate.FormattingEnabled = true;
            this.Como_productUnitUpdate.ItemHeight = 23;
            this.Como_productUnitUpdate.Location = new System.Drawing.Point(49, 419);
            this.Como_productUnitUpdate.Name = "Como_productUnitUpdate";
            this.Como_productUnitUpdate.Size = new System.Drawing.Size(200, 29);
            this.Como_productUnitUpdate.Style = MetroFramework.MetroColorStyle.White;
            this.Como_productUnitUpdate.TabIndex = 68;
            this.Como_productUnitUpdate.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Como_productCategoryUpdate
            // 
            this.Como_productCategoryUpdate.FormattingEnabled = true;
            this.Como_productCategoryUpdate.ItemHeight = 23;
            this.Como_productCategoryUpdate.Location = new System.Drawing.Point(49, 368);
            this.Como_productCategoryUpdate.Name = "Como_productCategoryUpdate";
            this.Como_productCategoryUpdate.Size = new System.Drawing.Size(200, 29);
            this.Como_productCategoryUpdate.TabIndex = 67;
            // 
            // Como_productBuySupplierUp
            // 
            this.Como_productBuySupplierUp.FormattingEnabled = true;
            this.Como_productBuySupplierUp.ItemHeight = 23;
            this.Como_productBuySupplierUp.Location = new System.Drawing.Point(49, 316);
            this.Como_productBuySupplierUp.Name = "Como_productBuySupplierUp";
            this.Como_productBuySupplierUp.Size = new System.Drawing.Size(200, 29);
            this.Como_productBuySupplierUp.TabIndex = 66;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(297, 479);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(74, 19);
            this.metroLabel8.TabIndex = 65;
            this.metroLabel8.Text = "التخفيضات";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(326, 378);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(37, 19);
            this.metroLabel9.TabIndex = 62;
            this.metroLabel9.Text = "الفئة";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(291, 419);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(82, 19);
            this.metroLabel10.TabIndex = 63;
            this.metroLabel10.Text = "وحدة المعيار";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(326, 316);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(45, 19);
            this.metroLabel11.TabIndex = 64;
            this.metroLabel11.Text = "المورد";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericQuantityProUp
            // 
            this.numericQuantityProUp.DecimalPlaces = 2;
            this.numericQuantityProUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantityProUp.Location = new System.Drawing.Point(49, 70);
            this.numericQuantityProUp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericQuantityProUp.Name = "numericQuantityProUp";
            this.numericQuantityProUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericQuantityProUp.Size = new System.Drawing.Size(200, 27);
            this.numericQuantityProUp.TabIndex = 61;
            // 
            // numericIncomingPriceProUp
            // 
            this.numericIncomingPriceProUp.DecimalPlaces = 2;
            this.numericIncomingPriceProUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericIncomingPriceProUp.Location = new System.Drawing.Point(49, 121);
            this.numericIncomingPriceProUp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericIncomingPriceProUp.Name = "numericIncomingPriceProUp";
            this.numericIncomingPriceProUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericIncomingPriceProUp.Size = new System.Drawing.Size(200, 27);
            this.numericIncomingPriceProUp.TabIndex = 60;
            // 
            // numericIndvidualPriceProUp
            // 
            this.numericIndvidualPriceProUp.DecimalPlaces = 2;
            this.numericIndvidualPriceProUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericIndvidualPriceProUp.Location = new System.Drawing.Point(49, 171);
            this.numericIndvidualPriceProUp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericIndvidualPriceProUp.Name = "numericIndvidualPriceProUp";
            this.numericIndvidualPriceProUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericIndvidualPriceProUp.Size = new System.Drawing.Size(200, 27);
            this.numericIndvidualPriceProUp.TabIndex = 59;
            // 
            // numericTotalPriceProUp
            // 
            this.numericTotalPriceProUp.DecimalPlaces = 2;
            this.numericTotalPriceProUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericTotalPriceProUp.Location = new System.Drawing.Point(49, 218);
            this.numericTotalPriceProUp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericTotalPriceProUp.Name = "numericTotalPriceProUp";
            this.numericTotalPriceProUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericTotalPriceProUp.Size = new System.Drawing.Size(200, 27);
            this.numericTotalPriceProUp.TabIndex = 58;
            // 
            // numericQuantityPackageProUp
            // 
            this.numericQuantityPackageProUp.DecimalPlaces = 2;
            this.numericQuantityPackageProUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericQuantityPackageProUp.Location = new System.Drawing.Point(49, 261);
            this.numericQuantityPackageProUp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericQuantityPackageProUp.Name = "numericQuantityPackageProUp";
            this.numericQuantityPackageProUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericQuantityPackageProUp.Size = new System.Drawing.Size(200, 27);
            this.numericQuantityPackageProUp.TabIndex = 57;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(264, 261);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 56;
            this.metroLabel4.Text = "الكمية في الباكج";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(278, 206);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 19);
            this.metroLabel5.TabIndex = 55;
            this.metroLabel5.Text = "السعر بالجملة";
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.dd.Location = new System.Drawing.Point(274, 155);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(96, 19);
            this.dd.TabIndex = 54;
            this.dd.Text = "السعر بالقطعة";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(308, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "الكمية";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(275, 112);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(92, 19);
            this.metroLabel3.TabIndex = 52;
            this.metroLabel3.Text = "السعر الاصلي";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(293, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 53;
            this.metroLabel1.Text = "اسم المنتج";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_ProductNameUp
            // 
            this.Txt_ProductNameUp.Location = new System.Drawing.Point(49, 8);
            this.Txt_ProductNameUp.Name = "Txt_ProductNameUp";
            this.Txt_ProductNameUp.Size = new System.Drawing.Size(200, 30);
            this.Txt_ProductNameUp.TabIndex = 50;
            this.Txt_ProductNameUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditBtn
            // 
            this.EditBtn.Highlight = true;
            this.EditBtn.Location = new System.Drawing.Point(228, 568);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(150, 40);
            this.EditBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.EditBtn.TabIndex = 49;
            this.EditBtn.Text = "تعديل";
            this.EditBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // cancleBtn
            // 
            this.cancleBtn.Highlight = true;
            this.cancleBtn.Location = new System.Drawing.Point(36, 568);
            this.cancleBtn.Name = "cancleBtn";
            this.cancleBtn.Size = new System.Drawing.Size(150, 40);
            this.cancleBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.cancleBtn.TabIndex = 48;
            this.cancleBtn.Text = "الغاء";
            this.cancleBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Btn_SaveProduct
            // 
            this.Btn_SaveProduct.Highlight = true;
            this.Btn_SaveProduct.Location = new System.Drawing.Point(228, 568);
            this.Btn_SaveProduct.Name = "Btn_SaveProduct";
            this.Btn_SaveProduct.Size = new System.Drawing.Size(150, 40);
            this.Btn_SaveProduct.Style = MetroFramework.MetroColorStyle.Green;
            this.Btn_SaveProduct.TabIndex = 19;
            this.Btn_SaveProduct.Text = "حفظ";
            this.Btn_SaveProduct.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Btn_SaveProduct.Click += new System.EventHandler(this.Btn_SaveProduct_Click);
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "اسم المورد";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "التخفيضات";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Priceorigin
            // 
            this.Priceorigin.HeaderText = "السعر الاصلي";
            this.Priceorigin.Name = "Priceorigin";
            this.Priceorigin.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "الفئة";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // ProName
            // 
            this.ProName.HeaderText = "اسم المنتج";
            this.ProName.Name = "ProName";
            this.ProName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "الرقم";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 670);
            this.Controls.Add(this.AddProPanel);
            this.Controls.Add(this.btn_addPro);
            this.Controls.Add(this.dgv_SalesBill);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchBtnInGridView);
            this.Controls.Add(this.deleteBtnProduct);
            this.Controls.Add(this.editBtnProduct);
            this.Name = "ProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SalesBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_AddProductName)).EndInit();
            this.AddProPanel.ResumeLayout(false);
            this.AddProPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscountProUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantityProUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIncomingPriceProUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndvidualPriceProUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalPriceProUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantityPackageProUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_SalesBill;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton SearchBtnInGridView;
        public MetroFramework.Controls.MetroButton deleteBtnProduct;
        public MetroFramework.Controls.MetroButton editBtnProduct;
        public MetroFramework.Controls.MetroButton btn_addPro;
        private MetroFramework.Components.MetroStyleManager Txt_AddProductName;
        private MetroFramework.Controls.MetroPanel AddProPanel;
        public MetroFramework.Controls.MetroButton cancleBtn;
        public MetroFramework.Controls.MetroButton Btn_SaveProduct;
        public MetroFramework.Controls.MetroButton EditBtn;
        private System.Windows.Forms.NumericUpDown numericDiscountProUp;
        private MetroFramework.Controls.MetroComboBox Como_productUnitUpdate;
        private MetroFramework.Controls.MetroComboBox Como_productCategoryUpdate;
        private MetroFramework.Controls.MetroComboBox Como_productBuySupplierUp;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.NumericUpDown numericQuantityProUp;
        private System.Windows.Forms.NumericUpDown numericIncomingPriceProUp;
        private System.Windows.Forms.NumericUpDown numericIndvidualPriceProUp;
        private System.Windows.Forms.NumericUpDown numericTotalPriceProUp;
        private System.Windows.Forms.NumericUpDown numericQuantityPackageProUp;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel dd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Txt_ProductNameUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priceorigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}