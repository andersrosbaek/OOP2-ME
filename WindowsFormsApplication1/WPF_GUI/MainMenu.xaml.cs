using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Domain;

namespace WPF_GUI
{
    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Window
    {
        public MainScreen()
        {
            InitializeComponent();
            FillDummyItems();
        }

        private static void FillDummyItems()
        {
            Cardealer.getInstance().registerBusinessCustomer("Birkevej 93, 9493 Saltum", 32739375, 020993029, "Freja P. Kristoffersen", 2, "Integra Investment Service", true);
            Cardealer.getInstance().registerBusinessCustomer("Præstevænget 44, 1502 København V", 91374843, 020993029, "Andreas M. Mathiesen", 2, "Monk House Sales", true);
            Cardealer.getInstance().registerBusinessCustomer("Plouggårdsvej 31, 7960 Karby", 12948275, 020993029, "Christine L. Nygaard", 2, "L' Fish", false);

            Cardealer.getInstance().registerPrivateCustomer("Østerøvej 2, 5100 Odense C", 71777351, "Katrine A. Sørensen", new DateTime(1988, 8, 14), "Female", false);
            Cardealer.getInstance().registerPrivateCustomer("Strandalléen 2, 3790 Hasle", 22521293, "Pernille A. Paulsen", new DateTime(1993, 2, 28), "Female", false);
            Cardealer.getInstance().registerPrivateCustomer("Strandvej 51, 1271 København K", 44291733, "John O. Klausen", new DateTime(1968, 7, 8), "Male", true);

            Cardealer.getInstance().registerVehicle("car", "Toyota", "blue", 200000.0);
            Cardealer.getInstance().registerVehicle("car", "BMW", "green", 140000.0);
            Cardealer.getInstance().registerVehicle("car", "Audi", "yellow", 125000.0);

            Cardealer.getInstance().registerVehicle("truck", "VW", "red", 450000.0);
            Cardealer.getInstance().registerVehicle("truck", "VW", "green", 510000.0);
            Cardealer.getInstance().registerVehicle("truck", "Mazda", "yellow", 230000.0);
        }

        private void gotoRegisterCustomer(object sender, RoutedEventArgs e)
        {
            RegisterCustomer regCust = new RegisterCustomer();
            regCust.Show();
        }

        private void gotoExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void gotoRegisterCar(object sender, RoutedEventArgs e)
        {
            RegisterVehicle regVechicle = new RegisterVehicle();
            regVechicle.Show();
        }

        private void gotoRegisterContract(object sender, RoutedEventArgs e)
        {
            RegisterContract regContract = new RegisterContract();
            regContract.Show();
        }

        private void gotoCustomerRegistry(object sender, RoutedEventArgs e)
        {
            CustomerRegistry custReg = new CustomerRegistry();
            custReg.Show();
        }

        private void gotoVehicleRegitry(object sender, RoutedEventArgs e)
        {
            VehicleRegistry vechReg = new VehicleRegistry();
            vechReg.Show();
        }

        private void gotoContractList(object sender, RoutedEventArgs e)
        {
            ContractRegistry contractList = new ContractRegistry();
            contractList.Show();
        }
    }
}
