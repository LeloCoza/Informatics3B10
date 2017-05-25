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
            //actor.ActorIdentityID = 1;
            int actoridentityId = 1;
            //lt_auth.AddAuthentication(auth);

            lt_auth.RetrieveAuthentication();

            if(uname = auth.Username)

            

        }
    }
}