using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseLayer
{
    public class DLActor
    {
        public DB db;
        public DLActor()
        {
            db = new DB();
        }

        //methods to execute Insert/Update/Delete commands using SQLCOMMAND
        public void AddActorDB(Actor actor)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Actor (Name, Surname, DateOfBirth, Cellphone, Email, Address) VALUES ('" + actor.actor_name + "','" + actor.actor_surname + "','" + actor.actor_DOB + "','" + actor.actor_cell + "','" + actor.actor_email + "','" + actor.actor_address + "','" + actor.actorid_id + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }

        /*public void AddActorDB(string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address, int actorid_id)
        {
            DataSet ds = new DataSet();
            string sql = "INSERT into Actor (Name, Surname, DateOfBirth, Cellphone, Email, Address) VALUES ('" + actor_name + "','" + actor_surname + "','" + actor_DOB + "','" + actor_cell + "','" + actor_email + "','" + actor_address + "','" + actorid_id + "')";
            db.InsertUpdateDeleteSQLString(sql);
        }*/

        /*public void UpdateActorDB(int actor_id, string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address, int actorid_id)
        {
            DataSet ds = new DataSet();
            string sql = "Update Actor set Name='" + actor_name + "',Surname='" + actor_surname + "',DateOfBirth='" + actor_DOB + "'Cellphone='" + actor_cell + "',Email='" + actor_email + "',Address='" + actor_address + "',ActorIdentityID='" + actorid_id + "' Where ActorID='" + actor_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }*/

        public void UpdateActorDB(Actor actor)
        {
            DataSet ds = new DataSet();
            string sql = "Update Actor set Name='" + actor.actor_name + "',Surname='" + actor.actor_surname + "',DateOfBirth='" + actor.actor_DOB + "',Cellphone='" + actor.actor_cell + "',Email='" + actor.actor_email + "',Address='" + actor.actor_address + "',ActorIdentityID='" + actor.actorid_id + "' Where ActorID='" + actor.actor_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }

        public void DeleteActorDB(Actor actor)
        {
            DataSet ds = new DataSet();
            string sql = "Delete from Actor Where ActorID='" + actor.actor_id + "' ";
            db.InsertUpdateDeleteSQLString(sql);
        }


        //this method uses SQLCOMMAND and DATASET to load records
        //and pass them to the BusinessLayer
        public object RetrieveActorDB()
        {
            string sql = "Select * from Actor order by ActorID";
            DataSet ds = (DataSet)db.ExecuteSqlString(sql);
            return ds;
        }

    }
}
