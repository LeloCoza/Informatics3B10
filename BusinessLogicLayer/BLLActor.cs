﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//import DataAccessLayer
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLActor
    {
        public DALActor objDataLayer = new DALActor();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddActor(string actor_name, string actor_surname, string actor_DOB, string actor_cell, string actor_email, string actor_address)
        {
            objDataLayer.AddActorDB(actor_name, actor_surname, actor_DOB, actor_cell, actor_email, actor_address);
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
