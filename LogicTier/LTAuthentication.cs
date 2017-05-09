using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DatabaseLayer;    //import DatabaseLayer

namespace LogicTier
{
    class LTAuthentication
    {
        public DLAuthentication objDataLayer = new DLAuthentication();  //create a DataLayer object

        //create, select, update, delete functions to update from presentation layer to database layer
        public void AddAuthentication(string uname, string password, string cpassword)
        {
            objDataLayer.AddAuthenticationDB(uname, password, cpassword);
        }

        public void UpdateAuthentication(int authentication_id, string uname, string password, string cpassword)
        {
            objDataLayer.UpdateAuthenticationDB(authentication_id, uname, password, cpassword);
        }

        public void DeleteAuthentication(int authentication_id)
        {
            objDataLayer.DeleteAuthenticationDB(authentication_id);
        }

        public object RetrieveAuthentication()
        {
            return objDataLayer.RetrieveAuthenticationDB();
        }
    }
}
