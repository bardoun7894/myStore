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
    public partial class frmSettlePayment : Form
    {
        frmTransaction ft = new frmTransaction();
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        public frmSettlePayment(frmTransaction ftm)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
            ft = ftm; 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmSettlePayment_Load(object sender, EventArgs e)
        {

        }

        private void textCash_TextChanged(object sender, EventArgs e)
        {
            try

            {
                if (textCash.Text.Equals("")) {  
                    textChange.Text = "0";
                    return;
                }
                double sale = double.Parse(lblSale.Text);
                double cash = double.Parse(textCash.Text);
                double change = cash-sale;
                textChange.Text =change.ToString( ) ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn1N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn1N.Text;
        }

        private void btn2N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn2N.Text;
        }

        private void btn3N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn3N.Text;
        }

        private void btn4N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn4N.Text;
        }

        private void btn5N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn5N.Text;
        }

        private void btn6N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn6N.Text;
        }

        private void btn7N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn7N.Text;
        }

        private void btn8N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn8N.Text;
        }

        private void btn9N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn9N.Text;
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            textCash.Clear();
        }

        private void btn0N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn0N.Text;
        }

        private void btn00N_Click(object sender, EventArgs e)
        {
            textCash.Text += btn00N.Text;
        }

        private void btnEnterN_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (double.Parse(textChange.Text) < 0 || textCash.Text==String.Empty)
                {
                    MessageBox.Show("insufficient Amount. please enter the correct amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for(int i = 0; i < ft.dataGridView1.Rows.Count; i++)
                    { 
                        cn.Open();
              cm = new SqlCommand("update tblProduct set qty = qty - "+
              int.Parse(ft.dataGridView1.Rows[i].Cells[5].Value.ToString())+" where pcode = '"+ ft.dataGridView1.Rows[i].Cells[2].Value.ToString() + "'",cn);
              cm.ExecuteNonQuery(); 
                        cn.Close();
                        cn.Open();
                          cm = new SqlCommand("update tblCart set status = 'Sold' where id like '" + ft.dataGridView1.Rows[i].Cells[1].Value.ToString()  + "'", cn);
                          cm.ExecuteNonQuery();
                        cn.Close();  
                     }
                    frmReceipt fr = new frmReceipt(ft);
                    fr.loadReport(textCash.Text,textChange.Text);
                    fr.ShowDialog();



                    MessageBox.Show("Payment successfully Saved .", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ft.getTransno();
                    ft.loadCart();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
