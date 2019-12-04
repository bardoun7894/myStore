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
            

          
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            using (frmSoldItem fsi = new frmSoldItem())
            { 
                fsi.ShowDialog();
            }
        }
    }
}
