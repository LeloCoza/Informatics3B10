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
    public partial class Register : System.Web.UI.Page
    {
        //every firt time registrar is a customer by default
        //private const int DefaultActorIdentityId = 1;

        //create and instantiate objects to use
        Actor actor;
        LTActor lt_actor = new LTActor();
        Authentication auth = new Authentication();
        LTAuthentication lt_auth = new LTAuthentication();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            actor.Name = txtName.Text;
            actor.Surname = txtSurname.Text;
            actor.DateOfBirth = (DateTime)Convert.ChangeType(txtDOB.Text, typeof(DateTime));
            actor.Cellphone = txtCellphone.Text;
            auth.Username = txtUsername.Text;
            auth.Password = txtPassword.Text;
            auth.ConfirmPass = txtCPassword.Text;
            actor.Email = txtEmail.Text;
            actor.Address = txtAddress.Text;
            actor.ActorIdentityID = 1;

            string s = lt_actor.AddActor(actor);
            string ss = lt_auth.AddAuthentication(auth);

            //describes the below registra as a customer by default
            //objAI.AddActorId("Customer");x

            //creates a user/actor record in table Actor of database FishLandDB
            //objA.AddActor(txtName.Text, txtSurname.Text, txtDOB.Text, txtCellphone.Text, txtEmail.Text, txtAddress.Text, objAI.);

            //stores Authentication values in Authentication table in the database when btnRegister is clicked.
            //objAu.AddAuthentication(txtUsername.Text, txtPassword.Text, txtCPassword.Text);
            
            lblRegister.Visible = true;     //displays message when user/actor has registered successfully.
            clear();

            //stores Authentication data into database
            //objLogic2.AddAuthentication(txtUsername.Text, txtPassword.Text, txtCPassword.Text);

            // Response.Write("You have been registered!");
                        
            //Response.Redirect("Register.aspx");
            
        }
        
        //clears all textboxes after data is submitted.
        public void clear()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtDOB.Text = "";
            txtCellphone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }
    }
}