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
    /// Interaction logic for RegisterContract.xaml
    /// </summary>
    public partial class RegisterContract : Window
    {
        public RegisterContract()
        {
            InitializeComponent();

            List<PrivateCustomer> privateCustomers = Cardealer.getInstance().getPrivateCustomers();
            List<BusinessCustomer> businessCustomers = Cardealer.getInstance().getBusinessCustomers();
            List<Car> cars = Cardealer.getInstance().getCars();
            List<Truck> trucks = Cardealer.getInstance().getTrucks();


            foreach (PrivateCustomer name in privateCustomers)
            {
                if(name != null)
                {
                    btnCustomer.Items.Add(name.Name);
                }
                
            }

            foreach (BusinessCustomer company in businessCustomers)
            {
                if (company != null)
                {
                    btnCompany.Items.Add(company.NameOfCompany);
                }

            }

            foreach (Car model in cars)
            {
                if (model != null)
                {
                    bntVehicleModel.Items.Add(model.Model);
                }

            }

            foreach (Truck model in trucks)
            {
                if (model != null)
                {
                    bntCompanyVehicleModel.Items.Add(model.Model);
                }

            }
            
        }

        private void SaleRadioButton(object sender, RoutedEventArgs e)
        {
            SalesGrid.Visibility = System.Windows.Visibility.Visible;
            LeaseGrid.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void LeaseRadioButton(object sender, RoutedEventArgs e)
        {
            LeaseGrid.Visibility = System.Windows.Visibility.Visible;
            SalesGrid.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void createSalesContract(object sender, RoutedEventArgs e)
        {

        }

        private void createLeasingContrac(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
