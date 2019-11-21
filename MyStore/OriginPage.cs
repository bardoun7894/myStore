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
    public partial class OriginPage : Form
    {
       
        public OriginPage()
        {
            InitializeComponent(); 
        }
  
  

        private void btnBrandList_Click(object sender, EventArgs e)
        {
            frmBrandList f = new frmBrandList();

            f.TopLevel = false;

            f.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(f);

            f.BringToFront();
            f.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
             
        }

        private void btnXcerrar(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void catagoryBtn_Click(object sender, EventArgs e)
        {
            frmCategoryList f = new frmCategoryList();

            f.TopLevel = false;

            f.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(f);

            f.BringToFront();
            f.Show();
        }
 
 

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            frmProductList f = new frmProductList();

            f.TopLevel = false;

            f.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(f);

            f.BringToFront();
            f.Show();
        }

        private void StockBTN_Click(object sender, EventArgs e)

        {  
            frmStockIn f = new frmStockIn();
            f.loadProducts();

            f.TopLevel = false;

            f.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(f);

            f.BringToFront();
            f.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }
    }
}