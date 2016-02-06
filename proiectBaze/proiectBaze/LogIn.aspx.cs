using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using DataLayer;
using DataLayer.Models;
namespace proiectBaze
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Data.InsertProfesor("Ivan", "nicusor", "077", "calc", "student", "bbn", "tipA", "b.bogdan", "3213");
         //   Data.DeleteAdmin(3);
            
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}