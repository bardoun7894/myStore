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
    public partial class FrmUsersShow : Form
    {

        string kind_user_id = "";
        DB db = new DB();

        public FrmUsersShow(string user_kind_id)
        {
            InitializeComponent();
            kind_user_id = user_kind_id;
        }
         
        private void FrmUsersShow_Load(object sender, EventArgs e)
        { 

            if (kind_user_id == "1")
            {
                lbluser.Text = "العملاء";


            }
            if (kind_user_id == "2")
            {
                lbluser.Text = "الموظفين";

            }
            if (kind_user_id == "3")
            {
                lbluser.Text = "الموردين";

            }
            this.Text = lbluser.Text;




            String sql = @" SELECT [branch_id] ,[branch_name]  FROM [dbo].[Branches]";
            DataTable dt = db.excuteDataTable(String.Format(sql));
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "branch_name";
            comboBox1.ValueMember = "branch_id";


        }
        

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void bfbEditBranches_Click(object sender, EventArgs e)
        {
            FrmEditUser fm = new FrmEditUser(lblid.Text,kind_user_id);
            fm.MdiParent = frmMain.ActiveForm;
            fm.Show();


        }
 

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            //اختيار اسم الفرع من جدول الفروع واصافته في تكست بوكس
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                bfbEditUser.Visible = true;
                int rowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[rowindex];
                string user_id = row.Cells["user_id"].Value.ToString();
                lblid.Text = user_id;


                string sql = @"select user_name from Users where user_id= '{0}'";


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string sql = @"SELECT        
                  dbo.Users.user_code AS UserCode,
                  dbo.Users.user_fullname AS Name,
                  dbo.Users.user_adress,
                  dbo.Users.user_phone,
                  dbo.Users.user_date,
                  dbo.Users.user_name, 
                  dbo.Users.user_password,
                  dbo.Users.user_id
                 FROM   
                  dbo.Users INNER JOIN
                  dbo.Branches ON dbo.Users.branch_id = dbo.Branches.branch_id LEFT OUTER JOIN
                  dbo.Users_kind ON dbo.Users.user_kind_id = dbo.Users_kind.user_kind_id where 1=1";
            string condition = "";
            if (textBoxcode.Text != "")
            {
                condition += " and Users.user_code = '" + textBoxcode.Text + " '";
            }
            if (textBoxName.Text != "")
            { 
                condition += " and Users.user_fullname = N'" + textBoxName.Text + " '";
            }
            if (textBoxPhone.Text != "")
            {
                condition += " and Users.user_phone = '" + textBoxPhone.Text + " '";
            }
          
            
            if (kind_user_id != "")
            {
           condition += " and dbo.Users_kind.user_kind_id = '" + kind_user_id + " '";
            }
            

            DataTable dt = db.excuteDataTable(sql + condition);
            bunifuCustomDataGrid1.DataSource = dt;
            bunifuCustomDataGrid1.Refresh();


        }
    }
}
