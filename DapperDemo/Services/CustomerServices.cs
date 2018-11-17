using System;
using DapperDemo.Contract;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DapperDemo.Services
{


    public class CustomerServices : ICRUD<CustomerEntities>
    {
        SqlConnection con;


        public CustomerServices()
        {
            string strcon = ConfigurationManager.ConnectionStrings["PractiseDbContext"].ConnectionString;
            //create new sqlconnection and connection to database by using connection string from web.config file  
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

        }
        public int Create<CustomerEntities>(CustomerEntities obj1)
        {
            throw new NotImplementedException();
        }

        public int Delete<CustomerEntities>(CustomerEntities obj1)
        {
            throw new NotImplementedException();
        }

        public CustomerEntities List()
        {
            throw new NotImplementedException();
        }

        public int Update<CustomerEntities>(CustomerEntities obj1)
        {
            throw new NotImplementedException();
        }
    }
}