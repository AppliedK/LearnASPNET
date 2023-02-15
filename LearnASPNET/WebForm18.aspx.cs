using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm18 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_PreRender()
        {
            try
            {
                foreach (BaseValidator valCtrl in Page.Validators)
                {
                    WebControl webControl = (WebControl)Page.FindControl(valCtrl.ControlToValidate);
                    if (!valCtrl.IsValid)
                    {
                        webControl.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        webControl.BackColor = System.Drawing.Color.White;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.StackTrace);
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                Response.Write("VALIDATED");
            }
            else
            {
                Response.Write("INVALID");
            }
        }

        protected void PasswordLengthValidate(object source, ServerValidateEventArgs args)
        {
            if ((args.Value).ToString().Length >= 8 && (args.Value).ToString().Length <= 12)
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