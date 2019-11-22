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
    public partial class frmTransaction : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        public frmTransaction()
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToLongDateString();
            this.KeyPreview = true;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
        public void getTransno()
        { 
           
            string sdate = DateTime.Now.ToString("yyyyMMdd");
            string transno;
            int count ;
            dataGridView1.Rows.Clear();
            try
            {
                cn.Open(); 
                cm = new SqlCommand("select top 1 transno from tblCart where transno like '" + sdate + "%' order by id desc",cn);
                //  dr = cm.ExecuteReader();
                using (dr = cm.ExecuteReader())
                { 
                    
                    dr.Read(); 
                    if (dr.HasRows) { 
                    transno = dr[0].ToString();
                      count = int.Parse(transno.Substring(8,4));
                     lblTransno.Text = sdate + (count+1);
                          
                        } 
                        else { 
                            transno = sdate + "1001";
                            lblTransno.Text = transno;
                           
                        }
                     
                }
                cm.ExecuteNonQuery();
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void barcodeSearch_Click(object sender, EventArgs e)
        {
         
          
        }

        private void barcodeSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (barcodeSearch.Text == string.Empty) { return; }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("select * from tblProduct where pbarcode like '" + barcodeSearch.Text + "'",cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        frmQty f = new frmQty(this);
                        f.ShowDialog();
                    }
                    dr.Close();
                    cn.Close();

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
