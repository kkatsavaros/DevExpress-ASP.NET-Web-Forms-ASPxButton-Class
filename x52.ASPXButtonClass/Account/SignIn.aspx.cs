using System;
using DevExpress.Web;
using x52.ASPXButtonClass.Model;

namespace x52.ASPXButtonClass {
    public partial class SignInModule : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void SignInButton_Click(object sender, EventArgs e) {
            FormLayout.FindItemOrGroupByName("GeneralError").Visible = false;
            if(ASPxEdit.ValidateEditorsInContainer(this)) {
                // DXCOMMENT: You Authentication logic
                if(!AuthHelper.SignIn(UserNameTextBox.Text, PasswordButtonEdit.Text)) {
                    GeneralErrorDiv.InnerText = "Invalid login attempt.";
                    FormLayout.FindItemOrGroupByName("GeneralError").Visible = true;
                }
                else
                    Response.Redirect("~/");
            }
        }
    }
}