using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            int content_length;
            HttpFileCollection files = Request.Files;

            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFile file = files.Get(i);
                content_length = file.ContentLength;
                if (content_length>0)
                {
                    Response.Write("<h3>"+ file.ContentType+"</h3>");
                    Response.Write("<h3>"+ file.FileName+"</h3>");
                    Response.Write("<h3>"+ file.GetType().ToString()+"</h3>");
                }
            }
        }
    }
}