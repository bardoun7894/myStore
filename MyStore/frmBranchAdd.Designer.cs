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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.bfbEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBranch = new System.Windows.Forms.TextBox();
            this.btnSaveBranch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.bfbEdit);
            this.groupBox1.Controls.Add(this.bfbDelete);
            this.groupBox1.Controls.Add(this.bunifuCustomDataGrid1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBranch);
            this.groupBox1.Controls.Add(this.btnSaveBranch);
            this.groupBox1.Font = new System.Drawing.Font("عصري عادي", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فروع الشركة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Enabled = false;
            this.lblId.Location = new System.Drawing.Point(421, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 14);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "label2";
            this.lblId.Visible = false;
            this.lblId.Click += new System.EventHandler(this.label2_Click);
            // 
            // bfbEdit
            // 
            this.bfbEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbEdit.BorderRadius = 0;
            this.bfbEdit.ButtonText = "تعديل";
            this.bfbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbEdit.DisabledColor = System.Drawing.Color.Gray;
            this.bfbEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbEdit.Iconimage")));
            this.bfbEdit.Iconimage_right = null;
            this.bfbEdit.Iconimage_right_Selected = null;
            this.bfbEdit.Iconimage_Selected = null;
            this.bfbEdit.IconMarginLeft = 0;
            this.bfbEdit.IconMarginRight = 0;
            this.bfbEdit.IconRightVisible = true;
            this.bfbEdit.IconRightZoom = 0D;
            this.bfbEdit.IconVisible = true;
            this.bfbEdit.IconZoom = 90D;
            this.bfbEdit.IsTab = false;
            this.bfbEdit.Location = new System.Drawing.Point(262, 59);
            this.bfbEdit.Name = "bfbEdit";
            this.bfbEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfbEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbEdit.selected = false;
            this.bfbEdit.Size = new System.Drawing.Size(99, 33);
            this.bfbEdit.TabIndex = 6;
            this.bfbEdit.Text = "تعديل";
            this.bfbEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbEdit.Textcolor = System.Drawing.Color.White;
            this.bfbEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbEdit.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bfbDelete
            // 
            this.bfbDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfbDelete.BackColor = System.Drawing.Color.Red;
            this.bfbDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbDelete.BorderRadius = 1;
            this.bfbDelete.ButtonText = "   حذف";
            this.bfbDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbDelete.DisabledColor = System.Drawing.Color.Gray;
            this.bfbDelete.Font = new System.Drawing.Font("هشام غرناطة طبيعي", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbDelete.Iconimage")));
            this.bfbDelete.Iconimage_right = null;
            this.bfbDelete.Iconimage_right_Selected = null;
            this.bfbDelete.Iconimage_Selected = null;
            this.bfbDelete.IconMarginLeft = 0;
            this.bfbDelete.IconMarginRight = 0;
            this.bfbDelete.IconRightVisible = true;
            this.bfbDelete.IconRightZoom = 0D;
            this.bfbDelete.IconVisible = true;
            this.bfbDelete.IconZoom = 60D;
            this.bfbDelete.IsTab = false;
            this.bfbDelete.Location = new System.Drawing.Point(134, 59);
            this.bfbDelete.Name = "bfbDelete";
            this.bfbDelete.Normalcolor = System.Drawing.Color.Red;
            this.bfbDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfbDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbDelete.selected = false;
            this.bfbDelete.Size = new System.Drawing.Size(86, 33);
            this.bfbDelete.TabIndex = 4;
            this.bfbDelete.Text = "   حذف";
            this.bfbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbDelete.Textcolor = System.Drawing.Color.White;
            this.bfbDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbDelete.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.bunifuCustomDataGrid1.AllowDrop = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("عصري عادي", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(123)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("عصري عادي", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 30;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(123)))), ((int)(((byte)(226)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 112);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("عصري عادي", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(487, 296);
            this.bunifuCustomDataGrid1.StandardTab = true;
            this.bunifuCustomDataGrid1.TabIndex = 3;
            this.bunifuCustomDataGrid1.VirtualMode = true;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("عصري عادي", 9F);
            this.label1.Location = new System.Drawing.Point(450, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "الفرع";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxBranch
            // 
            this.textBoxBranch.Location = new System.Drawing.Point(96, 24);
            this.textBoxBranch.Name = "textBoxBranch";
            this.textBoxBranch.Size = new System.Drawing.Size(318, 21);
            this.textBoxBranch.TabIndex = 1;
            this.textBoxBranch.TextChanged += new System.EventHandler(this.textBoxBranch_TextChanged);
            // 
            // btnSaveBranch
            // 
            this.btnSaveBranch.Font = new System.Drawing.Font("عصري عادي", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveBranch.Location = new System.Drawing.Point(0, 24);
            this.btnSaveBranch.Name = "btnSaveBranch";
            this.btnSaveBranch.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBranch.TabIndex = 0;
            this.btnSaveBranch.Text = "اضافة";
            this.btnSaveBranch.UseVisualStyleBackColor = true;
            this.btnSaveBranch.Click += new System.EventHandler(this.btnSaveBranch_Click);
            // 
            // frmBranchAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(209)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBranchAdd";
            this.Text = "frmBranchAdd";
            this.Load += new System.EventHandler(this.frmBranchAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBranch;
        private System.Windows.Forms.Button btnSaveBranch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuFlatButton bfbEdit;
        private Bunifu.Framework.UI.BunifuFlatButton bfbDelete;
        private System.Windows.Forms.Label lblId;
    }
}