using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DatabaseLayer;    //import DatabseLayer
using EntityLayer;      //import EntityLayer

namespace LogicTier
{
    public class LTActor_Identity
    {
        public DLActor_Identity objDataLayer = new DLActor_Identity();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddActorId(Actor_Identity actor_identity)
        {
            objDataLayer.AddActorIdDB(actor_identity);
        }

        public void UpdateActorId(Actor_Identity actor_identity)
        {
            objDataLayer.UpdateActorIdDB(actor_identity);
        }

        public void DeleteActorId(Actor_Identity actor_identity)
        {
            objDataLayer.DeleteActorIdDB(actor_identity);
        }

        public object RetrieveActorId()
        {
            return objDataLayer.RetrieveActorIdDB();
        }
    }
}
