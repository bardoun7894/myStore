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
    public partial class frmSeachProductStockI : Form
    {
        SqlConnection cn  ;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        frmStockIn frm;
        public frmSeachProductStockI(frmStockIn frmlist)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
            frm = frmlist;

            loadProducts();
       


        }
        public void loadProducts()

        {
            int i = 0;
            dataGridView1.Rows.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("Select pcode,pdesc,qty from tblProduct where pdesc like'%" +  txtSearch1.Text + "%' order by pdesc", cn);
                //  dr = cm.ExecuteReader();
                using (dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
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
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            try
            {
                if (colName == "colselect")
                {


                    if (frm.textRefno.Text == string.Empty && frm.textstockin.Text == string.Empty)
                    { MessageBox.Show("please fill the Fields"); 
                    }
                    else
                    {
                        if (MessageBox.Show("Add this Item ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            cn.Open();
                            cm = new SqlCommand("insert into tblStockIn (refno,pcode,sdate,stockinby)values(@refno,@pcode,@sdate,@stockinby) ", cn);
                            cm.Parameters.AddWithValue("@refno", frm.textRefno.Text);
                            cm.Parameters.AddWithValue("@pcode", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                            cm.Parameters.AddWithValue("@stockinby", frm.textstockin.Text);
                            cm.Parameters.AddWithValue("@sdate", frm.dt1.Value);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            MessageBox.Show(" succesfully Added .", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadProducts();
                            frm.loadStockIn();
                        }
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
  



        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                loadProducts();
                // Enter key pressed
            }
        }

        private void txtSearch1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
