using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MyStore
{
    public partial class frmDiscount : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        frmTransaction fp;


        public frmDiscount(frmTransaction fmp)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
            fp = fmp;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Add discount ?Click yes to confirm.","",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
                    
                {   cn.Open(); 
                    cm = new SqlCommand("update tblCart set disc =@disc where id =@id",cn);
                    cm.Parameters.AddWithValue("@disc",double.Parse(lblAmount.Text));
                    cm.Parameters.AddWithValue("@id", int.Parse(lblId.Text));
                    cm.ExecuteNonQuery();
                    cn.Close();

                    fp.loadCart();
                   this.Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblDiscount_TextChanged(object sender, EventArgs e)
        {
            try {
                double discount = Double.Parse(lblPrice.Text) * Double.Parse(lblDiscount.Text);
                lblAmount.Text = discount.ToString("#,##0.00");
                 
            } 
                 
            catch(Exception ex) {
                lblAmount.Text = "0.00";
            }
        }
    }
}
