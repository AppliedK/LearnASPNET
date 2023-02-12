using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int sum = 0;
            NameValueCollection queries = Request.QueryString;
            for (int i = 0; i < queries.Count; i++)
            {
                string[] kvp = queries.GetValues(i);
                sum += Convert.ToInt32( kvp[0]);
            }
            QueryTB.Text = sum.ToString();  
        }
    }
}