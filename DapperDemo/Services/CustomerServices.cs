using System;
using DapperDemo.Contract;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace DapperDemo.Services
{


    public class CustomerServices : ICRUD<CustomerEntities>
    {

        string strcon = string.Empty;
        SqlConnection Con = null;


        public CustomerServices()
        {
            strcon = ConfigurationManager.ConnectionStrings["PractiseDbContext"].ConnectionString;
            Con = new SqlConnection();
        }
        public int Create<CustomerEntities>(CustomerEntities obj1)
        {
            //var para = new DynamicParameters();

            //para.Add("@CustomerName", obj1); // Normal Parameters  
            //para.Add("@ContactName", objss.ROLLNO);
            //para.Add("@Address", objss.COURSE);
            //para.Add("@City", "1");
            //para.Add("@PostalCode", "1");
            ////@CustomerName ,@ContactName,@Address ,@City ,@PostalCode
            //para.Add("@Myout", dbType: DbType.Int32, direction: ParameterDirection.Output);
            //// Getting Out Parameter  

            //para.Add("@Ret", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            //// Getting Return value  

            //Con.Open(); // opening connection  

            //Con.Execute("Usp_getallstudents", para, commandType: CommandType.StoredProcedure);
            ////Executing Command   
            //// con.Execute("INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode) VALUES ('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006');");
            return 0;
        }

        public int Delete<CustomerEntities>(CustomerEntities obj1)
        {
            return 0;
        }

        public CustomerEntities List()
        {
            return null;
        }

        public int Update<CustomerEntities>(CustomerEntities obj1)
        {
            return 0;
        }
    }

   
}
