using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer; //import DataLayer namespace

namespace BusinessLayer
{
    public class clsBusinessLayer
    {
        public clsDataLayer objDataLayer = new clsDataLayer();  //create a DataLayer object
        
        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddActor(int actor_id, string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address)
        {
            objDataLayer.AddActorDB(actor_id, actor_name, actor_surname, actor_DOB, actor_cell, actor_email, actor_address);
        }

        public void UpdateActor(int actor_id, string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address)
        {
            objDataLayer.UpdateActorDB(actor_id, actor_name, actor_surname, actor_DOB, actor_cell, actor_email, actor_address);
        }

        public void DeleteActor(int actor_id)
        {
            objDataLayer.DeleteActorDB(actor_id);
        }

        public object RetrieveActor()
        {
            return objDataLayer.RetrieveActorDB();
        }
    }
}
