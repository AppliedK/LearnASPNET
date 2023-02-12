using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(1, 4);
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Server.MapPath("~/Test"));
            System.IO.FileInfo[] fis = di.GetFiles();
            RandomImg.ImageUrl = "~/Test/" + fis[number].Name;
        }
    }
}