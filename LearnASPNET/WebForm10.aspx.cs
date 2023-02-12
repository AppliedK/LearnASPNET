using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var c = Page.Controls.Count;
            if (c > 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < c; i++)
                {
                    sb.Append(Page.Controls[i].GetType().Name + "-");
                }
                FruitTextBox.Text = sb.ToString();
            }

        }
    }
}