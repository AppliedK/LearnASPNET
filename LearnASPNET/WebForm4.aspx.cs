using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void FirstButton_Click(object sender, EventArgs e)
        {
            Response.Write(sender.GetType().Name);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("X = "+e.X.ToString() + " Y = " + e.Y.ToString());
        }
    }
}