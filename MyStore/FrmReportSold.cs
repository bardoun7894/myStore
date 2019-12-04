using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStore
{
    public partial class FrmReportSold : Form
    {
        SqlConnection cn;
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbCon = new DBConnection();
        frmSoldItem fsi;
        public FrmReportSold(frmSoldItem fs)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
            fsi = fs;
        }

        private void FrmReportSold_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }
        public void loadReport( )
        {

            ReportDataSource rptDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Report\Report2.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                DataSet1 dt = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand(@"select c.transno,c.pcode,p.pdesc,
                 c.price, c.qty, c.disc, c.total, c.status from tblCart 
                 as c inner join tblProduct as p
                 on p.pcode = c.pcode where status like 'Sold' and sdate between '" + fsi.dt1.Value + "' and '" + fsi.dt2.Value + "'", cn);
                da.Fill(dt.Tables["dtSoldReport"]);
                cn.Close();
 

                rptDataSource = new ReportDataSource("DataSet1", dt.Tables["dtSoldReport"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomPercent = 30;



            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
