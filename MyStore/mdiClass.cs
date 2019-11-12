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
 
        private void MdiClass_Load(object sender, EventArgs e)
        {


        }

        //اضفنا الفروع الى الحاوية
        private void تعديلالفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmBranchAdd frm = new frmBranchAdd();
            frm.MdiParent = this;

            this.WindowState = FormWindowState.Maximized;
            frm.Show();

             
        }

        private void تعديللمخانToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmBranches_store frm = new frmBranches_store();
            frm.MdiParent = this;
          
            frm.Show();

            this.WindowState = FormWindowState.Maximized;
        }

        private void الشاشةالرئيسيةToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            frmMain frm = new frmMain();
            frm.MdiParent = this;
            frm.Show();
        }

        private void نوعالطلبToolStripMenuItem_Click(object sender, EventArgs e)
        {


            FrmOrders_kind frm = new FrmOrders_kind();
            frm.MdiParent = this;
            frm.Show();
        }

        private void نوعالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {


            FrmUsers_kind frm = new FrmUsers_kind();
            frm.MdiParent = this;
            frm.Show();
        }

        private void المخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OriginPage O = new OriginPage();
            O.MdiParent = this;
            O.Show();
        }

        private void الوحداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnits frm = new FrmUnits();
            frm.MdiParent = this;
            frm.Show();
        }

        private void اعداداتالشركةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings fs = new FrmSettings();
            fs.MdiParent = this;
            fs.Show();
        }

        private void الموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsersShow frm = new FrmUsersShow("3");
            frm.MdiParent = this;
            frm.Show();
        }

        private void اضافةموردجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsers fs = new FrmUsers("2");
            fs.MdiParent = this;
            fs.Show();
        }
 

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsers fs = new FrmUsers("3");
            fs.MdiParent = this;
            fs.Show();
        }

        private void الفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsers fs = new FrmUsers("1");
            fs.MdiParent = this;
            fs.Show();

        }

        private void بحثعنعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsersShow frm = new FrmUsersShow("1");
            frm.MdiParent = this;
            frm.Show();
        }

        private void موضفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsersShow frm = new FrmUsersShow("2");
            frm.MdiParent = this;
            frm.Show();

        }

        private void بحثعنموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsersShow frm = new FrmUsersShow("3");
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
