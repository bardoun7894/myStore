using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyStore
{



    public partial class ori2 : Form
    {
        public ori2()
        {
            InitializeComponent();




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

        private void btnxcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnStockList_Click(object sender, EventArgs e)
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

        private void btnBrand_Click(object sender, EventArgs e)
        {

            frmBrandList f = new frmBrandList();

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

        private void productBtn_Click(object sender, EventArgs e)
        {
            frmProductList f = new frmProductList();

            f.TopLevel = false;

            f.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(f);

            f.BringToFront();
            f.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategoryList f = new frmCategoryList();

            f.TopLevel = false;

            f.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(f);

            f.BringToFront();
            f.Show();
        }




        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();



        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnPOS_Click(object sender, EventArgs e)
        {

            frmPOS f = new frmPOS();
            f.ShowDialog();
        }
    }


  


}
