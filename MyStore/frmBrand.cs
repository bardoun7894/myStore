using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class frmBrand : Form
    {
        SqlConnection cn;
        SqlCommand cm  ;
        DBConnection dbCon = new DBConnection();
        frmBrandList frmlist;
        public frmBrand(frmBrandList flist)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
            
            frmlist = flist;
        }
        private void clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBrand.Clear();
            txtBrand.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text=="")
            {
                MessageBox.Show("please fill the field.");
            }
            else {
                try
                {
                    if (MessageBox.Show("Are you sure you want to save this brand ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cn.Open();
                        cm = new SqlCommand("INSERT INTO tblBrand(brand)values(@brand) ", cn);
                        cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Records has succesfully saved .");
                        clear();
                        frmlist.loadRecords();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          

            try
            {
                if (MessageBox.Show("Are you sure you want to update this brand ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("update tblBrand  set brand = (@brand) where id like  '"+labelId.Text+"'", cn);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records has succesfully Update .");
                    clear();
                    frmlist.loadRecords();
                    this.Dispose();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {

        }
    }
}
