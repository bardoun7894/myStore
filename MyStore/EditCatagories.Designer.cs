namespace MyStore
{
    partial class EditCatagories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCatagories));
            this.label1 = new System.Windows.Forms.Label();
            this.categorytext = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblidC = new System.Windows.Forms.Label();
            this.bfbEditBranches = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbDeleteBranches = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveBranchStore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catagory";
            // 
            // categorytext
            // 
            this.categorytext.BorderColor = System.Drawing.Color.SeaGreen;
            this.categorytext.Location = new System.Drawing.Point(195, 42);
            this.categorytext.Name = "categorytext";
            this.categorytext.Size = new System.Drawing.Size(437, 20);
            this.categorytext.TabIndex = 1;
            // 
            // lblidC
            // 
            this.lblidC.AutoSize = true;
            this.lblidC.Location = new System.Drawing.Point(12, 120);
            this.lblidC.Name = "lblidC";
            this.lblidC.Size = new System.Drawing.Size(35, 13);
            this.lblidC.TabIndex = 3;
            this.lblidC.Text = "label2";
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
            this.bfbEditBranches.Location = new System.Drawing.Point(358, 90);
            this.bfbEditBranches.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bfbEditBranches.Name = "bfbEditBranches";
            this.bfbEditBranches.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbEditBranches.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfbEditBranches.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbEditBranches.selected = false;
            this.bfbEditBranches.Size = new System.Drawing.Size(135, 43);
            this.bfbEditBranches.TabIndex = 40;
            this.bfbEditBranches.Text = "     تعديل";
            this.bfbEditBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbEditBranches.Textcolor = System.Drawing.Color.White;
            this.bfbEditBranches.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bfbEditBranches.Click += new System.EventHandler(this.bfbEditBranches_Click);
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
            this.bfbDeleteBranches.Location = new System.Drawing.Point(195, 90);
            this.bfbDeleteBranches.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bfbDeleteBranches.Name = "bfbDeleteBranches";
            this.bfbDeleteBranches.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.bfbDeleteBranches.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bfbDeleteBranches.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbDeleteBranches.selected = false;
            this.bfbDeleteBranches.Size = new System.Drawing.Size(135, 43);
            this.bfbDeleteBranches.TabIndex = 39;
            this.bfbDeleteBranches.Text = "    حذف  ";
            this.bfbDeleteBranches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbDeleteBranches.Textcolor = System.Drawing.Color.White;
            this.bfbDeleteBranches.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
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
            this.btnSaveBranchStore.Location = new System.Drawing.Point(503, 90);
            this.btnSaveBranchStore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveBranchStore.Name = "btnSaveBranchStore";
            this.btnSaveBranchStore.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.btnSaveBranchStore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveBranchStore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveBranchStore.selected = false;
            this.btnSaveBranchStore.Size = new System.Drawing.Size(149, 43);
            this.btnSaveBranchStore.TabIndex = 38;
            this.btnSaveBranchStore.Text = "إضافة";
            this.btnSaveBranchStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveBranchStore.Textcolor = System.Drawing.Color.White;
            this.btnSaveBranchStore.TextFont = new System.Drawing.Font("هشام قرطبة", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveBranchStore.Click += new System.EventHandler(this.btnSaveBranchStore_Click);
            // 
            // EditCatagories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(810, 165);
            this.Controls.Add(this.bfbEditBranches);
            this.Controls.Add(this.bfbDeleteBranches);
            this.Controls.Add(this.btnSaveBranchStore);
            this.Controls.Add(this.lblidC);
            this.Controls.Add(this.categorytext);
            this.Controls.Add(this.label1);
            this.Name = "EditCatagories";
            this.Text = "EditCatagories";
            this.Load += new System.EventHandler(this.EditCatagories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox categorytext;
        private System.Windows.Forms.Label lblidC;
        private Bunifu.Framework.UI.BunifuFlatButton bfbEditBranches;
        private Bunifu.Framework.UI.BunifuFlatButton bfbDeleteBranches;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveBranchStore;
    }
}