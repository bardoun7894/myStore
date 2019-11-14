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
            bfbEditBranches.Enabled = false;
           bfbDeleteBranches.Enabled = false;
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

      

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            //تم حل مشكل داتابايز

            String sql = @"INSERT INTO  Branches  (branch_name) VALUES (N'{0}')";


            db.excuteSql(string.Format(sql, textBoxBranch.Text));

            MessageBox.Show("تم الحفظ");
            show();
        }
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            string sql = "delete from Branches where branch_id = '{0}' "  ;
            db.excuteSql(string.Format(sql,lblId.Text));
            MessageBox.Show("تم الحدف بنجاح");
            show();

        }
       
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string sql = "update Branches set branch_name = N'{0}' where branch_id='{1}'";
            db.excuteSql(string.Format(sql,textBoxBranch.Text,lblId.Text)) ;
          
            show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 
        private void btnSaveBranchStore_Click(object sender, EventArgs e)
        {

            //تم حل مشكل داتابايز

            
        }

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            //اختيار اسم الفرع من جدول الفروع واصافته في تكست بوكس
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int rowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[rowindex];
                string branch_id = row.Cells["branch_id"].Value.ToString();
                lblId.Text = branch_id;
                string s = "ss";
                if (int.Parse(lblId.Text) > 0 && s == "ss")
                {
                    bfbDeleteBranches.Enabled = true;
                    bfbEditBranches.Enabled = true;
                }
                string sql = @"select branch_name from branches where branch_id= '{0}'";
                //استعمال  excuteSql
                string branch_name = db.excuteSql(string.Format(sql, branch_id));

                MessageBox.Show(branch_name);
            }

        }

        //حدف  delete branches
        



        //edit تعديل الفروع
      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void bfbDeleteBranches_Click_1(object sender, EventArgs e)
        {
            string sql = "delete from Branches where branch_id = '{0}' ";

            DialogResult dialogResult = MessageBox.Show("هل تريد حذف  الفرع  ", "حذف الفرع", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                db.excuteSql(string.Format(sql, lblId.Text));
            }
            else if (dialogResult == DialogResult.No)
            {

                show();
            }

            show();
        }

        private void bfbEditBranches_Click_1(object sender, EventArgs e)
        {

            string sql = "update Branches set branch_name = N'{0}' where branch_id='{1}'";

            if (textBoxBranch.Text == "")
            {
                MessageBox.Show("المرجو ملأ البيانات");

            }
            else
            {
                db.excuteSql(string.Format(sql, textBoxBranch.Text, lblId.Text));
            }


            show();
        }

        private void btnSaveBranchStore_Click_1(object sender, EventArgs e)
        {
            String sql = @"INSERT INTO  Branches  (branch_name) VALUES (N'{0}')";


            db.excuteSql(string.Format(sql, textBoxBranch.Text));

            MessageBox.Show("تم الحفظ");
            show();
        }

        private void bunifuCustomDataGrid1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            bunifuCustomDataGrid1.ClearSelection();
            //اختيار اسم الفرع من جدول الفروع واصافته في تكست بوكس
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int rowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[rowindex];
                string branch_id = row.Cells["branch_id"].Value.ToString();
                lblId.Text = branch_id;
                string s = "ss";
                if (int.Parse(lblId.Text) > 0 && s == "ss")
                {
                    bfbDeleteBranches.Enabled = true;
                    bfbEditBranches.Enabled = true;
                }
                string sql = @"select branch_name from branches where branch_id= '{0}'";
                //استعمال  excuteSql
                string branch_name = db.excuteSql(string.Format(sql, branch_id));

                MessageBox.Show(branch_name);
            }

        }
    }
}
