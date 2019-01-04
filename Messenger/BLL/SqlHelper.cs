using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class SqlHelper
    {
        public string connetionString { get; set; }
        public SqlConnection conn { get; set; }

        public SqlHelper()
        {
            connetionString =
                @"Data Source =185.23.75.48,8081\SQLEXPRESS;
                Initial Catalog=WissenMM;
                User ID=wissen302;
                Password=123456";
            conn=new SqlConnection(connetionString);
        }

        public string sendMessage()
        {

        }
        public List<>
       
    }
}
