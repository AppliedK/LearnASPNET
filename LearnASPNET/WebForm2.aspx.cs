using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void InfoButton_Click(object sender, EventArgs e)
        {
            Response.Write(HostingEnvironment.ApplicationPhysicalPath +"<br/>");
            Response.Write(HostingEnvironment.ApplicationVirtualPath +"<br/>");
            Response.Write(HostingEnvironment.SiteName +"<br/>");
            Response.Write(HostingEnvironment.ApplicationID +"<br/>");
            Response.Write(HostingEnvironment.IsDevelopmentEnvironment.ToString() +"<br/>");
            Response.Write(HostingEnvironment.IsHosted.ToString() +"<br/>");
            Response.Write(HostingEnvironment.MapPath("/") +"<br/>");
            var host = HostingEnvironment.ApplicationHost;
            string virtualPath = host.GetVirtualPath();
            string physicalPath = host.GetPhysicalPath();
            Response.Write(virtualPath + "<br/>");
            Response.Write(physicalPath + "<br/>");
            var vpp = HostingEnvironment.VirtualPathProvider;
            Response.Write(vpp.DirectoryExists("~/Test").ToString() + "<br/>");
            Response.Write(vpp.DirectoryExists("~/Tests").ToString() + "<br/>");
            Response.Write(vpp.GetFile("~/TextFile1.txt").VirtualPath + "<br/>");
            Response.Write(vpp.GetFile("~/TextFile2.txt").VirtualPath + "<br/>");
            Response.Write(vpp.FileExists("~/TextFile1.txt").ToString() + "<br/>");
            Response.Write(vpp.FileExists("~/TextFile2.txt").ToString() + "<br/>");
        }
    }
}