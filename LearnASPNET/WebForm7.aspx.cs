using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CityDDL.DataSource = CitiesList();
                CityDDL.DataBind();
            }

        }
        private List<string> CitiesList()
        {
            List<string> cities = new List<string>();
            cities.Add("Agra");
            cities.Add("Patna");
            cities.Add("Goa");
            cities.Add("Shimla");
            cities.Add("Muzaffarnagar");
            cities.Add("Delhi");
            cities.Add(" Select City");
            
            cities.Sort();
            return cities;
        }
    }
}