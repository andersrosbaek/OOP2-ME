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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class RegisterVehicle : Window
    {
        public RegisterVehicle()
        {
            InitializeComponent();
        }

        private void btnCarModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCarColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void btnTruck_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnCar_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string type = (btnCar.IsChecked == true) ? "car" : "truck";
            string model = btnVehicleModel.Text;
            string color = btnVehicleColor.Text;
            double price = Double.Parse(inputVehiclePrice.Text);

            if (btnVehicleModel.SelectedIndex != 0 && btnVehicleColor.SelectedIndex != 0 && price > 0)
            {
                if(type == "car")
                    Cardealer.getInstance().registerCar(type, model, color, price);
                else
                    Cardealer.getInstance().registerTruck(type, model, color, price);

                lblStatus.Content = UppercaseFirst(type)+" registered!";
            }
            else
            {
                lblStatus.Content = "Check your values.";
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            GuiUtil.checkNumerical(inputVehiclePrice);
        }

        private string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
