using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class frmMain : Form
    { 
        public frmMain()
        {
            InitializeComponent();

            //توقفت هنا 
            string dayfile = File.ReadAllText("D://test/1.txt");
            if (int.Parse(dayfile) >= DateTime.Now.Day)
            {
                button1.Enabled = false;
                MessageBox.Show("انتهت صلاحيتك");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        
            {

            }

        }
 

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
