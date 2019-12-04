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
    public partial class frmSoldItem : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        public frmSoldItem()
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
        }

        private void frmSoldItem_Load(object sender, EventArgs e)
        {
            loadRecord();
        }
       public void loadRecord()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            try
            {
                double _total = 0;
                cn.Open();
                cm = new SqlCommand(@"select c.id,c.transno,c.pcode,p.pdesc,
           c.price, c.qty, c.disc, c.total, c.status from tblCart 
          as c inner join tblProduct as p
                 on p.pcode = c.pcode where status like 'Sold' and sdate between '"+dt1.Value+"' and '"+dt2.Value+"'", cn);

                using (dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        i += 1;
          dataGridView2.Rows.Add(i, dr["id"].ToString(), dr["transno"].ToString(),
              dr["pcode"].ToString(),  dr["pdesc"].ToString(), dr["price"].ToString(),
              dr["qty"].ToString(), dr["disc"].ToString() , dr["total"].ToString()
              );
                        _total += double.Parse(dr["total"].ToString());
                   }
                }
                cm.ExecuteNonQuery();
                cn.Close();
                lblTotal.Text = _total.ToString("#,##0.00");
            }
            catch (Exception e)
            {
                cn.Close();
                MessageBox.Show(e.Message);
            }
          

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadRecord();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            loadRecord();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FrmReportSold frs = new FrmReportSold(this);
            frs.loadReport();
            frs.ShowDialog();
        }
    }
}
