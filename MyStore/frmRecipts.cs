using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace MyStore
{
    public partial class frmReceipt : Form
    {
        SqlConnection cn = new SqlConnection();
        string store = "MOhajirin";
        string adresse = "rue Tarrafin kaisariat louckach N:3";
        DBConnection dbCon = new DBConnection();
        frmTransaction fs;
        public frmReceipt(frmTransaction fms)
        {
            cn = new SqlConnection(dbCon.MyConnection());
            InitializeComponent();
            fs = fms;
        }
 
        public void loadReport(string cash,string change)
        {

            ReportDataSource rptDataSource;
            try
            {
                this.reportViewer2.LocalReport.ReportPath = Application.StartupPath + @"\Report\Report1.rdlc";
                this.reportViewer2.LocalReport.DataSources.Clear();

             DataSet1 dt = new DataSet1();
                SqlDataAdapter da = new SqlDataAdapter();
                cn.Open();
                da.SelectCommand = new SqlCommand("select c.id,c.transno,c.pcode,c.price,c.qty,c.disc,c.total,c.sdate,c.status,p.pdesc from tblCart as c inner join tblProduct as p on p.pcode=c.pcode where transno like '" + fs.lblTransno.Text + "'", cn);
               da.Fill(dt.Tables["dtsold"]);
                cn.Close();

                ReportParameter pVatable = new ReportParameter("pVatable", fs.lblVatable.Text);
                ReportParameter pVat = new ReportParameter("pvat", fs.lblVat.Text);
                ReportParameter pDiscount = new ReportParameter("pDiscount", fs.lblDiscount.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", fs.lblSaletotal.Text);
                ReportParameter pChange = new ReportParameter("pChange", change);
                ReportParameter pCash = new ReportParameter("pcash", cash);
                ReportParameter pStore = new ReportParameter("pStore", store);
                ReportParameter pAdresse = new ReportParameter("pAdresse", adresse);
                ReportParameter ptransaction = new ReportParameter("pTransaction", "Invoice #:" + fs.lblTransno.Text);

                reportViewer2.LocalReport.SetParameters(pVatable);

                reportViewer2.LocalReport.SetParameters(pVat);
                reportViewer2.LocalReport.SetParameters(pDiscount);
                reportViewer2.LocalReport.SetParameters(pTotal);
                reportViewer2.LocalReport.SetParameters(pChange);
                reportViewer2.LocalReport.SetParameters(pCash);
                reportViewer2.LocalReport.SetParameters(pStore);
                reportViewer2.LocalReport.SetParameters(pAdresse);
                reportViewer2.LocalReport.SetParameters(ptransaction);

                rptDataSource = new ReportDataSource("DataSet1", dt.Tables["dtsold"]);
                reportViewer2.LocalReport.DataSources.Add(rptDataSource);
                reportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer2.ZoomPercent = 30;
  
                    
                    
                    }
             catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}
