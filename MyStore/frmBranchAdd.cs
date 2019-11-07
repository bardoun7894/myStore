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

        }
    }
}
