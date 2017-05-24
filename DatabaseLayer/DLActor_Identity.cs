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
    public class DLActor_Identity
    {
        public DB db;
        public DLActor_Identity()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddActorIdDB(Actor_Identity actor_identity)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into ActorIdentity (Description) VALUES ('" + actor_identity.description +  "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        
        public void UpdateActorIdDB(Actor_Identity actor_identity)
        {
            DataSet ds = new DataSet();
            string sql = "Update ActorIdentity set Description='" + actor_identity.description + "' Where ActorIdentityID='" + actor_identity.actorid_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        
        public void DeleteActorIdDB(Actor_Identity actor_identity)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from ActorIdentity Where ActorIdentityID='" + actor_identity.actorid_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveActorIdDB()
        {
            string sql = "Select * from ActorIdentity order by ActorIdentityID";
            DataSet ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }
    }
}
