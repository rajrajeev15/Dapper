using System;
using DapperDemo.Contract;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DapperDemo.Entities;
using Dapper;


namespace DapperDemo.Services
{


    public class CustomerServices : ICRUD<CustomerEntities>
    {

        string strcon = string.Empty;
        SqlConnection Con = null;
       
        

        public CustomerServices()
        {
            CustomerEntities ct2 = new CustomerEntities();
            
            strcon = ConfigurationManager.ConnectionStrings["PractiseDbContext"].ConnectionString;
            Con = new SqlConnection(strcon);
        }
       

        public int Create(CustomerEntities obj1)
        {
            var para = new DynamicParameters();
            para.Add("@CustomerName", obj1.CustomerName); // Normal Parameters  
            para.Add("@ContactName", obj1.ContactName);
            para.Add("@Address", obj1.Address);
            para.Add("@City", "1");
            para.Add("@PostalCode", "1");

            Con.Open(); // opening connection  

            Con.Execute("proc_customerInsert", para, commandType: CommandType.StoredProcedure);
            //Executing Command   
            // con.Execute("INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode) VALUES ('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006');");
            Con.Close();
            return 0;
        }

        public int Delete(CustomerEntities obj1)
        {
            return 0;
        }

        public CustomerEntities List()
        {
            return null;
        }

        public int Update(CustomerEntities obj1)
        {
            return 0;
        }
    }

   
}
