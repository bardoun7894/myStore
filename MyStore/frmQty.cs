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
    public partial class frmQty : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        frmTransaction ft = new frmTransaction();
        private string pcode;
        private double price;
        private string transno;


        public frmQty(frmTransaction f)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
            ft = f;
         
        }

        public void productDetails(string pcode,double price,string transno)
        {
            this.pcode =  pcode;
            this.price =  price;
            this.transno = transno;
        }
        private void frmQty_Load(object sender, EventArgs e)
        {



           
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
              

                if (txtqty.Text != string.Empty)
                {
                    try
                    {
                        cn.Open();
                        cm = new SqlCommand("insert into tblCart (transno,pcode,price,qty,sdate)values(@transno,@pcode,@price,@qty,@sdate) ", cn);
                        cm.Parameters.AddWithValue("@transno", transno);
                        cm.Parameters.AddWithValue("@pcode", pcode);
                        cm.Parameters.AddWithValue("@price", price);
                        cm.Parameters.AddWithValue("@qty", int.Parse(txtqty.Text));
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        ft.barcodeSearch.Clear();
                        ft.barcodeSearch.Focus();
                        ft.loadCart();
                        this.Dispose();

                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void frmQty_KeyPress(object sender, KeyPressEventArgs e)
        {
             
           
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
