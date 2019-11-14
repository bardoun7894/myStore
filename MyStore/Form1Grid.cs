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
    public partial class Form1Grid : Form
    {
        DB db = new DB();

        public Form1Grid()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1Grid_Load(object sender, EventArgs e)
        {


            String sql = @" SELECT [branch_id] ,[branch_name]  FROM [dbo].[Branches]";

            DataTable dt = db.excuteDataTable(String.Format(sql));
            dataGridViewMo.DataSource = dt;
            
            dataGridViewMo.Refresh();

        }

    }
      
    }

