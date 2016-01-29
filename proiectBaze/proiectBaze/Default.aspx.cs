using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer.Models;
using DataLayer;
using BusinessLayer;
namespace proiectBaze
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<LogInn> users = Business.GetUsers();
            GridView.DataSource = users;
            GridView.DataBind();
        }
    }
}