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
    public partial class frmCatagory2 : Form
    {
        DB db = new DB();
        public frmCatagory2()
        {
            InitializeComponent();
        }
         
        private void frmCatagory_Load(object sender, EventArgs e)
        {


            if (categorytext.Text != "")
            {
                btnSaveCatagory.Visible = false;
                bfbEditCatagory.Visible = false;
                bfbDeleteCategory.Visible = false;
            }
            
 
          

            showData();


        }
        public void showData()
        {
            string sql = @" SELECT [cate_id] ,[cate_name]  FROM [dbo].[Products_category]";
            DataTable dt = db.excuteDataTable(string.Format(sql));

            bunifuCustomDataGrid1.DataSource = dt;
            bunifuCustomDataGrid1.Columns[0].HeaderText = "رقم الفئة";
            bunifuCustomDataGrid1.Columns[1].HeaderText = "الفئة";
            bunifuCustomDataGrid1.Refresh();

            categorytext.Text = "";


        }

        private void btnSaveBranchStore_Click(object sender, EventArgs e)
        {

            if (categorytext.Text != "")
            {
                EditCatagories ec = new EditCatagories(lblId1.Text, categorytext.Text);
                ec.MdiParent = frmMain.ActiveForm;
                ec.Show();

            }
            else
            {

                MessageBox.Show("Please choose the catagory name to edit");
            }


        }

        private void bunifuCustomDataGrid1_SelectionChanged(object sender, EventArgs e)
        {
           
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int rowindex = bunifuCustomDataGrid1.SelectedCells[1].RowIndex;
                DataGridViewRow row = this.bunifuCustomDataGrid1.Rows[rowindex];
                string cate_id = row.Cells["cate_id"].Value.ToString();
                lblId1.Text = cate_id;
     string cate_name = row.Cells["cate_name"].Value.ToString();
                categorytext.Text = cate_name;
            }

        }

        private void bfbEditBranches_Click(object sender, EventArgs e)
        {

            if (categorytext.Text!="")
            {
                EditCatagories ec = new EditCatagories(lblId1.Text, categorytext.Text);
                ec.MdiParent = frmMain.ActiveForm;
                ec.Show();

            }
            else
            {
                MessageBox.Show("Please choose the catagory name to edit");
            }
           
        
  

        }

        private void bfbDeleteBranches_Click(object sender, EventArgs e)
        {
            string sql = "delete from Products_category where cate_id = '{0}' ";
            DialogResult dialogResult = MessageBox.Show("هل تريد حذف الفئة", "حذف الفئة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                db.excuteSql(string.Format(sql, lblId1.Text));
                categorytext.Text = "";
                showData();

            }
            else if (dialogResult == DialogResult.No)
            {
                showData();
            }
      
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
