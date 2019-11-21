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
   
    public partial class frmCategory : Form
    {
        SqlConnection cn  ;
        SqlCommand cm = new SqlCommand();
        
        DBConnection dbCon = new DBConnection();
        frmCategoryList frmList;
        public frmCategory(frmCategoryList flist)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
          
            frmList = flist;
        }
        private void clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtCategory.Clear();
            txtCategory.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                MessageBox.Show("please fill the field.");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to update this category ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("update tblCategory  set cate_name = (@category) where cate_id like  '" + labelId.Text + "'", cn);
                        cm.Parameters.AddWithValue("@category", txtCategory.Text);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Records has succesfully Update .");
                        clear();
                        frmList.loadRecords();
                        this.Dispose();
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Are you sure you want to save this Category ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblCategory(cate_name)values(@category) ", cn);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records has succesfully saved .");
                    clear();
                    frmList.loadRecords();
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

        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
