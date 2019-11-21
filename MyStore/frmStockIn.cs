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
    public partial class frmStockIn : Form
    {
        SqlConnection cn  ;
        SqlCommand cm;
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
   
        public frmStockIn()
        {
            cn = new SqlConnection(dbCon.MyConnection());

            InitializeComponent();
            loadStockIn();
        


        }


        public void clear()
        {
            textRefno.Text = "";
            textstockin.Text = "";
            dt1.Value = DateTime.Now;


        }
        public void loadStockInHistory() {

            int i = 0;
            dataGridView3.Rows.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("Select * from vwStockin where sdate between '"+dtH1.Value+"' and '"+dtH2.Value+"' and status like 'Done' ", cn);
                //  dr = cm.ExecuteReader();
                using (dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        i += 1;
                        dataGridView3.Rows.Add(i, dr[0].ToString(), dr[1].ToString()
                        , dr[2].ToString(), dr[3].ToString(),
                        dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                    }
                }
                cm.ExecuteNonQuery();
                dr.Close();
                cn.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            
            
            }
            
            

        
        public void loadStockIn()

        {
            int i = 0;
            dataGridView2.Rows.Clear();
            try
            {
                cn.Open();
                cm = new SqlCommand("Select * from vwStockin where refno like '"+textRefno.Text+"' and status like 'Pending' ", cn);
                //  dr = cm.ExecuteReader();
                using (dr = cm.ExecuteReader())
                {
                    while (dr.Read())
                    { 
                        
                        i += 1;
                        dataGridView2.Rows.Add(i, dr[0].ToString(), dr[1].ToString()
                        , dr[2].ToString(), dr[3].ToString(),
                        dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;

            if (colName == "colDelete")
            {
                if (MessageBox.Show("Are you sure you want to remove this item ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                     
                  
                    cn.Open();
                    cm = new SqlCommand("delete from tblStockIn where id like  '" + dataGridView2[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has succesfully Deleted .", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            loadStockIn();
                }

        internal void loadProducts()
        {
           // throw new NotImplementedException();
        }

      
        private void frmStockIn_Load(object sender, EventArgs e)
        {

        }

        private void textRefno_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSeachProductStockI f = new frmSeachProductStockI(this);
            f.loadProducts();
            f.ShowDialog();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Save it ?", "you are save it", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView2.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {

                            cn.Open();
                            cm = new SqlCommand("update tblProduct set qty=qty + '" + int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()) + "' where pcode like '" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            cn.Open();
                            cm = new SqlCommand("update tblStockIn set qty=qty + '" + int.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString()) + "', status ='Done' where id like  '" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "'", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();



                        }


                    }

                    clear();
                    loadStockIn();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadStockInHistory();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
        }
    
