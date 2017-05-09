using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;    //import DatabaseLayer

namespace LogicTier
{
    public class LTOder
    {
        public DLOder objDataLayer = new DLOder();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddOder(string status, string t_amount, string date)
        {
            objDataLayer.AddOderDB(status, t_amount, date);
        }

        public void UpdateOder(int oder_id, string status, string t_amount, string date)
        {
            objDataLayer.UpdateOderDB(oder_id, status, t_amount, date);
        }

        public void DeleteOder(int oder_id)
        {
            objDataLayer.DeleteOderDB(oder_id);
        }

        public object RetrieveOder()
        {
            return objDataLayer.RetrieveOderDB();
        }
    }
}
