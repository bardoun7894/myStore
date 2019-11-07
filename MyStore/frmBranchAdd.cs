using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class frmBranchAdd : Form
    {
        DB db = new DB();
        public frmBranchAdd()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //insert Branch to sql

        private void textBoxBranch_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnSaveBranch_Click(object sender, EventArgs e)
        {
            //تم حل مشكل داتابايز

            String sql = @"INSERT INTO  Branches  (branch_name) VALUES (N'{0}')";

        
            db.excuteSql(string.Format(sql, textBoxBranch.Text));
 
            MessageBox.Show("تم الحفظ");
            show();

        }

        private void frmBranchAdd_Load(object sender, EventArgs e)
        {
            show();
          
        }
        //  اظهار جدول  فروع الشركات داتابايز مع اضافة الفروع الجديدة
        void show()
        {

            String sql = @" SELECT [branch_id] ,[branch_name]  FROM [dbo].[Branches]";
            DataTable dt = db.excuteDataTable(String.Format(sql));
            bunifuCustomDataGrid1.DataSource = dt;
            bunifuCustomDataGrid1.Columns[0].HeaderText="رقم الفرع";
            bunifuCustomDataGrid1.Columns[1].HeaderText = "اسم الفرع";
            bunifuCustomDataGrid1.Refresh();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

//اختيار اسم الفرع من جدول الفروع واصافته في تكست بوكس
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int rowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[rowindex];
                string branch_id = row.Cells["branch_id"].Value.ToString();
                string sql = @"select branch_name from branches where branch_id= '{0}'";
                string branch_name = db.excuteSql(string.Format(sql, branch_id));

                textBoxBranch.Text=branch_name;




            }

        }
    }
}
