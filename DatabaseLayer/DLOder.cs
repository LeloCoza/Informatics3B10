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
    public class DLOder
    {
        /*declare a DB class variable
        and instantite it in the DLOder constructor*/
        public DB db;
        public DLOder()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddOderDB(Oder oder)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Oder (Status, TotalAmount, Date, AuthenticationID) VALUES ('" + oder.status + "','" + oder.tamount + "','" + oder.date + oder.auth_id + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateOderDB(Oder oder)
        {
            DataSet ds = new DataSet();
            string sql = "Update Oder set Status='" + oder.status + "',TotalAmount='" + oder.tamount + "',Date='" + oder.date + "' Where OderID='" + oder.oder_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteOderDB(Oder oder)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Oder Where OderID='" + oder.oder_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveOderDB()
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Oder order by OderID";
            ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
