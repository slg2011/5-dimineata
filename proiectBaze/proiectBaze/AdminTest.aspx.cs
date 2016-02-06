using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;

namespace proiectBaze
{
    public partial class AdminTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            
            var login = BusinessLayer.Business.GetUsers();
            foreach(var n in login)
            {
                if(Login1.UserName == n.username && Login1.Password == n.parola)
                {
                    Response.Redirect("~/Loogin.aspx");
                }
            }
        }
    }
}