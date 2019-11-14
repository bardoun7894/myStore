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
    public partial class FrmUsers : Form
    {
        //اضافة المورد
        String user_kind_id = "";

        // انشاء فرع واحد و مخزن واحد
        String store_id = "1";
        String branch_id = "1";
        DB db = new DB();

        public FrmUsers(string kind_user)
        {
            InitializeComponent();
            user_kind_id = kind_user;
        }

        private void FrmVendorsAdd_Load(object sender, EventArgs e)
        {
            //اضافة مستخدمين و موضفين و موردين في شاشة وحدة

            Random rm = new Random();
            int x=rm.Next(10000,50000);
            lblstore.Text = store_id;
            lblbranch.Text = branch_id;
            textBoxcode.Text = x.ToString();
            if (user_kind_id == "1")
            {
                lblKind.Text = "العملاء";
                textboxUser.Text = "";
                textBoxPass.Text = "";
                groupLogin.Visible = false;
            }
            if (user_kind_id == "2")
            {
                lblKind.Text = "الموظفين";
                textboxUser.Text = "";
                textBoxPass.Text = "";
                groupLogin.Visible = false;

            }
            if (user_kind_id == "3")
            {
                lblKind.Text = "الموردين";
                groupLogin.Visible = true;
            }
            this.Text = lblKind.Text;

        }
        //insert into database venders information
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = @" INSERT INTO [dbo].[Users]
           ([user_code]
           ,[user_fullname]
           ,[user_adress]
           ,[user_phone]
           ,[user_date]
           ,[user_kind_id],user_name,user_password,branch_id,store_id)
     VALUES (N'{0}',N'{1}',N'{2}',N'{3}',{4},N'{5}',N'{6}',N'{7}',N'{8}',N'{9}')
 "; 
            string date = "CAST(CONVERT(varchar(50),getdate(),121) AS DATETIME)";
            db.excuteSql(string.Format(sql, 
                textBoxcode.Text,textBoxName.Text,
                textBoxAdresse.Text,textBoxPhone.Text,date,user_kind_id,textboxUser.Text,textBoxPass.Text, lblbranch.Text, lblstore.Text));
            MessageBox.Show("تمت الاضافة بنجاح");


        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
