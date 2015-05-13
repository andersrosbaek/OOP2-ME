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
        List<VehicleTruck> trucks = Cardealer.getInstance().getTrucks();
        public int indexInDropdown = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            ViewCarsDropdown.Items.Add("- Pick a car -");

            foreach (VehicleCar c in cars)
            {
                ViewCarsDropdown.Items.Add(c.Color + " " + c.Model);
            }

            if (indexInDropdown > 0) 
            {
                ChangeItems();
            }
        }

        protected void ViewCarsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexInDropdown = ViewCarsDropdown.SelectedIndex;

            Response.Redirect("ViewCars.aspx");
        }

        private void ChangeItems() {
            ModelLabel.Text = cars[indexInDropdown - 1].Model;
            ColorLabel.Text = cars[indexInDropdown - 1].Color;
            PriceLabel.Text = cars[indexInDropdown - 1].Price + "";
        }
    }
}