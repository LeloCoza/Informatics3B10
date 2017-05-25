using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DatabaseLayer;    //import DatabaseLayer
using EntityLayer;      //import EntityLayer

namespace LogicTier
{
    public class LTActor 
    {
        public DLActor objDataLayer = new DLActor();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddActor(Actor actor)
        {
            objDataLayer.AddActorDB(actor);
        }

        public void UpdateActor(Actor actor)
        {
            objDataLayer.UpdateActorDB(actor);
        }

        public void DeleteActor(Actor actor)
        {
            objDataLayer.DeleteActorDB(actor);
        }

        public object RetrieveActor()
        {
            return objDataLayer.RetrieveActorDB();
        }
    }
}
