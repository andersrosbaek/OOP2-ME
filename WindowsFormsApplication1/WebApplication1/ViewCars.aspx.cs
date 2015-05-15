using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        List<VehicleCar> cars = Cardealer.getInstance().getCars();

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("");

            foreach (VehicleCar c in cars) {
                DropDownList1.Items.Add(c.VehicleCarID + "");
            }

            GridView1.DataSource = cars;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainMenu.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Cardealer.getInstance().removeCar(int.Parse(DropDownList1.SelectedValue));

            Response.Redirect("ViewCars.aspx");
        }

    }
}