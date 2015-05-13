using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Domain;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cardealer.getInstance().registerBusinessCustomer("Birkevej 93, 9493 Saltum", 32739375, 020993029, "Freja P. Kristoffersen", 2, "Integra Investment Service", true);
            Cardealer.getInstance().registerBusinessCustomer("Præstevænget 44, 1502 København V", 91374843, 020993029, "Andreas M. Mathiesen", 2, "Monk House Sales", true);
            Cardealer.getInstance().registerBusinessCustomer("Plouggårdsvej 31, 7960 Karby", 12948275, 020993029, "Christine L. Nygaard", 2, "L' Fish", false);

            Cardealer.getInstance().registerPrivateCustomer("Østerøvej 2, 5100 Odense C", 71777351, "Katrine A. Sørensen", new DateTime(1988, 8, 14), "Female", false);
            Cardealer.getInstance().registerPrivateCustomer("Strandalléen 2, 3790 Hasle", 22521293, "Pernille A. Paulsen", new DateTime(1993, 2, 28), "Female", false);
            Cardealer.getInstance().registerPrivateCustomer("Strandvej 51, 1271 København K", 44291733, "John O. Klausen", new DateTime(1968, 7, 8), "Male", true);

            Cardealer.getInstance().registerCar("car", "Toyota", "blue", 200000.0);
            Cardealer.getInstance().registerCar("car", "BMW", "green", 140000.0);
            Cardealer.getInstance().registerCar("car", "Audi", "yellow", 125000.0);

            Cardealer.getInstance().registerTruck("truck", "VW", "red", 450000.0);
            Cardealer.getInstance().registerTruck("truck", "VW", "green", 510000.0);
            Cardealer.getInstance().registerTruck("truck", "Mazda", "yellow", 230000.0);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCars.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTrucks.aspx");
        }
    }
}