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
    public class DLAuthentication
    {
        public DB db;
        public DLAuthentication()
        {
            //instantiate DB object for connection to the database
            //in the DLAuthentication class
            db = new DB();      
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddAuthenticationDB(Authentication auth)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Authentication (Username, Password, ConfirmPass, ActorID) VALUES ('" + auth.uname + "','" + auth.passw + "','" + auth.cpassw + "','" + auth.actor_id +  "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void UpdateAuthenticationDB(Authentication auth)
        {
            DataSet ds = new DataSet();
            string sql = "Update Authentication set Username='" + auth.uname + "',Password='" + auth.passw + "',ConfirmPass='" + auth.cpassw + "',ActorID'" + auth.actor_id + "' Where AuthenticationID='" + auth.auth_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteAuthenticationDB(Authentication auth)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Authentication Where AuthenticationID='" + auth.auth_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveAuthenticationDB(Authentication auth)
        {
            DataSet ds = new DataSet();
            string sql = "Select * from Authentication Where Username='" + auth.uname + "'an Password='" + auth.passw + "'";
            ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
