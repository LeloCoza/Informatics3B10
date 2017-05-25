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
    public class DLOderDetails
    {
        public DB db;
        public DLOderDetails()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddOderDetailsDB(OderDetails OD)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into OderDetails (Size, NumOfItems, OderID, ProductID) VALUES ('" + OD.size + "','" + OD.num_of_items + "','" + OD.oder_id + "','" + OD.prod_id + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateOderDetailsDB(OderDetails OD)
        {
            DataSet ds = new DataSet();
            string sql = "Update OderDetails set Size='" + OD.size + "',NumOfItems='" + OD.num_of_items + "',OderID='" + OD.oder_id + "',ProductID='" + OD.prod_id + "' Where OderDetailsID='" + OD.oder_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteOderDetailsDB(OderDetails OD)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from OderDetails Where OderDetailsID='" + OD.oder_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveOderDetailsDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from OderDetails order by OderDetailsID";
            ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
