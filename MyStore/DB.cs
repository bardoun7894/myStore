using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

 
    class DB
    {
     
    string con = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString.ToString();
    SqlConnection cn;
    SqlCommand cmd =new SqlCommand();
    DataTable dt;
    SqlDataAdapter ad = new SqlDataAdapter();
    public SqlConnection sqlFire()
    {    cn = new SqlConnection(con);
        return cn;
    }

    public DB(){
        cn = sqlFire();
    }
    object val = "";


    //FUNCTION FOR SELECT-ADD-EDIT-DELETE
    public String excuteSql(string sql)
    {
        try
        { 
            if (cn.State == ConnectionState.Closed) { cn.Open(); }
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            val = cmd.ExecuteScalar();
            if (val == null)  {  return ""; }
            return val.ToString();

        } catch
        {
            return null;
        }    finally
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cmd.Dispose();
        }
    }
    //FUNCTION TABLE
    public DataTable excuteDT(string sql){
        try { 
        dt = new DataTable();
            if (cn.State == ConnectionState.Closed) { cn.Open(); }
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                ad.SelectCommand = cmd;
                ad.Fill(dt);
                return dt;
        }
        catch
        {
            return null;
        }
        finally
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            cmd.Dispose();
        }


    }


    }
