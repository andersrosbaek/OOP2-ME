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
    }
}
