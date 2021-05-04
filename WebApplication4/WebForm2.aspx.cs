using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string strcontrollist;
        protected void Page_Load(object sender, EventArgs e)
        {
            strcontrollist = "<ul>";
            displaycontrol(Page);
            strcontrollist += "</ul>";
            Label2.Text = strcontrollist;
            

        }
        void displaycontrol(Control s)
        {
            foreach(Control ctlcontrol in s.Controls)
            {
                DisplayControlInfo(ctlcontrol);
                strcontrollist += "<ul>";
                displaycontrol(ctlcontrol);
                strcontrollist += "</ul>";
            }
        }
        void DisplayControlInfo(Control s)
        {
            strcontrollist += "<li> Client ID: " + s.ClientID;
            strcontrollist += "<br> Type: " + s.GetType().ToString();
            strcontrollist += "<br> ID: " + s.ID;
            strcontrollist += "<br> Naming Container: " + s.NamingContainer.ToString();
            strcontrollist += "<br> Page: " + s.Page.ToString();
            strcontrollist += "<br> Parent: " + s.Parent.ToString();
            strcontrollist += "<br> Unique ID: " + s.UniqueID;
            strcontrollist += "<p>";
        }
    }
}