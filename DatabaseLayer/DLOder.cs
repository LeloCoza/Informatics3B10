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
    public class DLOder
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
        public void AddOderDB(string status, string t_amount, string date)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Oder (Status, TotalAmount, Date) VALUES ('" + status + "','" + t_amount + "','" + date + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateOderDB(int oder_id, string status, string t_amount, string date)
        {
            DataSet ds = new DataSet();
            string sql = "Update Oder set Status='" + status + "',TotalAmount='" + t_amount + "',Date='" + date + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteOderDB(int oder_id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Oder Where OderID='" + oder_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveOderDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Oder order by OderID";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }
    }
}
