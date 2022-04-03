using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

namespace x52.ASPXButtonClass
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            ASPxButton button = new ASPxButton();
            button.ID = "MyButton4";
            button.Text = "Show Alert4 - Αυτό το κουμπί έγινε με κώδικα μόνο.";
            button.AutoPostBack = false;
            button.ClientSideEvents.Click = "function(s, e) {alert('Hello, world');}";
            // Add the created control to the page
            Page.Form.Controls.Add(button);


        }
    }
}