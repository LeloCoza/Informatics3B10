using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicTier;
using EntityLayer;

namespace FishLandApp
{
    public partial class Login : System.Web.UI.Page
    {
        //create and instantiate objects to use
        Actor actor;
        LTActor lt_actor = new LTActor();

        Authentication auth = new Authentication();
        LTAuthentication lt_auth = new LTAuthentication();

        ActorIdentity actoridentity;
        LTActor_Identity lt_actoridentity = new LTActor_Identity();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtUsername.Text;
            string passw = txtPassword.Text;
            
            //by default, everyone that uses the system is a customer
            actor.ActorIdentityID = 1;
            int i = actor.ActorIdentityID;      //declare a local variable to use in the if-statements

            lt_auth.RetrieveAuthentication(auth);
           
            if (uname == auth.Username && passw == auth.Password)
            {
                Response.Redirect("Customer.aspx");
            }
            else if(i == 2 && (uname == auth.Username && passw == auth.Password))
            {
                Response.Redirect("Admin.aspx");
            }
        }
    }
}