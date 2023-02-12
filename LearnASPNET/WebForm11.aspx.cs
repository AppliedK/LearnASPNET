using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void SumButton_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToInt32( firstnumTB.Text);
            var n2 =Convert.ToInt32( secondnumTB.Text);
            var sum = n1 + n2;
            Response.Write(sum);

        }

        protected void Result_Click(object sender, EventArgs e)
        {
            var n1 = Convert.ToInt32(firstnumTB.Text);
            var n2 = Convert.ToInt32(secondnumTB.Text);

            Response.Redirect("~/WebForm12.aspx?first="+n1+"&second="+n2);
        }
    }
}