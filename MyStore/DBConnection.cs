using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyStore
{
    public class DBConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
     
        

        public string MyConnection()
        {
            string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString.ToString(); ;
            return con;
        }



        public double GetVal()
        {
            double vat = 0;
            cn.ConnectionString = MyConnection();
            cn.Open();
            cm = new SqlCommand("select * from tblVAT", cn);

            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                vat = double.Parse(dr["vat"].ToString());
            }

            dr.Close();
            cn.Close();
            return vat;

        }
    }


}
