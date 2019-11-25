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
    public partial class frmLookUp : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        frmTransaction f = new frmTransaction();
        public frmLookUp(frmTransaction frm)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
            loadRecords();
            f = frm;
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
                      dataGridView1.Rows.Add(i, dr[0].ToString(), 
                      dr[1].ToString(),dr[2].ToString(),dr[3].ToString(),
                          dr[4].ToString(), dr[5].ToString());
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            try
            {
                if (colName == "select")
                {

 
                        if (MessageBox.Show("Add this Item ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                        frmQty fr = new frmQty(f);
                        fr.productDetails(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                         double.Parse(   dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()),
                            f.lblTransno.Text );
                        fr.ShowDialog();

                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadRecords();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
 
    }
}
