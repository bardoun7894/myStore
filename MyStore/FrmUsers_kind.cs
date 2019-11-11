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
    public partial class FrmUsers_kind : Form
    {
        DB db = new DB();
        public FrmUsers_kind()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserKind_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT [user_kind_id]
      ,[user_kind]
  FROM [dbo].[Users_kind]";

            DataTable dt = db.excuteDataTable(String.Format(sql));
            bunifuCustomDataGrid1.DataSource = dt;
         
          bunifuCustomDataGrid1.Columns[0].HeaderText = "الرقم ";
        bunifuCustomDataGrid1.Columns[1].HeaderText = "نوع المستخدم";
            bunifuCustomDataGrid1.Refresh();
        }
    }
}
