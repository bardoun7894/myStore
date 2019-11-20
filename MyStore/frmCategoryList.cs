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
    public partial class frmCategoryList : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        public frmCategoryList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.MyConnection());
            loadRecords();

        }
        public void loadRecords()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("Select * from tblCategory order by category ", cn);
                //  dr = cm.ExecuteReader();
                using (dr = cm.ExecuteReader())

                {
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridView2.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString());
                    }
                }
                cm.ExecuteNonQuery();
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                frmCategory frm = new frmCategory(this);
                frm.btnSave.Enabled = false;
                frm.labelId.Text = dataGridView2[1, e.RowIndex].Value.ToString();
                frm.txtCategory.Text = dataGridView2[2, e.RowIndex].Value.ToString();
                frm.ShowDialog();

            }
            if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Category ?", "Delete this Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmCategory frm = new frmCategory(this);
                    frm.btnSave.Enabled = false;
                    frm.labelId.Text = dataGridView2[1, e.RowIndex].Value.ToString();
                    cn.Open();
                    cm = new SqlCommand("delete from tblCategory where  id like  '" + dataGridView2[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records has succesfully Deleted .", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadRecords();
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory(this);
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
      
            frm.ShowDialog();
        }
    }
}
