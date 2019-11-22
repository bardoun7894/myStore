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
    public partial class frmQty : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        frmTransaction ft = new frmTransaction();
    public frmQty(frmTransaction f)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
            ft = f;
        }

        private void frmQty_Load(object sender, EventArgs e)
        {

        }
    }
}
