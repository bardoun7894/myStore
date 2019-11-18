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
    public partial class Products : Form
    {
        DB db = new DB();
        String store_id = "1";
        
        public Products()
        {
            InitializeComponent();
            
        }
 
        private void Products_Load(object sender, EventArgs e)
        {
            Random rm = new Random();
            int x = rm.Next(10000, 50000);
            storeId.Text = store_id;
            textProductCode.Text = x.ToString();
            String sqlCata = @" SELECT [cate_id] ,[cate_name]  FROM [dbo].[Products_category]";
            DataTable dt = db.excuteDataTable(String.Format(sqlCata));
            comboCategory.DataSource = dt;
          comboCategory.DisplayMember = "cate_name";
            comboCategory.ValueMember = "cate_id";
           

            String sqlUnit = @" SELECT [unit_id] ,[unit_name]  FROM [dbo].[Units]";
            DataTable dt2 = db.excuteDataTable(String.Format(sqlUnit));
            comboBoxUnit.DataSource = dt2 ;
            comboBoxUnit.DisplayMember = "unit_name";
            comboBoxUnit.ValueMember = "unit_id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [dbo].[Products]
           ([product_name]
           ,[product_image]
           ,[product_code]
           ,[product_date]
           ,[product_quantity]
           ,[product_quantity_alert]
           ,[product_price]
           ,[cate_id]
           ,[store_id]
           ,[unite_id])
     VALUES (N'{0}',N'{1}',N'{2}',{3},N'{4}',
N'{5}',N'{6}',N'{7}',N'{8}',N'{9}' )";

            string date = "CAST(CONVERT(varchar(50),getdate(),121) AS DATETIME)";
 

            string code = textProductCode.Text;
         

            db.excuteSql(string.Format(sql, textProduct.Text, " kf"
                , code, date, textBoxQuantity.Text, textBoxWarn.Text
                , textBoxPrice.Text, comboCategory.SelectedValue,
                 storeId.Text, comboBoxUnit.SelectedValue));



            MessageBox.Show("add good");


        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
