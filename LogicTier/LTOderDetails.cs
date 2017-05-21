using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;    //import DatabaseLayer namespace

namespace LogicTier
{
    public class LTOderDetails
    {
        public DLOderDetails objDataLayer = new DLOderDetails();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddOderDetails(int oderDet_id, int size, int num_of_items, int orderid, int prodid)
        {
            objDataLayer.AddOderDetailsDB(oderDet_id, size, num_of_items, orderid, prodid);
        }

        public void UpdateOderDetails(int oderDet_id, int size, int num_of_items, int orderid, int prodid)
        {
            objDataLayer.UpdateOderDetailsDB(oderDet_id, size, num_of_items, orderid, prodid);
        }

        public void DeleteOderDetails(int oderDet_id)
        {
            objDataLayer.DeleteOderDetailsDB(oderDet_id);
        }

        public object RetrieveOderDetails()
        {
            return objDataLayer.RetrieveOderDetailsDB();
        }
    }
}
