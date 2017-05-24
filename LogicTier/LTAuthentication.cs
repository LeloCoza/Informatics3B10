using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;      //import EntityLayer
using DatabaseLayer;    //import DatabaseLayer

namespace LogicTier
{
    public class LTAuthentication
    {
        public DLAuthentication objDataLayer = new DLAuthentication();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddAuthentication(Authentication auth)
        {
            objDataLayer.AddAuthenticationDB(auth);
        }

        public void UpdateAuthentication(Authentication auth)
        {
            objDataLayer.UpdateAuthenticationDB(auth);
        }

        public void DeleteAuthentication(Authentication auth)
        {
            objDataLayer.DeleteAuthenticationDB(auth);
        }

        public object RetrieveAuthentication()
        {
            return objDataLayer.RetrieveAuthenticationDB();
        }
    }
}
