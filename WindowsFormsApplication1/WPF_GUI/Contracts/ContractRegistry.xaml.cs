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
    /// Interaction logic for CustomerRegistry.xaml
    /// </summary>
    public partial class ContractRegistry : Window
    {
        List<ContractSale> sales = Cardealer.getInstance().getSalesContracts();
        List<ContractLeasing> leasing = Cardealer.getInstance().getLeasingContracts();

        public ContractRegistry()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ContractGrid.ItemsSource = sales;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            ContractGrid.ItemsSource = leasing;
        }
    }
}
