using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LogicTier;

namespace FishLandApp
{
    public partial class Register : System.Web.UI.Page
    {
        //create objects for the three classes
        LTActor_Identity objAI;
        LTActor objA;
        LTAuthentication objAu;
        private const int DefaultActorIdentityId = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            objAI = new LTActor_Identity();
            objA = new LTActor();
            objAu = new LTAuthentication();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //instantiate objects for the three classes 
            objAI = new LTActor_Identity();
            objA = new LTActor();
            objAu = new LTAuthentication();


            //describes the below registra as a customer by default
            //objAI.AddActorId("Customer");x

            object a = objA.GetForeignKey();
            int i = (int)Convert.ChangeType(a, typeof(int));
            
            //creates a user/actor record in table Actor of database FishLandDB
            objA.AddActor(txtName.Text, txtSurname.Text, txtDOB.Text, txtCellphone.Text, txtEmail.Text, txtAddress.Text, objAI.);

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