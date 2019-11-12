using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class OriginPage : Form
    {
        public OriginPage()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmBranchAdd f = new frmBranchAdd();
            f.TopLevel = false;
            panel3.Controls.Add(f);

            f.BringToFront();
            f.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmBranches_store f = new frmBranches_store();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.Show();

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            FrmSettings f = new FrmSettings();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.Show();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
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

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            FrmUsersShow f = new FrmUsersShow("3");
            f.TopLevel = false;

            // حليت مشكل ظهور اطار السابق تحت هذا لاطار ب الكود الي تحت

            panel3.Controls.Clear();
            panel3.Controls.Add(f);
            f.MaximizeBox = true;
            f.BringToFront();
            f.Show();
        }
    }
}