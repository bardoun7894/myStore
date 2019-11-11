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
    public partial class FrmVendorsAdd : Form
    {
        //اضافة المورد
        String user_kind_id = "";
        DB db = new DB();

        public FrmVendorsAdd(string kind_user)
        {
            InitializeComponent();
            user_kind_id = kind_user;
        }

        private void FrmVendorsAdd_Load(object sender, EventArgs e)
        {

            Random rm = new Random();
            int x=rm.Next(10000,50000);
            textBoxcode.Text = x.ToString();


        }
        //insert into database venders information
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [dbo].[Users]   ([user_code]  ,[user_fullname]  ,[user_adress] ,
                          [user_phone] ,[user_date]  ) 
                          VALUES   (N'{0}',N'{1}',N'{2}',N'{3}', {4},N'{5}' ) ";
            string date = "CAST(CONVERT(varchar, GETDATE(),101) AS DATETIME)";
            db.excuteSql(string.Format(sql,textBoxcode.Text,textBoxName.Text,textBoxAdresse.Text,textBoxPhone,date));
           


        }
    }
}
