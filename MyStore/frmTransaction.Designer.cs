namespace MyStore
{
    partial class frmTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.panel10 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTransno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTAmount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDisount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn1N = new System.Windows.Forms.Button();
            this.btn2N = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btn4N = new System.Windows.Forms.Button();
            this.btn6N = new System.Windows.Forms.Button();
            this.btn5N = new System.Windows.Forms.Button();
            this.btn0N = new System.Windows.Forms.Button();
            this.btn7N = new System.Windows.Forms.Button();
            this.btn9N = new System.Windows.Forms.Button();
            this.btn8N = new System.Windows.Forms.Button();
            this.btn00N = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnEnterN = new System.Windows.Forms.Button();
            this.btn3N = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.barcodeSearch = new MetroFramework.Controls.MetroTextBox();
            this.panel10.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.lblDate);
            this.panel10.Controls.Add(this.lblTransno);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.barcodeSearch);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(753, 100);
            this.panel10.TabIndex = 39;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Barcode";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(101, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(78, 17);
            this.lblDate.TabIndex = 42;
            this.lblDate.Text = "0000000000";
            // 
            // lblTransno
            // 
            this.lblTransno.AutoSize = true;
            this.lblTransno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransno.ForeColor = System.Drawing.Color.Red;
            this.lblTransno.Location = new System.Drawing.Point(101, 10);
            this.lblTransno.Name = "lblTransno";
            this.lblTransno.Size = new System.Drawing.Size(78, 17);
            this.lblTransno.TabIndex = 41;
            this.lblTransno.Text = "0000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Transaction";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dataGridView1);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 100);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(753, 426);
            this.panel15.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(252)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.edit,
            this.delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 408);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 39;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 59;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.Width = 51;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            this.Column6.Width = 59;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(88)))));
            this.panel13.Controls.Add(this.label1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(309, 100);
            this.panel13.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 43);
            this.label1.TabIndex = 43;
            this.label1.Text = "0.00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblTAmount);
            this.panel1.Controls.Add(this.lblTax);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblDisount);
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(1, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 191);
            this.panel1.TabIndex = 38;
            // 
            // lblTAmount
            // 
            this.lblTAmount.AutoSize = true;
            this.lblTAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAmount.Location = new System.Drawing.Point(255, 122);
            this.lblTAmount.Name = "lblTAmount";
            this.lblTAmount.Size = new System.Drawing.Size(40, 21);
            this.lblTAmount.TabIndex = 50;
            this.lblTAmount.Text = "0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(255, 95);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(40, 21);
            this.lblTax.TabIndex = 49;
            this.lblTax.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 21);
            this.label13.TabIndex = 48;
            this.label13.Text = "Total Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 21);
            this.label14.TabIndex = 47;
            this.label14.Text = "Taxable";
            // 
            // lblDisount
            // 
            this.lblDisount.AutoSize = true;
            this.lblDisount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisount.Location = new System.Drawing.Point(255, 64);
            this.lblDisount.Name = "lblDisount";
            this.lblDisount.Size = new System.Drawing.Size(40, 21);
            this.lblDisount.TabIndex = 46;
            this.lblDisount.Text = "0.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(255, 37);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(40, 21);
            this.lblSubtotal.TabIndex = 45;
            this.lblSubtotal.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "Discount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 43;
            this.label11.Text = "Sub-Total";
            // 
            // btn1N
            // 
            this.btn1N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn1N.FlatAppearance.BorderSize = 0;
            this.btn1N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1N.ForeColor = System.Drawing.Color.White;
            this.btn1N.Location = new System.Drawing.Point(57, 414);
            this.btn1N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1N.Name = "btn1N";
            this.btn1N.Size = new System.Drawing.Size(50, 50);
            this.btn1N.TabIndex = 39;
            this.btn1N.Text = "1";
            this.btn1N.UseVisualStyleBackColor = false;
            // 
            // btn2N
            // 
            this.btn2N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn2N.FlatAppearance.BorderSize = 0;
            this.btn2N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2N.ForeColor = System.Drawing.Color.White;
            this.btn2N.Location = new System.Drawing.Point(111, 414);
            this.btn2N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn2N.Name = "btn2N";
            this.btn2N.Size = new System.Drawing.Size(50, 50);
            this.btn2N.TabIndex = 41;
            this.btn2N.Text = "2";
            this.btn2N.UseVisualStyleBackColor = false;
            // 
            // btnCN
            // 
            this.btnCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btnCN.FlatAppearance.BorderSize = 0;
            this.btnCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCN.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.ForeColor = System.Drawing.Color.White;
            this.btnCN.Location = new System.Drawing.Point(220, 298);
            this.btnCN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(50, 50);
            this.btnCN.TabIndex = 42;
            this.btnCN.Text = "C";
            this.btnCN.UseVisualStyleBackColor = false;
            // 
            // btn4N
            // 
            this.btn4N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn4N.FlatAppearance.BorderSize = 0;
            this.btn4N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4N.ForeColor = System.Drawing.Color.White;
            this.btn4N.Location = new System.Drawing.Point(57, 356);
            this.btn4N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn4N.Name = "btn4N";
            this.btn4N.Size = new System.Drawing.Size(50, 50);
            this.btn4N.TabIndex = 43;
            this.btn4N.Text = "4";
            this.btn4N.UseVisualStyleBackColor = false;
            // 
            // btn6N
            // 
            this.btn6N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn6N.FlatAppearance.BorderSize = 0;
            this.btn6N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6N.ForeColor = System.Drawing.Color.White;
            this.btn6N.Location = new System.Drawing.Point(165, 356);
            this.btn6N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn6N.Name = "btn6N";
            this.btn6N.Size = new System.Drawing.Size(50, 50);
            this.btn6N.TabIndex = 44;
            this.btn6N.Text = "6";
            this.btn6N.UseVisualStyleBackColor = false;
            // 
            // btn5N
            // 
            this.btn5N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn5N.FlatAppearance.BorderSize = 0;
            this.btn5N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5N.ForeColor = System.Drawing.Color.White;
            this.btn5N.Location = new System.Drawing.Point(111, 356);
            this.btn5N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn5N.Name = "btn5N";
            this.btn5N.Size = new System.Drawing.Size(50, 50);
            this.btn5N.TabIndex = 45;
            this.btn5N.Text = "5";
            this.btn5N.UseVisualStyleBackColor = false;
            // 
            // btn0N
            // 
            this.btn0N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn0N.FlatAppearance.BorderSize = 0;
            this.btn0N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0N.ForeColor = System.Drawing.Color.White;
            this.btn0N.Location = new System.Drawing.Point(220, 356);
            this.btn0N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn0N.Name = "btn0N";
            this.btn0N.Size = new System.Drawing.Size(50, 50);
            this.btn0N.TabIndex = 46;
            this.btn0N.Text = "0";
            this.btn0N.UseVisualStyleBackColor = false;
            // 
            // btn7N
            // 
            this.btn7N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn7N.FlatAppearance.BorderSize = 0;
            this.btn7N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7N.ForeColor = System.Drawing.Color.White;
            this.btn7N.Location = new System.Drawing.Point(57, 298);
            this.btn7N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn7N.Name = "btn7N";
            this.btn7N.Size = new System.Drawing.Size(50, 50);
            this.btn7N.TabIndex = 47;
            this.btn7N.Text = "7";
            this.btn7N.UseVisualStyleBackColor = false;
            // 
            // btn9N
            // 
            this.btn9N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn9N.FlatAppearance.BorderSize = 0;
            this.btn9N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9N.ForeColor = System.Drawing.Color.White;
            this.btn9N.Location = new System.Drawing.Point(165, 298);
            this.btn9N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn9N.Name = "btn9N";
            this.btn9N.Size = new System.Drawing.Size(50, 50);
            this.btn9N.TabIndex = 48;
            this.btn9N.Text = "9";
            this.btn9N.UseVisualStyleBackColor = false;
            // 
            // btn8N
            // 
            this.btn8N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn8N.FlatAppearance.BorderSize = 0;
            this.btn8N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8N.ForeColor = System.Drawing.Color.White;
            this.btn8N.Location = new System.Drawing.Point(111, 298);
            this.btn8N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn8N.Name = "btn8N";
            this.btn8N.Size = new System.Drawing.Size(50, 50);
            this.btn8N.TabIndex = 49;
            this.btn8N.Text = "8";
            this.btn8N.UseVisualStyleBackColor = false;
            // 
            // btn00N
            // 
            this.btn00N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn00N.FlatAppearance.BorderSize = 0;
            this.btn00N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00N.ForeColor = System.Drawing.Color.White;
            this.btn00N.Location = new System.Drawing.Point(220, 414);
            this.btn00N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn00N.Name = "btn00N";
            this.btn00N.Size = new System.Drawing.Size(50, 50);
            this.btn00N.TabIndex = 50;
            this.btn00N.Text = "00";
            this.btn00N.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Silver;
            this.panel14.Controls.Add(this.btnEnterN);
            this.panel14.Controls.Add(this.panel1);
            this.panel14.Controls.Add(this.panel13);
            this.panel14.Controls.Add(this.btn3N);
            this.panel14.Controls.Add(this.btn7N);
            this.panel14.Controls.Add(this.btn5N);
            this.panel14.Controls.Add(this.btn00N);
            this.panel14.Controls.Add(this.btn6N);
            this.panel14.Controls.Add(this.btn1N);
            this.panel14.Controls.Add(this.btn0N);
            this.panel14.Controls.Add(this.btn8N);
            this.panel14.Controls.Add(this.btn4N);
            this.panel14.Controls.Add(this.btn2N);
            this.panel14.Controls.Add(this.btnCN);
            this.panel14.Controls.Add(this.btn9N);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(753, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(309, 526);
            this.panel14.TabIndex = 38;
            // 
            // btnEnterN
            // 
            this.btnEnterN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btnEnterN.FlatAppearance.BorderSize = 0;
            this.btnEnterN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterN.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterN.ForeColor = System.Drawing.Color.White;
            this.btnEnterN.Location = new System.Drawing.Point(57, 472);
            this.btnEnterN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnterN.Name = "btnEnterN";
            this.btnEnterN.Size = new System.Drawing.Size(213, 50);
            this.btnEnterN.TabIndex = 52;
            this.btnEnterN.Text = "ENTER";
            this.btnEnterN.UseVisualStyleBackColor = false;
            // 
            // btn3N
            // 
            this.btn3N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(144)))), ((int)(((byte)(131)))));
            this.btn3N.FlatAppearance.BorderSize = 0;
            this.btn3N.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3N.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3N.ForeColor = System.Drawing.Color.White;
            this.btn3N.Location = new System.Drawing.Point(165, 414);
            this.btn3N.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn3N.Name = "btn3N";
            this.btn3N.Size = new System.Drawing.Size(50, 50);
            this.btn3N.TabIndex = 51;
            this.btn3N.Text = "3";
            this.btn3N.UseVisualStyleBackColor = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = " ";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 16;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = " ";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.Width = 16;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.Width = 5;
            // 
            // barcodeSearch
            // 
            // 
            // 
            // 
            this.barcodeSearch.CustomButton.Image = null;
            this.barcodeSearch.CustomButton.Location = new System.Drawing.Point(498, 1);
            this.barcodeSearch.CustomButton.Name = "";
            this.barcodeSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.barcodeSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.barcodeSearch.CustomButton.TabIndex = 1;
            this.barcodeSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.barcodeSearch.CustomButton.UseSelectable = true;
            this.barcodeSearch.CustomButton.Visible = false;
            this.barcodeSearch.DisplayIcon = true;
            this.barcodeSearch.Icon = ((System.Drawing.Image)(resources.GetObject("barcodeSearch.Icon")));
            this.barcodeSearch.Lines = new string[0];
            this.barcodeSearch.Location = new System.Drawing.Point(104, 62);
            this.barcodeSearch.MaxLength = 32767;
            this.barcodeSearch.Name = "barcodeSearch";
            this.barcodeSearch.PasswordChar = '\0';
            this.barcodeSearch.PromptText = "Search Barcode Here.";
            this.barcodeSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.barcodeSearch.SelectedText = "";
            this.barcodeSearch.SelectionLength = 0;
            this.barcodeSearch.SelectionStart = 0;
            this.barcodeSearch.ShortcutsEnabled = true;
            this.barcodeSearch.Size = new System.Drawing.Size(524, 27);
            this.barcodeSearch.TabIndex = 38;
            this.barcodeSearch.UseSelectable = true;
            this.barcodeSearch.WaterMark = "Search Barcode Here.";
            this.barcodeSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.barcodeSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeSearch.TextChanged += new System.EventHandler(this.barcodeSearch_TextChanged);
            this.barcodeSearch.Click += new System.EventHandler(this.barcodeSearch_Click);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 526);
            this.ControlBox = false;
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransaction";
            this.Text = "frmTransaction";
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btn1N;
        public System.Windows.Forms.Button btn2N;
        public System.Windows.Forms.Button btnCN;
        public System.Windows.Forms.Button btn4N;
        public System.Windows.Forms.Button btn6N;
        public System.Windows.Forms.Button btn5N;
        public System.Windows.Forms.Button btn0N;
        public System.Windows.Forms.Button btn7N;
        public System.Windows.Forms.Button btn9N;
        public System.Windows.Forms.Button btn8N;
        public System.Windows.Forms.Button btn00N;
        public System.Windows.Forms.Button btn3N;
        public System.Windows.Forms.Button btnEnterN;
        public System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public System.Windows.Forms.Panel panel10;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblTransno;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public MetroFramework.Controls.MetroTextBox barcodeSearch;
        public System.Windows.Forms.Panel panel15;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.DataGridViewImageColumn edit;
        public System.Windows.Forms.DataGridViewImageColumn delete;
        public System.Windows.Forms.Panel panel13;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel14;
        public System.Windows.Forms.Label lblTAmount;
        public System.Windows.Forms.Label lblTax;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblDisount;
        public System.Windows.Forms.Label lblSubtotal;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
    }
}