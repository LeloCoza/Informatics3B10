﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            objLogic = new LTActor();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            objLogic = new LTActor();

            objLogic.AddActor(txtName.Text, txtSurname.Text, txtDOB.Text, txtCellphone.Text, txtEmail.Text, txtAddress.Text);

            lblRegister.Visible = true;
            // Response.Write("You have been registered!");
            clear();
            
            //Response.Redirect("Register.aspx");
            
        }
        
        //clears all textboxes after data is submitted.
        public void clear()
        {
            lblRegister.Visible = true;

            txtName.Text = "";
            txtSurname.Text = "";
            txtDOB.Text = "";
            txtCellphone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
           // lblRegister.Visible = true;
        }
    }
}