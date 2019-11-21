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
    public partial class frmProduct : Form
    {
        frmProductList frmList;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        public frmProduct(frmProductList flist)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();    
            frmList = flist;
            SqlDataReader dr;
        }
 

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void loadCategory()
        {
            int i = 0;
            comboCategory.Items.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("Select category from tblCategory ", cn);
                //  dr = cm.ExecuteReader();
                using (dr = cm.ExecuteReader())
 {
                    while (dr.Read())
                    {
                     
                        comboCategory.Items.Add(  dr[0].ToString());
                    }
                }
                cm.ExecuteNonQuery();
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }


        }

        public void loadBrand()
        { 
            comboBrand.Items.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("Select brand from tblBrand ", cn);
                //  dr = cm.ExecuteReader();
                using (dr = cm.ExecuteReader())

                {
                    while (dr.Read())
                    {

                        comboBrand.Items.Add(dr[0].ToString());
                    }
                }
                cm.ExecuteNonQuery();
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }


        }
     
        private void clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtPcode.Clear();
            textBarcode.Clear();
            txtdesc.Clear();
           comboBrand.Text = "";
            comboCategory.Text = "";
            txtPcode.Focus();
            txtprice.Clear();
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPcode.Text == "" && txtprice.Text == "" && textBarcode.Text=="")
            {
                MessageBox.Show("please fill the fields first");
            }
            else
            {
                try
                {

                    if (MessageBox.Show("Are you sure you want to save this Product ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                      
                        string cid = "";
                        string bid = "";

                        cn.Open();
                        cm = new SqlCommand("Select id from tblBrand where brand like'" + comboBrand.Text + "'", cn);
                        //  dr = cm.ExecuteReader();
                        using (dr = cm.ExecuteReader())

                        {
                            dr.Read();
                            if (dr.HasRows)
                            { cid = dr[0].ToString(); }
                        }

                        dr.Close();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("Select id from tblCategory where category like'" + comboCategory.Text + "'", cn);
                        //  dr = cm.ExecuteReader();
                        using (dr = cm.ExecuteReader())
                        {
                            dr.Read();
                            if (dr.HasRows)
                            { bid = dr[0].ToString(); }
                        }

                        dr.Close();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("INSERT INTO   tblProduct (pcode,pbarcode,pdesc,bid,cid,price) VALUES (@pcode,@pbarcode,@pdesc,@bid,@cid,@price)  ", cn);
                        cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                        cm.Parameters.AddWithValue("@pbarcode", textBarcode.Text);
                        cm.Parameters.AddWithValue("@pdesc", txtdesc.Text);
                        cm.Parameters.AddWithValue("@bid", bid);
                        cm.Parameters.AddWithValue("@cid", cid);
                        cm.Parameters.AddWithValue("@price", txtprice.Text);

                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Products has succesfully saved .");
                        clear();
                            frmList.loadRecords();

                    }
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPcode.Text == "" && txtprice.Text == "" && textBarcode.Text =="")
            {
                MessageBox.Show("please fill the fields first");
            }
            else
            {
                try
                {

                    if (MessageBox.Show("Are you sure you want to Update this Product ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        string cid = "";
                        string bid = "";

                        cn.Open();
                        cm = new SqlCommand("Select id from tblBrand where brand like'" + comboBrand.Text + "'", cn);
                        //  dr = cm.ExecuteReader();
                        using (dr = cm.ExecuteReader())

                        {
                            dr.Read();
                            if (dr.HasRows)
                            { cid = dr[0].ToString(); }
                        }

                        dr.Close();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("Select id from tblCategory where category like'" + comboCategory.Text + "'", cn);
                        //  dr = cm.ExecuteReader();
                        using (dr = cm.ExecuteReader())
                        {
                            dr.Read();
                            if (dr.HasRows)
                            { bid = dr[0].ToString(); }
                        }

                        dr.Close();
                        cn.Close();

                        cn.Open();
                        cm = new SqlCommand("Update tblProduct SET  pbarcode=@pbarcode , pdesc=@pdesc,bid=@bid,cid=@cid,price=@price where pcode like @pcode ", cn);
                        cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                        cm.Parameters.AddWithValue("@pbarcode", textBarcode.Text);
                        cm.Parameters.AddWithValue("@pdesc", txtdesc.Text);
                        cm.Parameters.AddWithValue("@bid", bid);
                        cm.Parameters.AddWithValue("@cid", cid);
                        cm.Parameters.AddWithValue("@price", txtprice.Text);

                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Products has succesfully saved .");
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

        private void comboBrand_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboCategory_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

     

        private void txtPcode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
 

        private void Barcodebtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
