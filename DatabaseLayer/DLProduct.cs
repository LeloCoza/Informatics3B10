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
    public class DLProduct
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
        public void AddProductDB(string prod_name, string prod_descript, string prod_price, string prod_pic, int catid)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Product (ProductName, ProductDescript, ProductPrice, ProductPicture, CategoryID) VALUES ('" + prod_name + "','" + prod_descript + "','" + prod_price + "','" + prod_price + "','" + catid + "')";
            InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateProductDB(int prod_id, string prod_name, string prod_descript, string prod_price, string prod_pic, int catid)
        {
            DataSet ds = new DataSet();
            string sql = "Update Product set ProductName='" + prod_name + "',ProductDescript='" + prod_descript + "',ProductPrice='" + prod_price + "'ProductPicture='" + prod_pic + "'CategoryID='" + catid + "' Where ProductID='" + prod_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteProductDB(int product_id)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Productr Where ProductID='" + product_id + "' ";
            InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveProductDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Product order by ProductID";
            ds = (DataSet)ExecuteSqlString(sql);
            return ds;
        }
    }
}
