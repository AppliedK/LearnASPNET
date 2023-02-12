using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! Page.IsPostBack)
            {
                ddlCities.Items.Clear();
                ddlCities.DataSource = GetCities();
                ddlCities.DataBind();
            }
        }

        private List<string> GetCities()
        {
            List<string> list = new List<string>();
            list.Add("Agra");
            list.Add("Pune");
            list.Add("Goa");
            list.Add("Jaipur");
            list.Add("Patna");
            list.Sort();
            return list;
        }
        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = ddlCities.SelectedIndex;
            string t = ddlCities.SelectedItem.Text;
            string v = ddlCities.SelectedValue;
            Response.Write($"<h1>Index: {i}, Text: {t}, Value: {v}</h1>");
        }
    }
}