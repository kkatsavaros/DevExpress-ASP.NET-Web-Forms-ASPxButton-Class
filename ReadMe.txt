DevExpress ASP.NET Web Forms: ASPxButton class
with code



In that project i use DevExpress ASP.NET Web Forms: ASPxButton class to make and use a button.



1. Firstly i have started a new project  "DevExpress 21.2 Web App Template Gallery". 

2. I add a Web Form with Master page.

3. Then i have added ASPxButton Control.

4. The code :

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



Katsavaros Konstantinos






