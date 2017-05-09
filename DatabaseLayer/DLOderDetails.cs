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
    public class DLOderDetails
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
        public void AddOderDetailsDB(int oderDet_id, int size, int num_of_items)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into OderDetails (Size, NumOfItems) VALUES ('" + size + "','" + num_of_items + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateOderDetailsDB(int oderDet_id, int size, int num_of_items)
        {
            DataSet ds = new DataSet();
            string sql = "Update OderDetails set Size='" + size + "',NumOfItems='" + num_of_items + "' Where OderDetailsID='" + oderDet_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteOderDetailsDB(int oderDet_id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from OderDetails Where OderDetailsID='" + oderDet_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveOderDetailsDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from OderDetails order by OderDetailsID";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }
    }
}
