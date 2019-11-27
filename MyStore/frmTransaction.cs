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
        string id;
        string price; 
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
        public String  numId()
        {
            return id;
        }
        public String numPrice()
        {
            return price;
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

        public void loadCart()
        { 
            int i = 0;
            double total = 0;
            double discount = 0;
            try
            {
                dataGridView1.Rows.Clear();
                cn.Open();
                cm = new SqlCommand("select c.id,c.pcode,p.pdesc, c.price , c.qty,c.disc,c.total from tblCart as c inner join tblProduct as p on c.pcode=p.pcode where transno like '"+lblTransno.Text+"'", cn);
                //  dr = cm.ExecuteReader();
                using (dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        i += 1;
                       total += double.Parse(dr["total"].ToString());
                        discount += double.Parse(dr["disc"].ToString());
                        dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());
                    }
                }
                cm.ExecuteNonQuery();
                dr.Close();
                cn.Close();
           lblSaletotal.Text = total.ToString();
                lblDiscount.Text = discount.ToString();
              getCartTotal();

            

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
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
                        string pcode = dr["pcode"].ToString();
                        double price = double.Parse(dr["price"].ToString());
                        frmQty f = new frmQty(this);
                        f.productDetails(pcode, price, lblTransno.Text);

                        dr.Close();
                        cn.Close();


                        f.ShowDialog();

                    }
                    else
                    {

                        dr.Close();
                        cn.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void getCartTotal()
        {

            
            double discount = double.Parse(lblDiscount.Text);
            double sales = double.Parse(lblSaletotal.Text);
            double vat = sales*dbCon.GetVal();
           
            double vatable = sales-vat;
            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblDisplay.Text = "dh"+sales.ToString() ;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            try
            {
                if (colName == "delete")
                {


                    if (MessageBox.Show("delete this Item from Cart ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand(" delete from tblCart where id like '"+dataGridView1.Rows[e.RowIndex].Cells[1].Value+"'",cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        loadCart();
                    }
                }
            }

            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1[1, i].Value.ToString();
            price= dataGridView1[3, i].Value.ToString();


        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:MM:ss tt");
            lblDtN.Text = DateTime.Now.ToLongDateString();
        }
    }
}
