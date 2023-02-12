using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.FindControl("prevTB") != null)
            {
                var txtBox = (TextBox)PreviousPage.FindControl("prevTB");
                Response.Write(txtBox.Text);
            }
        }
    }
}