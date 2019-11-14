using Bunifu.Framework.UI;

namespace MyStore
{
    partial class Form1Grid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Grid));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClients = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridViewMo = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Clients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClients
            // 
            this.btnClients.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClients.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClients.BorderRadius = 3;
            this.btnClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnClients.ButtonText = "     Add  Clients";
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.DisabledColor = System.Drawing.Color.Gray;
            this.btnClients.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClients.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClients.Iconimage")));
            this.btnClients.Iconimage_right = null;
            this.btnClients.Iconimage_right_Selected = null;
            this.btnClients.Iconimage_Selected = null;
            this.btnClients.IconMarginLeft = 0;
            this.btnClients.IconMarginRight = 0;
            this.btnClients.IconRightVisible = true;
            this.btnClients.IconRightZoom = 0D;
            this.btnClients.IconVisible = false;
            this.btnClients.IconZoom = 90D;
            this.btnClients.IsTab = false;
            this.btnClients.Location = new System.Drawing.Point(668, 20);
            this.btnClients.Name = "btnClients";
            this.btnClients.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnClients.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnClients.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClients.selected = false;
            this.btnClients.Size = new System.Drawing.Size(120, 36);
            this.btnClients.TabIndex = 11;
            this.btnClients.Text = "     Add  Clients";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Textcolor = System.Drawing.Color.White;
            this.btnClients.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dataGridViewMo
            // 
            this.dataGridViewMo.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMo.ColumnHeadersHeight = 40;
            this.dataGridViewMo.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewMo.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewMo.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMo.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewMo.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewMo.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewMo.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewMo.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewMo.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewMo.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMo.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewMo.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewMo.CurrentTheme.Name = null;
            this.dataGridViewMo.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewMo.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewMo.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMo.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewMo.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMo.EnableHeadersVisualStyles = false;
            this.dataGridViewMo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewMo.HeaderBackColor = System.Drawing.Color.DodgerBlue;
  //          this.dataGridViewMo.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewMo.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewMo.Location = new System.Drawing.Point(8, 95);
            this.dataGridViewMo.Name = "dataGridViewMo";
            this.dataGridViewMo.RowHeadersVisible = false;
            this.dataGridViewMo.RowTemplate.Height = 40;
            this.dataGridViewMo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMo.Size = new System.Drawing.Size(785, 347);
            this.dataGridViewMo.TabIndex = 13;
            this.dataGridViewMo.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(311, 42);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "label2";
            // 
            // Form1Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.dataGridViewMo);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.label1);
            this.Name = "Form1Grid";
            this.Text = "Form1Grid";
            this.Load += new System.EventHandler(this.Form1Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private BunifuFlatButton btnClients;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewMo;
        private System.Windows.Forms.Label lblid;
    }
}