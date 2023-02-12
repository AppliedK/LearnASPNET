using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpBrowserCapabilities browser = Request.Browser;
            //Response.Write(browser.Browser);
            //browser.AddBrowser("Chrome");
            var listBrowsers = browser.Browsers;
            listBrowsers.Sort();
            foreach (var brw in listBrowsers)
            {
                Response.Write(brw.ToString());
            }
        }
    }
}