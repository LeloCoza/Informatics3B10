using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DLActorIdentity
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
        public void AddActorIdDB(string descript)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into ActorIdentity (Description) VALUES ('" + descript + "' )";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateActorIdDB(int actorid_id, string descript)
        {
            DataSet ds = new DataSet();
            string sql = "Update ActorIdentity set Description='" + descript + "' Where ActorIdentityID='" + actorid_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteActorIdDB(int actorid_id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from ActorIdentity Where ActorIdentityID='" + actorid_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveActorIdDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from ActorIdentity order by ActorIdentityID";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }
    }
}
