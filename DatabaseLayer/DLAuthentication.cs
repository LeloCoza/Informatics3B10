using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;     //import data references
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public class DLAuthentication
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

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddAuthenticationDB(string uname, string password, string cpassword, int actor_id, int actorid_id)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Authentication (Username, Password, ConfirmPass, ActorID, ActorIdentity) VALUES ('" + uname + "','" + password + "','" + cpassword + "','" + actor_id + "','"  + actorid_id +  "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateAuthenticationDB(int authentication_id, string uname, string password, string cpassword, int actor_id, int actorid_id)
        {
            DataSet ds = new DataSet();
            string sql = "Update Authentication set Username='" + uname + "',Password='" + password + "',ConfirmPass='" + cpassword + "',ActorID'" + actor_id + "',ActorIdentityID'" + actorid_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteAuthenticationDB(int authentication_id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Authentication Where AuthenticationID='" + authentication_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveAuthenticationDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Authentication order by AuthenticationID";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

        //getting the userType
        public string userTyp(string user, string passw, string cpassw)
        {
            SqlCommand objcmd = new SqlCommand("Select Username from Authentication Where Username='" + user + "' Password='" + passw + "' And CPassword='" + cpassw + "')");
            string s = objcmd.ExecuteScalar().ToString();
            return s;
        }
    }
}
