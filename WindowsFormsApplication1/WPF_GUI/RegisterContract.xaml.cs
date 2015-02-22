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

            object[] privateCustomers = Cardealer.getInstance().getPrivateCustomers();
            object[] businessCustomers = Cardealer.getInstance().getBusinessCustomers();
            object[] cars = Cardealer.getInstance().getCars();
            object[] trucks = Cardealer.getInstance().getTrucks();

            
            foreach(object name in privateCustomers)
            {
                if(name != null)
                {
                    btnCustomer.Items.Add(name.GetType());
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
