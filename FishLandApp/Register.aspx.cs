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
        LTActor objLogic;
       // LTAuthentication objLogic2;
        protected void Page_Load(object sender, EventArgs e)
        {
            objLogic = new LTActor();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            objLogic = new LTActor();
           // objLogic2 = new LTAuthentication();

            //creates a user/actor record in table Actor of database FishLandDB
           // objLogic.AddActor(txtName.Text, txtSurname.Text, txtDOB.Text, txtCellphone.Text, txtEmail.Text, txtAddress.Text);

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