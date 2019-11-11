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
    public partial class FrmVendorsAdd : Form
    {
        //اضافة المورد
        String user_kind_id = "";

        public FrmVendorsAdd(string kind_user)
        {
            InitializeComponent();
        }

        private void FrmVendorsAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
