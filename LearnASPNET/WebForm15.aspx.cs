using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string apppath = Request.ApplicationPath;
            string[] files= System.IO.Directory.GetFiles(Server.MapPath(apppath),"*.aspx");
            Random rnd = new Random();
            HyperLink1.NavigateUrl= files[rnd.Next(1, files.Length)]; 
        }
    }
}