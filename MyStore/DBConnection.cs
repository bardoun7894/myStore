using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    class DBConnection
    {


        public string MyConnection()
        {
            string con= ConfigurationManager.ConnectionStrings["mycon"].ConnectionString.ToString(); ;
            return con;
        }
    }


}
