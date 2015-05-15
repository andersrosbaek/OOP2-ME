using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        List<VehicleTruck> trucks = Cardealer.getInstance().getTrucks();

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("");

            foreach (VehicleTruck t in trucks)
            {
                DropDownList1.Items.Add(t.VehicleTruckID + "");
            }

            GridView1.DataSource = trucks;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Cardealer.getInstance().removeTruck(int.Parse(DropDownList1.SelectedValue));

            Response.Redirect("ViewTrucks.aspx");
        }
    }
}