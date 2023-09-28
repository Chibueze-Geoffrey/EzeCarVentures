using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace EzeCarVentures.Data
{
    public class Db
    {
        public static string ConnectionString
        {
            get
            {
               string connStr= ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connStr);
                sb.ApplicationName = ApplicationName ?? sb.ApplicationName;
                sb.ConnectTimeout= (ConnectionTimeOut> 0)? ConnectionTimeOut: sb.ConnectTimeout;
                return sb.ToString();
            }
        }
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new  SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
        public static int ConnectionTimeOut { get; set; }
        public static string ApplicationName
        {
            get;
            set;
        }
    }
}
