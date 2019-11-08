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
    public partial class MdiClass : Form
    {
        public MdiClass()
        {
            InitializeComponent();
        }

        private void الشاشةالرئيسيةToolStripMenuItem_Click(object sender, EventArgs e)

        {
            frmMain frm = new frmMain();
            frm.MdiParent = this;
            frm.Show();


        }

        private void المخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //اضفنا الفروع الى الحاوية
        private void الفروعToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmBranchAdd frm = new frmBranchAdd();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
