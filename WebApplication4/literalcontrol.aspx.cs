using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class literalcontrol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label l1;
            for(int counter=0;counter<30;counter++)
            {
                l1 = new Label();
                l1.Text = "hello";
                Controls.Add(l1);
            }
            Button b1;
            for (int counter = 0; counter < 30; counter++)
            {
                b1 = new Button();
                b1.Text = "hello";
                form1.Controls.Add(b1);
            }
        }
    }
}