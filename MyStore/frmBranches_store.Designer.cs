namespace MyStore
{
    partial class frmBranches_store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBranches_store));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtStore = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.comboBranch = new System.Windows.Forms.ComboBox();
            this.btnSaveBranchStore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblId1 = new System.Windows.Forms.Label();
            this.bfbEditStore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbDeleteS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStore
            // 
            this.txtStore.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtStore.Location = new System.Drawing.Point(161, 90);
            this.txtStore.Name = "txtStore";
            this.txtStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStore.Size = new System.Drawing.Size(326, 22);
            this.txtStore.TabIndex = 1;
            this.txtStore.TextChanged += new System.EventHandler(this.txtStore_TextChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(503, 37);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(78, 29);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "اسم الفرع";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(523, 83);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(58, 29);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "المخزن";
            // 
            // comboBranch
            // 
            this.comboBranch.FormattingEnabled = true;
            this.comboBranch.Location = new System.Drawing.Point(161, 43);
            this.comboBranch.Name = "comboBranch";
            this.comboBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBranch.Size = new System.Drawing.Size(326, 23);
            this.comboBranch.TabIndex = 4;
            // 
            // btnSaveBranchStore
            // 
            this.btnSaveBranchStore.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSaveBranchStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.btnSaveBranchStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveBranchStore.BorderRadius = 0;
            this.btnSaveBranchStore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSaveBranchStore.ButtonText = "إضافة";
            this.btnSaveBranchStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBranchStore.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveBranchStore.Font = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveBranchStore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveBranchStore.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSaveBranchStore.Iconimage")));
            this.btnSaveBranchStore.Iconimage_right = null;
            this.btnSaveBranchStore.Iconimage_right_Selected = null;
            this.btnSaveBranchStore.Iconimage_Selected = null;
            this.btnSaveBranchStore.IconMarginLeft = 0;
            this.btnSaveBranchStore.IconMarginRight = 0;
            this.btnSaveBranchStore.IconRightVisible = true;
            this.btnSaveBranchStore.IconRightZoom = 0D;
            this.btnSaveBranchStore.IconVisible = true;
            this.btnSaveBranchStore.IconZoom = 90D;
            this.btnSaveBranchStore.IsTab = false;
            this.btnSaveBranchStore.Location = new System.Drawing.Point(460, 471);
            this.btnSaveBranchStore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveBranchStore.Name = "btnSaveBranchStore";
            this.btnSaveBranchStore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.btnSaveBranchStore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveBranchStore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveBranchStore.selected = false;
            this.btnSaveBranchStore.Size = new System.Drawing.Size(135, 43);
            this.btnSaveBranchStore.TabIndex = 5;
            this.btnSaveBranchStore.Text = "إضافة";
            this.btnSaveBranchStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveBranchStore.Textcolor = System.Drawing.Color.White;
            this.btnSaveBranchStore.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveBranchStore.Click += new System.EventHandler(this.btnSaveBranchStore_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("هشام قرطبة", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(93, 126);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("هشام قرطبة", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("هشام قرطبة", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(528, 325);
            this.bunifuCustomDataGrid1.TabIndex = 8;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // lblId1
            // 
            this.lblId1.AutoSize = true;
            this.lblId1.Location = new System.Drawing.Point(55, 83);
            this.lblId1.Name = "lblId1";
            this.lblId1.Size = new System.Drawing.Size(35, 15);
            this.lblId1.TabIndex = 6;
            this.lblId1.Text = "label1";
            this.lblId1.Visible = false;
            this.lblId1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bfbEditStore
            // 
            this.bfbEditStore.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbEditStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbEditStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbEditStore.BorderRadius = 0;
            this.bfbEditStore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bfbEditStore.ButtonText = "تعديل";
            this.bfbEditStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbEditStore.DisabledColor = System.Drawing.Color.Gray;
            this.bfbEditStore.Font = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbEditStore.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbEditStore.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbEditStore.Iconimage")));
            this.bfbEditStore.Iconimage_right = null;
            this.bfbEditStore.Iconimage_right_Selected = null;
            this.bfbEditStore.Iconimage_Selected = null;
            this.bfbEditStore.IconMarginLeft = 0;
            this.bfbEditStore.IconMarginRight = 0;
            this.bfbEditStore.IconRightVisible = true;
            this.bfbEditStore.IconRightZoom = 0D;
            this.bfbEditStore.IconVisible = true;
            this.bfbEditStore.IconZoom = 90D;
            this.bfbEditStore.IsTab = false;
            this.bfbEditStore.Location = new System.Drawing.Point(295, 471);
            this.bfbEditStore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bfbEditStore.Name = "bfbEditStore";
            this.bfbEditStore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbEditStore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfbEditStore.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbEditStore.selected = false;
            this.bfbEditStore.Size = new System.Drawing.Size(135, 43);
            this.bfbEditStore.TabIndex = 12;
            this.bfbEditStore.Text = "تعديل";
            this.bfbEditStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbEditStore.Textcolor = System.Drawing.Color.White;
            this.bfbEditStore.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbEditStore.Click += new System.EventHandler(this.bfbEditStore_Click);
            // 
            // bfbDeleteS
            // 
            this.bfbDeleteS.Activecolor = System.Drawing.Color.Red;
            this.bfbDeleteS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbDeleteS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbDeleteS.BorderRadius = 0;
            this.bfbDeleteS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bfbDeleteS.ButtonText = "    حذف  ";
            this.bfbDeleteS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbDeleteS.DisabledColor = System.Drawing.Color.Gray;
            this.bfbDeleteS.Font = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbDeleteS.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbDeleteS.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbDeleteS.Iconimage")));
            this.bfbDeleteS.Iconimage_right = null;
            this.bfbDeleteS.Iconimage_right_Selected = null;
            this.bfbDeleteS.Iconimage_Selected = null;
            this.bfbDeleteS.IconMarginLeft = 10;
            this.bfbDeleteS.IconMarginRight = 0;
            this.bfbDeleteS.IconRightVisible = true;
            this.bfbDeleteS.IconRightZoom = 0D;
            this.bfbDeleteS.IconVisible = true;
            this.bfbDeleteS.IconZoom = 70D;
            this.bfbDeleteS.IsTab = false;
            this.bfbDeleteS.Location = new System.Drawing.Point(127, 471);
            this.bfbDeleteS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bfbDeleteS.Name = "bfbDeleteS";
            this.bfbDeleteS.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbDeleteS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfbDeleteS.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbDeleteS.selected = false;
            this.bfbDeleteS.Size = new System.Drawing.Size(135, 43);
            this.bfbDeleteS.TabIndex = 13;
            this.bfbDeleteS.Text = "    حذف  ";
            this.bfbDeleteS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbDeleteS.Textcolor = System.Drawing.Color.White;
            this.bfbDeleteS.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbDeleteS.Click += new System.EventHandler(this.bfbDeleteS_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Controls.Add(this.lblId1);
            this.groupBox1.Controls.Add(this.comboBranch);
            this.groupBox1.Controls.Add(this.bfbDeleteS);
            this.groupBox1.Controls.Add(this.btnSaveBranchStore);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.txtStore);
            this.groupBox1.Controls.Add(this.bfbEditStore);
            this.groupBox1.Location = new System.Drawing.Point(44, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 517);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmBranches_store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(941, 521);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("هشام قرطبة", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBranches_store";
            this.Text = "frmBranches_store";
            this.Load += new System.EventHandler(this.frmBranches_store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtStore;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox comboBranch;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveBranchStore;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuFlatButton bfbEditStore;
        private Bunifu.Framework.UI.BunifuFlatButton bfbDeleteS;
        private System.Windows.Forms.Label lblId1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}