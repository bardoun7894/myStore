using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class frmSecurity : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        public frmSecurity()
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();

            
        }
  
 

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool found = false;
            string _username = "";
            string _role = "";
            string _name = "";
            try
            {
                if (txtUser.Text != string.Empty && txtPass.Text != string.Empty)
                {
                    cn.Open();
                    cm = new SqlCommand("select * from tblUserAccount  where username = @username and password = @password ", cn);
                    cm.Parameters.AddWithValue("@username", txtUser.Text);
                    cm.Parameters.AddWithValue("@password", txtPass.Text);
                    cm.ExecuteNonQuery();
                    using (dr=cm.ExecuteReader())
                    {
                        dr.Read();
                        if (dr.HasRows)
                        { 
                            found = true;
                            _username = dr["username"].ToString();
                            _role = dr["role"].ToString();
                            _name = dr["name"].ToString();
                        }
                        else
                        {
                            found = false;

                        }
                        
                    }

                    dr.Close();
                    cn.Close();
                    if (found == true)
                    {
                        if (_role == "cashier")
                        { 
                            MessageBox.Show("Welcome" + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUser.Clear();
                            txtPass.Clear();
                            this.Hide();
                            frmPOS fp = new frmPOS();
                            fp.ShowDialog();
                        }
                        if (_role == "admin")
                        {
                            MessageBox.Show("Welcome" + _name + "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUser.Clear();
                            txtPass.Clear();
                            this.Hide();
                            ori2 fp = new ori2();
                            fp.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("invalid username or password", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       }
                }
               
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
