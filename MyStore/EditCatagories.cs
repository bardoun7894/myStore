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
    public partial class EditCatagories : Form
    {
        DB db = new DB();
        string id_cate="";
        string categoryName = "";
        public EditCatagories(string cate_id,string catagoryName)
        {
            InitializeComponent();
            id_cate = cate_id;
            categoryName = catagoryName;
        }

        private void EditCatagories_Load(object sender, EventArgs e)
        {
            lblidC.Text = id_cate;
            categorytext.Text = categoryName;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

 

        }

        private void bfbEditBranches_Click(object sender, EventArgs e)
        {
           
            string sql = @"UPDATE [dbo].[Products_category] SET [cate_name] = N'{0}'   WHERE cate_id =N'{1}'";
            db.excuteSql(string.Format(sql, categorytext.Text, lblidC.Text));
            MessageBox.Show("تم التعديل بنجاح");
            this.Hide();
        }

        private void btnSaveBranchStore_Click(object sender, EventArgs e)
        {

            string sql = @"INSERT INTO[dbo].[Products_category]   ([cate_name])   VALUES(N'{0}') ";
            if (categorytext.Text != "")
            {
                db.excuteSql(string.Format(sql, categorytext.Text));
 
            }
            else
            {
                MessageBox.Show("Please fill the field");
            }

        }
    }
}
