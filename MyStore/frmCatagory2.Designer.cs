namespace MyStore
{
    partial class frmCatagory2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatagory2));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblId1 = new System.Windows.Forms.Label();
            this.categorytext = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bfbEditCatagory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbDeleteCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveCatagory = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("هشام قرطبة", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 40;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("هشام قرطبة", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(12, 69);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 26;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(776, 318);
            this.bunifuCustomDataGrid1.TabIndex = 32;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            this.bunifuCustomDataGrid1.SelectionChanged += new System.EventHandler(this.bunifuCustomDataGrid1_SelectionChanged);
            // 
            // lblId1
            // 
            this.lblId1.AutoSize = true;
            this.lblId1.Location = new System.Drawing.Point(26, 34);
            this.lblId1.Name = "lblId1";
            this.lblId1.Size = new System.Drawing.Size(35, 13);
            this.lblId1.TabIndex = 29;
            this.lblId1.Text = "label1";
            // 
            // categorytext
            // 
            this.categorytext.BorderColor = System.Drawing.Color.SeaGreen;
            this.categorytext.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorytext.Location = new System.Drawing.Point(210, 27);
            this.categorytext.Name = "categorytext";
            this.categorytext.ReadOnly = true;
            this.categorytext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categorytext.Size = new System.Drawing.Size(298, 25);
            this.categorytext.TabIndex = 33;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(534, 27);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(44, 29);
            this.bunifuCustomLabel3.TabIndex = 34;
            this.bunifuCustomLabel3.Text = "الفئة";
            // 
            // bfbEditCatagory
            // 
            this.bfbEditCatagory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbEditCatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbEditCatagory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbEditCatagory.BorderRadius = 0;
            this.bfbEditCatagory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bfbEditCatagory.ButtonText = "     تعديل";
            this.bfbEditCatagory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbEditCatagory.DisabledColor = System.Drawing.Color.Gray;
            this.bfbEditCatagory.Font = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbEditCatagory.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbEditCatagory.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbEditCatagory.Iconimage")));
            this.bfbEditCatagory.Iconimage_right = null;
            this.bfbEditCatagory.Iconimage_right_Selected = null;
            this.bfbEditCatagory.Iconimage_Selected = null;
            this.bfbEditCatagory.IconMarginLeft = 0;
            this.bfbEditCatagory.IconMarginRight = 0;
            this.bfbEditCatagory.IconRightVisible = true;
            this.bfbEditCatagory.IconRightZoom = 0D;
            this.bfbEditCatagory.IconVisible = true;
            this.bfbEditCatagory.IconZoom = 50D;
            this.bfbEditCatagory.IsTab = false;
            this.bfbEditCatagory.Location = new System.Drawing.Point(329, 394);
            this.bfbEditCatagory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bfbEditCatagory.Name = "bfbEditCatagory";
            this.bfbEditCatagory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbEditCatagory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfbEditCatagory.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbEditCatagory.selected = false;
            this.bfbEditCatagory.Size = new System.Drawing.Size(135, 43);
            this.bfbEditCatagory.TabIndex = 37;
            this.bfbEditCatagory.Text = "     تعديل";
            this.bfbEditCatagory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbEditCatagory.Textcolor = System.Drawing.Color.White;
            this.bfbEditCatagory.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbEditCatagory.Click += new System.EventHandler(this.bfbEditBranches_Click);
            // 
            // bfbDeleteCategory
            // 
            this.bfbDeleteCategory.Activecolor = System.Drawing.Color.Red;
            this.bfbDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbDeleteCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbDeleteCategory.BorderRadius = 0;
            this.bfbDeleteCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bfbDeleteCategory.ButtonText = "    حذف  ";
            this.bfbDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbDeleteCategory.DisabledColor = System.Drawing.Color.Gray;
            this.bfbDeleteCategory.Font = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbDeleteCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbDeleteCategory.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbDeleteCategory.Iconimage")));
            this.bfbDeleteCategory.Iconimage_right = null;
            this.bfbDeleteCategory.Iconimage_right_Selected = null;
            this.bfbDeleteCategory.Iconimage_Selected = null;
            this.bfbDeleteCategory.IconMarginLeft = 10;
            this.bfbDeleteCategory.IconMarginRight = 0;
            this.bfbDeleteCategory.IconRightVisible = true;
            this.bfbDeleteCategory.IconRightZoom = 0D;
            this.bfbDeleteCategory.IconVisible = true;
            this.bfbDeleteCategory.IconZoom = 60D;
            this.bfbDeleteCategory.IsTab = false;
            this.bfbDeleteCategory.Location = new System.Drawing.Point(166, 394);
            this.bfbDeleteCategory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bfbDeleteCategory.Name = "bfbDeleteCategory";
            this.bfbDeleteCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbDeleteCategory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfbDeleteCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbDeleteCategory.selected = false;
            this.bfbDeleteCategory.Size = new System.Drawing.Size(135, 43);
            this.bfbDeleteCategory.TabIndex = 36;
            this.bfbDeleteCategory.Text = "    حذف  ";
            this.bfbDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbDeleteCategory.Textcolor = System.Drawing.Color.White;
            this.bfbDeleteCategory.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbDeleteCategory.Click += new System.EventHandler(this.bfbDeleteBranches_Click);
            // 
            // btnSaveCatagory
            // 
            this.btnSaveCatagory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveCatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.btnSaveCatagory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveCatagory.BorderRadius = 0;
            this.btnSaveCatagory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSaveCatagory.ButtonText = "إضافة";
            this.btnSaveCatagory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCatagory.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveCatagory.Font = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveCatagory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveCatagory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveCatagory.Iconimage")));
            this.btnSaveCatagory.Iconimage_right = null;
            this.btnSaveCatagory.Iconimage_right_Selected = null;
            this.btnSaveCatagory.Iconimage_Selected = null;
            this.btnSaveCatagory.IconMarginLeft = 0;
            this.btnSaveCatagory.IconMarginRight = 0;
            this.btnSaveCatagory.IconRightVisible = true;
            this.btnSaveCatagory.IconRightZoom = 0D;
            this.btnSaveCatagory.IconVisible = true;
            this.btnSaveCatagory.IconZoom = 90D;
            this.btnSaveCatagory.IsTab = false;
            this.btnSaveCatagory.Location = new System.Drawing.Point(506, 394);
            this.btnSaveCatagory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveCatagory.Name = "btnSaveCatagory";
            this.btnSaveCatagory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.btnSaveCatagory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveCatagory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveCatagory.selected = false;
            this.btnSaveCatagory.Size = new System.Drawing.Size(149, 43);
            this.btnSaveCatagory.TabIndex = 28;
            this.btnSaveCatagory.Text = "إضافة";
            this.btnSaveCatagory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCatagory.Textcolor = System.Drawing.Color.White;
            this.btnSaveCatagory.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveCatagory.Click += new System.EventHandler(this.btnSaveBranchStore_Click);
            // 
            // frmCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bfbEditCatagory);
            this.Controls.Add(this.bfbDeleteCategory);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.categorytext);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.lblId1);
            this.Controls.Add(this.btnSaveCatagory);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmCatagory";
            this.Text = "frmCatagory";
            this.Load += new System.EventHandler(this.frmCatagory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Label lblId1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveCatagory;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox categorytext;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton bfbEditCatagory;
        private Bunifu.Framework.UI.BunifuFlatButton bfbDeleteCategory;
    }
}