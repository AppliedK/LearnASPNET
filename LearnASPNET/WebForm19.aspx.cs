using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm19 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void CommentLengthValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.Length>0 && args.Value.Length<20)
            {
                args.IsValid= true;
            }
            else
            {
                args.IsValid=false;
            }
        }
    }
}