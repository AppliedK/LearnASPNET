using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm20 : System.Web.UI.Page
    {
        DateTime start;
        protected void Page_Load(object sender, EventArgs e)
        {
            dateLbl.Text = DateTime.Now.ToString();
            if (!Page.IsPostBack)
            {
               Session["start"] = DateTime.Now;
            }
        }

        protected void TimeValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime s =(DateTime) Session["start"];
            if (s.AddSeconds(10) > DateTime.Now)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}