using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;      //import EntityLayer
using System.Configuration;     //import data references
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public class DLCategory
    {
        /*declare a DB class variable
        and instantite it in the DLOder constructor*/
        public DB db;
        public DLCategory()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddCategoryDB(Category category)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Category (CategoryName) VALUES ('" + category.cat_name + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateCategoryDB(Category category)
        {
            DataSet ds = new DataSet();
            string sql = "Update Category set CategoryName='" + category.cat_name + "' Where CategoryID='" + category.cat_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteCategoryDB(Category category)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Category Where CategoryID='" + category.cat_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveCategoryDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Category order by CategoryID";
            ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
