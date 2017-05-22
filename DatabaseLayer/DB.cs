using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public class DB
    {
        //calling the connection string (FishLandDBEntities) into the DataLayer
        private string conn = ConfigurationManager.ConnectionStrings["FishLandDBEntities"].ToString();

        public void InsertUpdateDeleteSQLString(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);      //create connection to the database
            objsqlconn.Open();      //open connection
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            objcmd.ExecuteNonQuery();
        }

        public object ExecuteSqlString(string sqlstring)
        {
            SqlConnection objsqlconn = new SqlConnection(conn);
            objsqlconn.Open();
            DataSet ds = new DataSet();
            SqlCommand objcmd = new SqlCommand(sqlstring, objsqlconn);
            SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
            objAdp.Fill(ds);
            return ds;
        }
    }
}
