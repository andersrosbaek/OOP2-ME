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
            Cardealer.getInstance().registerBusinessCustomer("Adresse", 20304050, 020993029, "Contact", 2, "Company");
            Cardealer.getInstance().registerBusinessCustomer("Adresse", 20304050, 020993029, "Contact", 2, "Company");
            Cardealer.getInstance().registerBusinessCustomer("Adresse", 20304050, 020993029, "Contact", 2, "Company");

            Cardealer.getInstance().registerPrivateCustomer("Adresse", 20304050, "Name", new DateTime(2020, 12, 20), "Male");
            Cardealer.getInstance().registerPrivateCustomer("Adresse", 20304050, "Name", new DateTime(2020, 12, 20), "Male");
            Cardealer.getInstance().registerPrivateCustomer("Adresse", 20304050, "Name", new DateTime(2020, 12, 20), "Male");

            Cardealer.getInstance().registerVehicle("car", "Toyota", "blue", 20.0);
            Cardealer.getInstance().registerVehicle("car", "BMW", "green", 20.0);
            Cardealer.getInstance().registerVehicle("car", "Audi", "yellow", 20.0);

            Cardealer.getInstance().registerVehicle("truck", "VW", "red", 20.0);
            Cardealer.getInstance().registerVehicle("truck", "VW", "green", 20.0);
            Cardealer.getInstance().registerVehicle("truck", "Mazda", "yellow", 20.0);
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
    }
}
