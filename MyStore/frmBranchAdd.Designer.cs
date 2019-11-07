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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveBranch = new System.Windows.Forms.Button();
            this.textBoxBranch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBranch);
            this.groupBox1.Controls.Add(this.btnSaveBranch);
            this.groupBox1.Location = new System.Drawing.Point(59, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("عصري عادي", 9F);
            this.label1.Location = new System.Drawing.Point(200, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "الفرع";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaveBranch
            // 
            this.btnSaveBranch.Font = new System.Drawing.Font("عصري عادي", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveBranch.Location = new System.Drawing.Point(73, 176);
            this.btnSaveBranch.Name = "btnSaveBranch";
            this.btnSaveBranch.Size = new System.Drawing.Size(75, 23);
            this.btnSaveBranch.TabIndex = 0;
            this.btnSaveBranch.Text = "اضافة";
            this.btnSaveBranch.UseVisualStyleBackColor = true;
            this.btnSaveBranch.Click += new System.EventHandler(this.btnSaveBranch_Click);
            // 
            // textBoxBranch
            // 
            this.textBoxBranch.Location = new System.Drawing.Point(42, 98);
            this.textBoxBranch.Name = "textBoxBranch";
            this.textBoxBranch.Size = new System.Drawing.Size(129, 20);
            this.textBoxBranch.TabIndex = 1;
            this.textBoxBranch.TextChanged += new System.EventHandler(this.textBoxBranch_TextChanged);
            // 
            // frmBranchAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBranchAdd";
            this.Text = "frmBranchAdd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBranch;
        private System.Windows.Forms.Button btnSaveBranch;
    }
}