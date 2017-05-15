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
    public class DLActor
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
        public void AddActorDB(string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address, int actorid_id)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Actor (Name, Surname, DateOfBirth, Cellphone, Email, Address) VALUES ('" + actor_name + "','" + actor_surname + "','" + actor_DOB + "','" + actor_cell + "','" + actor_email + "','" + actor_address + "','" + actorid_id + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateActorDB(int actor_id, string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address, int actorid_id)
        {
            DataSet ds = new DataSet();
            string sql = "Update Actor set Name='" + actor_name + "',Surname='" + actor_surname + "',DateOfBirth='" + actor_DOB + "'Cellphone='" + actor_cell + "',Email='" + actor_email + "',Address='" + actor_address + "',ActorIdentityID='" + actorid_id + "' Where ActorID='" + actor_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteActorDB(int actor_id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Actor Where ActorID='" + actor_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveActorDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Actor order by ActorID";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }

        //this function returns a foreign key of this class
        public object GetForeignKeyDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select ActorIdentityID from ActorIdentity";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }
    }
}
