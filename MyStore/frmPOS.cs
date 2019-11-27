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
        frmTransaction f=new frmTransaction();
    
        public frmPOS()
        {
            InitializeComponent();
            Boolean hasRecord = false;

            if (hasRecord)
            { 
                btnSettle.Enabled = true;
                btnDiscount.Enabled = true;
            } else {
  
                btnSettle.Enabled = false;
                btnDiscount.Enabled = false;
            }
        }
       public void loadPos()
        {
             
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
            f.getTransno();
            f.barcodeSearch.Enabled = true;
            f.barcodeSearch.Focus();


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

        private void btnTrasaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to open a new Tansaction", 
                "New Tansaction", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                f.getTransno();
                f.barcodeSearch.Enabled = true;
                f.barcodeSearch.Focus();
            }
        

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
         
            frmLookUp fr = new frmLookUp(f);
            
             fr.ShowDialog();

        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount fr = new frmDiscount(f);
            fr.lblId.Text = f.numId();
            fr.lblPrice.Text = f.numPrice();

            fr.ShowDialog();

        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
        
            frmSettlePayment fr = new frmSettlePayment();
            fr.lblSale.Text = f.lblSaletotal.Text;
            fr.ShowDialog();
        }
    }
}
