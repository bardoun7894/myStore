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
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }
       public void loadPos()
        {
            frmTransaction f = new frmTransaction();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;


            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel10.Controls.Clear();
            panel10.Controls.Add(f);

            f.BringToFront();
            f.Show();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            loadPos();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
           
        }
    }
}
