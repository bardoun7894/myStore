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
    public partial class frmBranches_store : Form
    {

        DB db = new DB();
        public frmBranches_store()
        {
            InitializeComponent();

        }

        private void frmBranches_store_Load(object sender, EventArgs e)
        {
            //عمل كومبوبوكس لاظهار الفروع

            String sql = @" SELECT [branch_id] ,[branch_name]  FROM [dbo].[Branches]";
            DataTable dt = db.excuteDataTable(String.Format(sql));
            comboBranch.DataSource = dt;
            comboBranch.DisplayMember = "branch_name";
            comboBranch.ValueMember = "branch_id";
            // show data

            showData();


        }
        public void showData()
        {
            string sql = @"SELECT dbo.Branches.branch_name, dbo.Branches_store.store_id, dbo.Branches_store.store_name, dbo.Branches_store.branch_id
FROM   dbo.Branches INNER JOIN  dbo.Branches_store ON dbo.Branches.branch_id = dbo.Branches_store.branch_id";
            DataTable dt = db.excuteDataTable(string.Format(sql));

            bunifuCustomDataGrid1.DataSource = dt;
            bunifuCustomDataGrid1.Columns[0].HeaderText = "اسم الفرع";
            bunifuCustomDataGrid1.Columns[1].HeaderText = "رقم المخزن";
            bunifuCustomDataGrid1.Columns[2].HeaderText = "اسم المخزن";
            bunifuCustomDataGrid1.Columns[3].HeaderText = "رقم الفرع";
            bunifuCustomDataGrid1.Refresh();
        }

         
         

        private void btnSaveBranchStore_Click_1(object sender, EventArgs e)
        {
            //اضافة الفروع  للمخن عبر combobox 

            String sql = @"INSERT INTO [dbo].[Branches_store]   ([store_name] ,[branch_id] ) VALUES (N'{0}',N'{1}')";
            db.excuteSql(string.Format(sql, txtStore.Text, comboBranch.SelectedValue));
            MessageBox.Show("تمت الاضافة");
            showData();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.bunifuCustomDataGrid1.ScrollBars = ScrollBars.Both;
            //اختيار اسم الفرع من جدول الفروع واصافته في تكست بوكس
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {

                int rowindex = bunifuCustomDataGrid1.SelectedCells[1].RowIndex;
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[rowindex];
                string store_id = row.Cells["store_id"].Value.ToString();

                lblId1.Text = store_id;
                string s = "ss";

                if (int.Parse(lblId1.Text) > 0 && s == "ss")
                {
                    bfbDeleteS.Enabled = true;
                    bfbEditStore.Enabled = true;
                }

                string sql = @"select store_name from [Branches_store] where store_id = '{0}'";
                //استعمال  excuteSql
                string store_name = db.excuteSql(string.Format(sql, store_id));

                string sqlBranch = @"select branch_id from [Branches_store] where store_id = '{0}'";

                string branch_id = db.excuteSql(string.Format(sqlBranch, store_id));
                comboBranch.SelectedValue = branch_id;
                txtStore.Text = store_name;




            }
        }

        private void bfbEditStore_Click(object sender, EventArgs e)
        {



            //استعمال  excuteSql
            if (comboBranch.SelectedIndex == 0 && txtStore.Text == "")
            {
                MessageBox.Show("المرجو ملأ البيانات");

            }
            else
            {
                string sql = "update Branches_store set store_name = N'{0}' where store_id='{1}'";
                db.excuteSql(string.Format(sql, txtStore.Text, lblId1.Text));
                showData();
            }

        }

        private void bfbDeleteS_Click(object sender, EventArgs e)
        {

            String sql = @" delete from Branches_store  where store_id = '{0}'";


            DialogResult dialogResult = MessageBox.Show("هل تريد حذف المخزن", "حذف المخزن", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                db.excuteSql(string.Format(sql, lblId1.Text));
            }
            else if (dialogResult == DialogResult.No)
            {
                showData();
            }
            showData();
        }
    }
}