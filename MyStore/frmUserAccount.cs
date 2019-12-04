using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStore
{
    public partial class frmUserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        public frmUserAccount()
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
        }
        public void d()
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("select * from tblUserAccount where username ='" + textUser.Text + cn);
                cm.ExecuteNonQuery();
                using (dr = cm.ExecuteReader())
                {  if (dr.HasRows)
                    {
                        MessageBox.Show(dr[0].ToString());
                    }
                    else
                    {
                        MessageBox.Show(".");
                    }
                }
                cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
          
        }
 
        private void btnSave_Click(object sender, EventArgs e)
        {
            string tuser = "";
            try
            {
                if (txtPass.Text == txtrpass.Text )
                {
                    cn.Open();
                    cm = new SqlCommand("insert into tblUserAccount (username,password,role,name)values(@username,@password,@role,@name) ", cn);
                    cm.Parameters.AddWithValue("@username",textUser.Text);
                    cm.Parameters.AddWithValue("@password",txtPass.Text.ToString());
                    cm.Parameters.AddWithValue("@role",comboRole.SelectedItem);
                    cm.Parameters.AddWithValue("@name",txtName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                 }
                else
                {
                    MessageBox.Show("password not match");
                }
                 
            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show(ex.Message);
            }
           
        }

        private void frmUserAccount_Load(object sender, EventArgs e)
        {
            

        }

        private void frmUserAccount_Resize(object sender, EventArgs e)
        {
            metroTabControl1.Left = (this.Width - metroTabControl1.Width) / 2;
            metroTabControl1.Top = (this.Height - metroTabControl1.Height) / 2;
        }
    }
}
