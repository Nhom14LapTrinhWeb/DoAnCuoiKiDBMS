using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi
{
    class ConnectDB
    {
        string strSQL;
        public ConnectDB(string strSQL)
        {
            this.strSQL = strSQL;
        }
        //string host,string username,string password
        public void ExecuteUpdateSQL()
        {
            string strConnectionString = "Data Source=localhost;Initial Catalog=DoAnCuoiKi;Integrated Security=True;";
            SqlConnection myConnection = new SqlConnection(strConnectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(strSQL, myConnection);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        public DataSet OpenDataSet()
        {
            string strConnectionString = "Data Source=localhost;Initial Catalog=DoAnCuoiKi;Integrated Security=True;";
            SqlConnection myConnection = new SqlConnection(strConnectionString);
            myConnection.Open();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(strSQL, myConnection);
            DataSet ds = new DataSet();
            myDataAdapter.Fill(ds);
            myConnection.Close();
            return ds;
        }
    }
}
