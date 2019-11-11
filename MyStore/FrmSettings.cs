using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class FrmSettings : Form
    {
        DB db = new DB();
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fd.FileName);
                textBoxLogo.Text = fd.FileName;
                lbl.Text = Path.GetFileName(fd.FileName);
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT [setting_id]  ,[setting_title]  ,[setting_logo] ,[setting_phone] FROM[dbo].[Settings]";
            DataTable dt = db.excuteDataTable(string.Format(sql));

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    textBoxName.Text = dr["setting_title"].ToString();
                    textBoxPhone.Text = dr["setting_phone"].ToString();
                    lbl.Text = dr["setting_logo"].ToString();
                    if (dr["setting_logo"].ToString() != "")
                    {
                        string imageLocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "images/" + dr["setting_logo"].ToString());
                        pictureBox1.ImageLocation = imageLocation;
                    }
                }




            }






        }

        private void btnSaveBranchStore_Click(object sender, EventArgs e)
        {


            if (textBoxName.Text == "")
            {
                MessageBox.Show("ادخل اسم البرنامج ");
            }
            else
            {
                if (pictureBox1.Image != null)
                {
                    //uplaod image to folder
                    string imagelocation = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "images/" + lbl.Text);
                    Bitmap btm = new Bitmap(pictureBox1.Image);
                    btm.Save(imagelocation);
                    //--------
                }

               string sql = "delete from Settings";
              db.excuteSql(string.Format(sql));
                string sqlinsert = @"insert into Settings ([setting_id]
      ,[setting_title]
      ,[setting_logo]
      ,[setting_phone])  values (N'{0}',N'{1}',N'{2}',N'{3}' )";

                db.excuteSql(string.Format(sqlinsert, "1", textBoxName.Text, lbl.Text, textBoxPhone.Text));
                MessageBox.Show("تم الحفظ بنجاح");


            }
        }
    }
}
