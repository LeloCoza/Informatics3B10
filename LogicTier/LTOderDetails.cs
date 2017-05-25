using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;    //import DatabaseLayer namespace
using EntityLayer;

namespace LogicTier
{
    public class LTOderDetails
    {
        public DLOderDetails objDataLayer = new DLOderDetails();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddOderDetails(OderDetails OD)
        {
            objDataLayer.AddOderDetailsDB(OD);
        }

        public void UpdateOderDetails(OderDetails OD)
        {
            objDataLayer.UpdateOderDetailsDB(OD);
        }

        public void DeleteOderDetails(OderDetails OD)
        {
            objDataLayer.DeleteOderDetailsDB(OD);
        }

        public object RetrieveOderDetails()
        {
            return objDataLayer.RetrieveOderDetailsDB();
        }
    }
}
