using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer; //import DataLayer namespace

namespace BusinessLayer
{
    class BLActorIdentity
    {
        public BLActorIdentity objDataLayer = new BLActorIdentity();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddActorId(string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address)
        {
            objDataLayer.AddActorIdDB(actor_name, actor_surname, actor_DOB, actor_cell, actor_email, actor_address);
        }

        public void UpdateActorId(int actor_id, string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address)
        {
            objDataLayer.UpdateActorIdDB(actor_id, actor_name, actor_surname, actor_DOB, actor_cell, actor_email, actor_address);
        }

        public void DeleteActorId(int actor_id)
        {
            objDataLayer.DeleteActorIdDB(actor_id);
        }

        public object RetrieveActorId()
        {
            return objDataLayer.RetrieveActorIdDB();
        }
    }
}
