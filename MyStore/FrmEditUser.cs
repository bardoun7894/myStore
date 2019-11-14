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
    public partial class FrmEditUser : Form
    {
        DB db = new DB();
        string kind_user_id = "";
        string id_user="";
        public FrmEditUser(String user_id,String user_kind_id)
        {
            InitializeComponent();
            id_user = user_id;
            kind_user_id = user_kind_id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void show()
        {

            String sql = @" SELECT [user_id]
      ,[user_code]
      ,[user_fullname]
      ,[user_adress]
      ,[user_phone]
      ,[user_date]
      ,[user_name]
      ,[user_password]
      ,[user_kind_id]
      ,[branch_id]
      ,[store_id]
  FROM [dbo].[Users] where user_id = {0}";

            DataTable dt = db.excuteDataTable(string.Format(sql, id_user));


            foreach ( DataRow dr in dt.Rows)
            {
                textBoxcode.Text = dr["user_code"].ToString();
                textBoxName.Text = dr["user_fullname"].ToString();
                textBoxAdresse.Text = dr["user_adress"].ToString();
                textBoxPhone.Text = dr["user_phone"].ToString();
                textBoxDate.Text = dr["user_date"].ToString();
                textboxUser.Text = dr["user_name"].ToString();
                textBoxPass.Text = dr["user_password"].ToString();

            }
          


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmEditUser_Load(object sender, EventArgs e)
        {

            if (kind_user_id == "1")
            {
                lblKind.Text = "العملاء";
                textboxUser.Text = "";
                textBoxPass.Text = "";
                groupLogin.Visible = false;

            }
            if (kind_user_id == "2")
            {
                lblKind.Text = "الموظفين";
                textboxUser.Text = "";
                textBoxPass.Text = "";
                groupLogin.Visible = true;

            }
            if (kind_user_id == "3")
            {
                lblKind.Text = "الموردين";
                textboxUser.Text = "";
                textBoxPass.Text = "";
                groupLogin.Visible = false;
            }
            this.Text = lblKind.Text;

            show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
 
            string sql = @"UPDATE [dbo].[Users]   SET   [user_fullname] = N'{0}'  ,[user_adress] = N'{1}' 
,[user_phone] =N'{2}'     ,[user_name] =N'{3}'  ,[user_password] = N'{4}'  where  user_id ='{5}' " ;
            DialogResult dialogResult = MessageBox.Show("هل تريد تعديل  ", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                db.excuteSql(string.Format(sql, textBoxName.Text, textBoxAdresse.Text, textBoxPhone.Text,
                textboxUser.Text, textBoxPass.Text ,id_user));
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            string sql = @"delete from Users where user_id=N'{0}'";

            DialogResult dialogResult = MessageBox.Show("هل تريد حذف المخزن", "حذف المخزن", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                db.excuteSql(string.Format(sql, id_user));
                bunifuFlatButton1.Visible = false;
                btnSave.Visible = false;
                textBoxcode.Visible = false;
                textBoxDate.Visible = false;
                textBoxName.Text = "";
                textBoxAdresse.Text = "";
                textBoxPhone.Text = "";
                textboxUser.Text = "";
                textBoxPass.Text = "";


            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
