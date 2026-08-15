using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_2
{
    public partial class Contact : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Thank You! Your enquiry has been submitted.";

            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtMessage.Text = "";
            ddlService.SelectedIndex = 0;
        }
    }
}