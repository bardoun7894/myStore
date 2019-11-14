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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBranches_store));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblId1 = new System.Windows.Forms.Label();
            this.comboBranch = new System.Windows.Forms.ComboBox();
            this.bfbDeleteS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveBranchStore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtStore = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bfbEditStore = new Bunifu.Framework.UI.BunifuFlatButton();
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(3, 103);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 26;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(955, 347);
            this.bunifuCustomDataGrid1.TabIndex = 23;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // lblId1
            // 
            this.lblId1.AutoSize = true;
            this.lblId1.Location = new System.Drawing.Point(204, 68);
            this.lblId1.Name = "lblId1";
            this.lblId1.Size = new System.Drawing.Size(35, 15);
            this.lblId1.TabIndex = 20;
            this.lblId1.Text = "label1";
            this.lblId1.Visible = false;
            // 
            // comboBranch
            // 
            this.comboBranch.FormattingEnabled = true;
            this.comboBranch.Location = new System.Drawing.Point(310, 28);
            this.comboBranch.Name = "comboBranch";
            this.comboBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBranch.Size = new System.Drawing.Size(326, 23);
            this.comboBranch.TabIndex = 18;
            // 
            // bfbDeleteS
            // 
            this.bfbDeleteS.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
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
            this.bfbDeleteS.Location = new System.Drawing.Point(276, 456);
            this.bfbDeleteS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bfbDeleteS.Name = "bfbDeleteS";
            this.bfbDeleteS.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbDeleteS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfbDeleteS.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbDeleteS.selected = false;
            this.bfbDeleteS.Size = new System.Drawing.Size(135, 43);
            this.bfbDeleteS.TabIndex = 22;
            this.bfbDeleteS.Text = "    حذف  ";
            this.bfbDeleteS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbDeleteS.Textcolor = System.Drawing.Color.White;
            this.bfbDeleteS.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbDeleteS.Click += new System.EventHandler(this.bfbDeleteS_Click);
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
            this.btnSaveBranchStore.Location = new System.Drawing.Point(609, 456);
            this.btnSaveBranchStore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveBranchStore.Name = "btnSaveBranchStore";
            this.btnSaveBranchStore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.btnSaveBranchStore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveBranchStore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveBranchStore.selected = false;
            this.btnSaveBranchStore.Size = new System.Drawing.Size(135, 43);
            this.btnSaveBranchStore.TabIndex = 19;
            this.btnSaveBranchStore.Text = "إضافة";
            this.btnSaveBranchStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveBranchStore.Textcolor = System.Drawing.Color.White;
            this.btnSaveBranchStore.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveBranchStore.Click += new System.EventHandler(this.btnSaveBranchStore_Click_1);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(672, 68);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(58, 29);
            this.bunifuCustomLabel2.TabIndex = 17;
            this.bunifuCustomLabel2.Text = "المخزن";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(652, 22);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(78, 29);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "اسم الفرع";
            // 
            // txtStore
            // 
            this.txtStore.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtStore.Location = new System.Drawing.Point(310, 75);
            this.txtStore.Name = "txtStore";
            this.txtStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStore.Size = new System.Drawing.Size(326, 22);
            this.txtStore.TabIndex = 15;
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
            this.bfbEditStore.Location = new System.Drawing.Point(444, 456);
            this.bfbEditStore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bfbEditStore.Name = "bfbEditStore";
            this.bfbEditStore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbEditStore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfbEditStore.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbEditStore.selected = false;
            this.bfbEditStore.Size = new System.Drawing.Size(135, 43);
            this.bfbEditStore.TabIndex = 21;
            this.bfbEditStore.Text = "تعديل";
            this.bfbEditStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbEditStore.Textcolor = System.Drawing.Color.White;
            this.bfbEditStore.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbEditStore.Click += new System.EventHandler(this.bfbEditStore_Click);
            // 
            // frmBranches_store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(970, 521);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.lblId1);
            this.Controls.Add(this.comboBranch);
            this.Controls.Add(this.bfbDeleteS);
            this.Controls.Add(this.btnSaveBranchStore);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.bfbEditStore);
            this.Font = new System.Drawing.Font("هشام قرطبة", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBranches_store";
            this.Text = "frmBranches_store";
            this.Load += new System.EventHandler(this.frmBranches_store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Label lblId1;
        private System.Windows.Forms.ComboBox comboBranch;
        private Bunifu.Framework.UI.BunifuFlatButton bfbDeleteS;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveBranchStore;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtStore;
        private Bunifu.Framework.UI.BunifuFlatButton bfbEditStore;
    }
}