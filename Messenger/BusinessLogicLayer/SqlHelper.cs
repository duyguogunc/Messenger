using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer
{
    class SqlHelper
    {
        public string connectionString { get; set; }
        public SqlConnection conn { get; set; }

        public SqlHelper()
        {
            connectionString = @"Data Source=185.23.75.48,8081\SQLEXPRESS;
                                    Initial Catalog=WissenMM;
                                      User ID=wissen302;Password=123456";
            conn = new SqlConnection(connectionString);
        }

     
    }
}
