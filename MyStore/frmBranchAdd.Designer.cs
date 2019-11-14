namespace MyStore
{
    partial class frmBranchAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBranchAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblId = new System.Windows.Forms.Label();
            this.bfbEditBranches = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bfbDeleteBranches = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBoxBranch = new System.Windows.Forms.TextBox();
            this.btnSaveBranchStore = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Enabled = false;
            this.lblId.Location = new System.Drawing.Point(25, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "label2";
            this.lblId.Visible = false;
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // bfbEditBranches
            // 
            this.bfbEditBranches.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbEditBranches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbEditBranches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbEditBranches.BorderRadius = 0;
            this.bfbEditBranches.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bfbEditBranches.ButtonText = "     تعديل";
            this.bfbEditBranches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbEditBranches.DisabledColor = System.Drawing.Color.Gray;
            this.bfbEditBranches.Font = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbEditBranches.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbEditBranches.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbEditBranches.Iconimage")));
            this.bfbEditBranches.Iconimage_right = null;
            this.bfbEditBranches.Iconimage_right_Selected = null;
            this.bfbEditBranches.Iconimage_Selected = null;
            this.bfbEditBranches.IconMarginLeft = 0;
            this.bfbEditBranches.IconMarginRight = 0;
            this.bfbEditBranches.IconRightVisible = true;
            this.bfbEditBranches.IconRightZoom = 0D;
            this.bfbEditBranches.IconVisible = true;
            this.bfbEditBranches.IconZoom = 50D;
            this.bfbEditBranches.IsTab = false;
            this.bfbEditBranches.Location = new System.Drawing.Point(159, 55);
            this.bfbEditBranches.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bfbEditBranches.Name = "bfbEditBranches";
            this.bfbEditBranches.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbEditBranches.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfbEditBranches.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbEditBranches.selected = false;
            this.bfbEditBranches.Size = new System.Drawing.Size(135, 43);
            this.bfbEditBranches.TabIndex = 22;
            this.bfbEditBranches.Text = "     تعديل";
            this.bfbEditBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbEditBranches.Textcolor = System.Drawing.Color.White;
            this.bfbEditBranches.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbEditBranches.Click += new System.EventHandler(this.bfbEditBranches_Click_1);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MO_Nawel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("عصري عادي", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 40;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MO_Nawel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(3, 164);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(946, 354);
            this.bunifuCustomDataGrid1.TabIndex = 20;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick_2);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("MO_Nawel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(871, 57);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(78, 29);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "اسم الفرع";
            // 
            // bfbDeleteBranches
            // 
            this.bfbDeleteBranches.Activecolor = System.Drawing.Color.Red;
            this.bfbDeleteBranches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbDeleteBranches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbDeleteBranches.BorderRadius = 0;
            this.bfbDeleteBranches.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bfbDeleteBranches.ButtonText = "    حذف  ";
            this.bfbDeleteBranches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbDeleteBranches.DisabledColor = System.Drawing.Color.Gray;
            this.bfbDeleteBranches.Font = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbDeleteBranches.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbDeleteBranches.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbDeleteBranches.Iconimage")));
            this.bfbDeleteBranches.Iconimage_right = null;
            this.bfbDeleteBranches.Iconimage_right_Selected = null;
            this.bfbDeleteBranches.Iconimage_Selected = null;
            this.bfbDeleteBranches.IconMarginLeft = 10;
            this.bfbDeleteBranches.IconMarginRight = 0;
            this.bfbDeleteBranches.IconRightVisible = true;
            this.bfbDeleteBranches.IconRightZoom = 0D;
            this.bfbDeleteBranches.IconVisible = true;
            this.bfbDeleteBranches.IconZoom = 60D;
            this.bfbDeleteBranches.IsTab = false;
            this.bfbDeleteBranches.Location = new System.Drawing.Point(14, 55);
            this.bfbDeleteBranches.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bfbDeleteBranches.Name = "bfbDeleteBranches";
            this.bfbDeleteBranches.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbDeleteBranches.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfbDeleteBranches.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbDeleteBranches.selected = false;
            this.bfbDeleteBranches.Size = new System.Drawing.Size(135, 43);
            this.bfbDeleteBranches.TabIndex = 21;
            this.bfbDeleteBranches.Text = "    حذف  ";
            this.bfbDeleteBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbDeleteBranches.Textcolor = System.Drawing.Color.White;
            this.bfbDeleteBranches.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbDeleteBranches.Click += new System.EventHandler(this.bfbDeleteBranches_Click_1);
            // 
            // textBoxBranch
            // 
            this.textBoxBranch.BackColor = System.Drawing.Color.White;
            this.textBoxBranch.Location = new System.Drawing.Point(447, 64);
            this.textBoxBranch.Name = "textBoxBranch";
            this.textBoxBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxBranch.Size = new System.Drawing.Size(418, 20);
            this.textBoxBranch.TabIndex = 16;
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
            this.btnSaveBranchStore.Location = new System.Drawing.Point(304, 55);
            this.btnSaveBranchStore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveBranchStore.Name = "btnSaveBranchStore";
            this.btnSaveBranchStore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.btnSaveBranchStore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveBranchStore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveBranchStore.selected = false;
            this.btnSaveBranchStore.Size = new System.Drawing.Size(135, 43);
            this.btnSaveBranchStore.TabIndex = 17;
            this.btnSaveBranchStore.Text = "إضافة";
            this.btnSaveBranchStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveBranchStore.Textcolor = System.Drawing.Color.White;
            this.btnSaveBranchStore.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveBranchStore.Click += new System.EventHandler(this.btnSaveBranchStore_Click_1);
            // 
            // frmBranchAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(950, 521);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.bfbEditBranches);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bfbDeleteBranches);
            this.Controls.Add(this.textBoxBranch);
            this.Controls.Add(this.btnSaveBranchStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBranchAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBranchAdd";
            this.Load += new System.EventHandler(this.frmBranchAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private Bunifu.Framework.UI.BunifuFlatButton bfbEditBranches;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bfbDeleteBranches;
        private System.Windows.Forms.TextBox textBoxBranch;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveBranchStore;
    }
}