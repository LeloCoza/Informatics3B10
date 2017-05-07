using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace FishLandApp
{
    public partial class Register : System.Web.UI.Page
    {
        clsBusinessLayer objLogic;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

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