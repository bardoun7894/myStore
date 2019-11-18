namespace MyStore
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.lblbranch = new System.Windows.Forms.Label();
            this.lblstore = new System.Windows.Forms.Label();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxWarn = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textProduct = new System.Windows.Forms.TextBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.textProductCode = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.storeId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lblbranch
            // 
            this.lblbranch.AutoSize = true;
            this.lblbranch.Location = new System.Drawing.Point(-39, 57);
            this.lblbranch.Name = "lblbranch";
            this.lblbranch.Size = new System.Drawing.Size(35, 13);
            this.lblbranch.TabIndex = 38;
            this.lblbranch.Text = "label1";
            // 
            // lblstore
            // 
            this.lblstore.AutoSize = true;
            this.lblstore.Location = new System.Drawing.Point(-50, 28);
            this.lblstore.Name = "lblstore";
            this.lblstore.Size = new System.Drawing.Size(35, 13);
            this.lblstore.TabIndex = 37;
            this.lblstore.Text = "label1";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(633, 319);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(44, 29);
            this.bunifuCustomLabel6.TabIndex = 60;
            this.bunifuCustomLabel6.Text = "الفئة";
            // 
            // comboCategory
            // 
            this.comboCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(256, 323);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCategory.Size = new System.Drawing.Size(326, 25);
            this.comboCategory.TabIndex = 59;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(634, 271);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(46, 29);
            this.bunifuCustomLabel5.TabIndex = 58;
            this.bunifuCustomLabel5.Text = "السعر";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(631, 214);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(41, 29);
            this.bunifuCustomLabel3.TabIndex = 57;
            this.bunifuCustomLabel3.Text = "انذار";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.White;
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxPrice.Location = new System.Drawing.Point(256, 271);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPrice.Size = new System.Drawing.Size(326, 25);
            this.textBoxPrice.TabIndex = 56;
            // 
            // textBoxWarn
            // 
            this.textBoxWarn.BackColor = System.Drawing.Color.White;
            this.textBoxWarn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxWarn.Location = new System.Drawing.Point(256, 218);
            this.textBoxWarn.Name = "textBoxWarn";
            this.textBoxWarn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxWarn.Size = new System.Drawing.Size(326, 25);
            this.textBoxWarn.TabIndex = 55;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(620, 160);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(57, 29);
            this.bunifuCustomLabel4.TabIndex = 50;
            this.bunifuCustomLabel4.Text = "الكمية";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.BackColor = System.Drawing.Color.White;
            this.textBoxQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxQuantity.Location = new System.Drawing.Point(256, 163);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxQuantity.Size = new System.Drawing.Size(326, 25);
            this.textBoxQuantity.TabIndex = 49;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(620, 42);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(52, 29);
            this.bunifuCustomLabel2.TabIndex = 48;
            this.bunifuCustomLabel2.Text = "المنتج";
            // 
            // textProduct
            // 
            this.textProduct.BackColor = System.Drawing.Color.White;
            this.textProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textProduct.Location = new System.Drawing.Point(256, 46);
            this.textProduct.Name = "textProduct";
            this.textProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textProduct.Size = new System.Drawing.Size(326, 25);
            this.textProduct.TabIndex = 47;
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSave.ButtonText = "حفظ";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(356, 411);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(135, 43);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(633, 367);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(63, 29);
            this.bunifuCustomLabel8.TabIndex = 62;
            this.bunifuCustomLabel8.Text = "الوحدة";
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(256, 371);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxUnit.Size = new System.Drawing.Size(326, 25);
            this.comboBoxUnit.TabIndex = 61;
            // 
            // textProductCode
            // 
            this.textProductCode.BackColor = System.Drawing.Color.White;
            this.textProductCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textProductCode.Location = new System.Drawing.Point(256, 108);
            this.textProductCode.Name = "textProductCode";
            this.textProductCode.ReadOnly = true;
            this.textProductCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textProductCode.Size = new System.Drawing.Size(326, 25);
            this.textProductCode.TabIndex = 63;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(605, 104);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(91, 29);
            this.bunifuCustomLabel1.TabIndex = 64;
            this.bunifuCustomLabel1.Text = "كود المنتج";
            // 
            // storeId
            // 
            this.storeId.AutoSize = true;
            this.storeId.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.storeId.ForeColor = System.Drawing.Color.White;
            this.storeId.Location = new System.Drawing.Point(49, 79);
            this.storeId.Name = "storeId";
            this.storeId.Size = new System.Drawing.Size(85, 29);
            this.storeId.TabIndex = 65;
            this.storeId.Text = "اdddلمنتج";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(892, 484);
            this.Controls.Add(this.storeId);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.textProductCode);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.comboBoxUnit);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxWarn);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.textProduct);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblbranch);
            this.Controls.Add(this.lblstore);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbranch;
        private System.Windows.Forms.Label lblstore;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.ComboBox comboCategory;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxWarn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox textProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.TextBox textProductCode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel storeId;
    }
}