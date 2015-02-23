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
    public partial class RegisterCustomer : Window
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void CheckNumberOnly(object sender, TextChangedEventArgs e)
        {
            GuiUtil.checkNumerical(sender as TextBox);
        }

        private void PrivateRadiobutton(object sender, RoutedEventArgs e)
        {
            PrivateGrid.Visibility = System.Windows.Visibility.Visible;
            BusinessGrid.Visibility = System.Windows.Visibility.Collapsed; 
        }

        private void BusinessRadiobutton(object sender, RoutedEventArgs e)
        {
            PrivateGrid.Visibility = System.Windows.Visibility.Collapsed;
            BusinessGrid.Visibility = System.Windows.Visibility.Visible; 
        }

        private void CreatePrivateCustomer(object sender, RoutedEventArgs e)
        {
            string sex = "";
            if(Private_Male.IsChecked == true)
            {
                sex = "Male";
            }
            else if(Private_Female.IsChecked == true){
                sex = "Female";
            }


            DateTime date;
            date = (DateTime) Private_Date.SelectedDate;

            string address  = Private_Address.Text;
            int phone       = Int32.Parse(Private_Number.Text);
            string name     = Private_Name.Text;

            Cardealer.getInstance().registerPrivateCustomer(address, phone, name, date, sex);

            
        }

        private void CreateBusinessCustomer(object sender, RoutedEventArgs e)
        {
            string address          = Business_Address.Text;
            int phone              = Int32.Parse(Business_Number.Text);
            string name             = Private_Name.Text;
            int seNumber            = Int32.Parse(Business_SENumber.Text);
            string contactPerson    = Business_Contact.Text;
            int fax                 = Int32.Parse(Business_Fax.Text);
            string companyName      = Business_Name.Text;

            Cardealer.getInstance().registerBusinessCustomer(address, phone, seNumber, contactPerson, fax, companyName);
        }
        
    }
}
