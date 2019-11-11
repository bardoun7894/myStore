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
    public partial class FrmUnits : Form
    {
        DB db = new DB();

        public FrmUnits()
        {
            InitializeComponent();
        }

        private void textBoxBranch_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //اختيار اسم الفرع من جدول الفروع واصافته في تكست بوكس
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int rowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[rowindex];
                string unit_id = row.Cells["unit_id"].Value.ToString();
                lblId.Text =unit_id;
                string s = "ss";
                if (int.Parse(lblId.Text) > 0 && s == "ss")
                {
                    bfbDeleteBranches.Enabled = true;
                    bfbEditBranches.Enabled = true;
                }
                string sql = @"select unit_name from Units where unit_id= '{0}'";
                //استعمال  excuteSql
                string unit_name = db.excuteSql(string.Format(sql, unit_id));

                MessageBox.Show(unit_name);
            }
        }

        private void bfbEditBranches_Click(object sender, EventArgs e)
        {


            string sql = "update Units set unit_name = N'{0}' where unit_id='{1}'";

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

        private void bfbDeleteBranches_Click(object sender, EventArgs e)
        {


            string sql = "delete from Units where unit_id = '{0}' ";

            DialogResult dialogResult = MessageBox.Show("هل تريد حذف  الوحدة  ", "حذف الوحدة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void FrmUnits_Load(object sender, EventArgs e)
        {

            bfbEditBranches.Enabled = false;
            bfbDeleteBranches.Enabled = false;
            show();



        }
        void show()
        {

            String sql = @" SELECT [unit_id] ,[unit_name]  FROM [dbo].[Units]";

            DataTable dt = db.excuteDataTable(String.Format(sql));
            bunifuCustomDataGrid1.DataSource = dt;
            bunifuCustomDataGrid1.Columns[0].HeaderText = "الرقم";
            bunifuCustomDataGrid1.Columns[1].HeaderText = "نوع الوحدة";

            bunifuCustomDataGrid1.Refresh();


        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveBranchStore_Click(object sender, EventArgs e)
        {

            //تم حل مشكل داتابايز

            String sql = @"INSERT INTO  Units (unit_name) VALUES (N'{0}')";


            db.excuteSql(string.Format(sql,textBoxBranch.Text));

            MessageBox.Show("تم الحفظ");
            show();
        }
    }
}
