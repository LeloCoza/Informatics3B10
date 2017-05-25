using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;    //import DatabaseLayer
using EntityLayer;

namespace LogicTier
{
    public class LTOder
    {
        public DLOder objDataLayer = new DLOder();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddOder(Oder oder)
        {
            objDataLayer.AddOderDB(oder);
        }

        public void UpdateOder(Oder oder)
        {
            objDataLayer.UpdateOderDB(oder);
        }

        public void DeleteOder(Oder oder)
        {
            objDataLayer.DeleteOderDB(oder);
        }

        public object RetrieveOder()
        {
            return objDataLayer.RetrieveOderDB();
        }
    }
}
