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
    public class DLCategory
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
        public void AddCategoryDB(string category_name)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Category (CategoryName) VALUES ('" + category_name + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCategoryDB(int category_id, string category_name)
        {
            DataSet ds = new DataSet();
            string sql = "Update Category set CategoryName='" + category_name + "' Where ActorID='" + category_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCategoryDB(int category_id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Category Where CategoryID='" + category_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveCategoryDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Category order by CategoryID";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }
    }
}
