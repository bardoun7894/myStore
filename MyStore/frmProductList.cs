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
    public partial class frmProductList : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        public frmProductList()
        {
            InitializeComponent();
            cn = new SqlConnection(dbCon.MyConnection());
            loadRecords();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct(this);
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;

            frm.loadBrand();
            frm.loadCategory();
            frm.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                frmProduct frm = new frmProduct(this);
                frm.btnSave.Enabled = false;

                frm.txtPcode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.textBarcode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtdesc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.comboBrand.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.comboCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.txtprice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                frm.ShowDialog();
            }
            if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this brand ?", "Delete this Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmProduct frm = new frmProduct(this);
                    frm.btnSave.Enabled = false;
                    frm.labelId.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                    cn.Open();
                    cm = new SqlCommand("delete from tblProduct where pcode like  '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Records has succesfully Deleted .", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    loadRecords();
                }
            }
        }

        public void loadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("Select p.pcode,p.pbarcode,p.pdesc ,b.brand,c.category,p.price from tblProduct as p inner join tblBrand as b on b.id =  p.bid inner join tblCategory as c on c.id =p.cid where p.pdesc like '" + txtSearch.Text + "%'", cn);
                //  dr = cm.ExecuteReader();
                using (dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
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


        private void txtSearch_Click(object sender, EventArgs e)
        {
            loadRecords();
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadRecords();
                // Enter key pressed
            }
        }


    }
}
