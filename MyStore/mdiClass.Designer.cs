namespace MyStore
{
    partial class MdiClass
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.الاعداداتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الشاشةالرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المخازنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.العملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الفروعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdiFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الاعداداتToolStripMenuItem,
            this.العملاءToolStripMenuItem,
            this.الموردينToolStripMenuItem,
            this.الفروعToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // الاعداداتToolStripMenuItem
            // 
            this.الاعداداتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الشاشةالرئيسيةToolStripMenuItem,
            this.المخازنToolStripMenuItem,
            this.mdiFrm});
            this.الاعداداتToolStripMenuItem.Name = "الاعداداتToolStripMenuItem";
            this.الاعداداتToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.الاعداداتToolStripMenuItem.Text = "الاعدادات";
            // 
            // الشاشةالرئيسيةToolStripMenuItem
            // 
            this.الشاشةالرئيسيةToolStripMenuItem.Name = "الشاشةالرئيسيةToolStripMenuItem";
            this.الشاشةالرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.الشاشةالرئيسيةToolStripMenuItem.Text = "الشاشة الرئيسية";
            this.الشاشةالرئيسيةToolStripMenuItem.Click += new System.EventHandler(this.الشاشةالرئيسيةToolStripMenuItem_Click);
            // 
            // المخازنToolStripMenuItem
            // 
            this.المخازنToolStripMenuItem.Name = "المخازنToolStripMenuItem";
            this.المخازنToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.المخازنToolStripMenuItem.Text = "المخازن";
            this.المخازنToolStripMenuItem.Click += new System.EventHandler(this.المخازنToolStripMenuItem_Click);
            // 
            // العملاءToolStripMenuItem
            // 
            this.العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem";
            this.العملاءToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.العملاءToolStripMenuItem.Text = "العملاء";
            // 
            // الموردينToolStripMenuItem
            // 
            this.الموردينToolStripMenuItem.Name = "الموردينToolStripMenuItem";
            this.الموردينToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.الموردينToolStripMenuItem.Text = "الموردين";
            // 
            // الفروعToolStripMenuItem
            // 
            this.الفروعToolStripMenuItem.Name = "الفروعToolStripMenuItem";
            this.الفروعToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.الفروعToolStripMenuItem.Text = "الفروع";
            // 
            // mdiFrm
            // 
            this.mdiFrm.Name = "mdiFrm";
            this.mdiFrm.Size = new System.Drawing.Size(180, 22);
            this.mdiFrm.Text = "الفروع";
            this.mdiFrm.Click += new System.EventHandler(this.الفروعToolStripMenuItem1_Click);
            // 
            // MdiClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip3);
            this.IsMdiContainer = true;
            this.Name = "MdiClass";
            this.Text = "mdiClass";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem الاعداداتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الشاشةالرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المخازنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem العملاءToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموردينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mdiFrm;
        private System.Windows.Forms.ToolStripMenuItem الفروعToolStripMenuItem;
    }
}