using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Configuration;     //import data references
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public class DLProduct
    {
        public DB db;
        public DLProduct()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddProductDB(Product product)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Product (ProductName, ProductDescript, ProductPrice, ProductPicture, CategoryID) VALUES ('" + product.prod_name + "','" + product.prod_descript + "','" + product.prod_price + "','" + product.prod_price + "','" + product.cat_id + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateProductDB(Product product)
        {
            DataSet ds = new DataSet();
            string sql = "Update Product set ProductName='" + product.prod_name + "',ProductDescript='" + product.prod_descript + "',ProductPrice='" + product.prod_price + "'ProductPicture='" + product.prod_pic + "'CategoryID='" + product.cat_id + "' Where ProductID='" + product.prod_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteProductDB(Product product)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Productr Where ProductID='" + product.prod_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveProductDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Product order by ProductID";
            ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
