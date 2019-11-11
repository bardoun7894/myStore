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
    public partial class FrmOrders_kind : Form
    {
        DB db = new DB();
        public FrmOrders_kind()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmOrders_kind_Load(object sender, EventArgs e)
        {
            String sql = @" SELECT [order_kind_id]  ,[order_kind_name] FROM [dbo].[Order_kind]";

            DataTable dt = db.excuteDataTable(String.Format(sql));
            bunifuCustomDataGrid1.DataSource = dt;
            bunifuCustomDataGrid1.Columns[0].HeaderText = "الرقم ";
            bunifuCustomDataGrid1.Columns[1].HeaderText = "النوع";

          ///  bunifuCustomDataGrid1.Refresh();
        }
    }
}
