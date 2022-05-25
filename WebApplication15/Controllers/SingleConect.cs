using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication15.Controllers
{
    public class SingletonDB
    {
        private static readonly SingletonDB instance = new SingletonDB();
        private static SqlConnection con;
        static SingletonDB()
        {
        }
        private SingletonDB()
        {
        }
        public static SingletonDB Instance
        {
            get
            {
                return instance;
            }
        }
        public static SqlConnection GetDBConnection()
        {
            if (con == null)
            {
                con = new SqlConnection("Data Source=SQL8001.site4now.net;Initial Catalog=db_a85d62_okay;User Id=db_a85d62_okay_admin;Password=123zxc34");
                con.Open();
            }
            return con;
        }
    }
}

