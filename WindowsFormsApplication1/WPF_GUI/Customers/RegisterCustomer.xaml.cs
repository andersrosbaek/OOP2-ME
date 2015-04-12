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
            if (Private_Male.IsChecked == true)
            {
                sex = "Male";
            }
            else if (Private_Female.IsChecked == true)
            {
                sex = "Female";
            }

            if (checkForPrivateFields(sex))
            {
                DateTime date;
                date = (DateTime)Private_Date.SelectedDate;

                string address = Private_Address.Text;
                int phone = Int32.Parse(Private_Number.Text);
                string name = Private_Name.Text;
                bool isVehicleNewsReciever = checkBox_vehicleNews.IsChecked.Value;

                Cardealer.getInstance().registerPrivateCustomer(address, phone, name, date, sex, isVehicleNewsReciever);
            }
        }

        private bool checkForPrivateFields(string sex)
        {
            int empty = 0;
            string needs = "\n";
            if (Private_Number.Text == "")          { empty++; needs += "Number \n"; }
            if (Private_Address.Text == "")         { empty++; needs += "Adress \n"; }
            if (Private_Name.Text == "")            { empty++; needs += "Name \n"; }
            if (sex == "")                          { empty++; needs += "Sex \n"; }
            if (Private_Date.SelectedDate == null)  { empty++; needs += "Date \n"; }

            if(empty > 0){
                MessageBox.Show("You need to fill these fields: \n" + needs);
                return false;
            }else{
                return true;
            }
        }

        private void CreateBusinessCustomer(object sender, RoutedEventArgs e)
        {
            if (checkForBusinessFields()) { 
                string address          = Business_Address.Text;
                int phone              = Int32.Parse(Business_Number.Text);
                string name             = Private_Name.Text;
                int seNumber            = Int32.Parse(Business_SENumber.Text);
                string contactPerson    = Business_Contact.Text;
                int fax                 = Int32.Parse(Business_Fax.Text);
                string companyName      = Business_Name.Text;
                bool isVehicleNewsReciever = checkBox_vehicleNews.IsChecked.Value;

                Cardealer.getInstance().registerBusinessCustomer(address, phone, seNumber, contactPerson, fax, companyName, isVehicleNewsReciever);
            }
        }

        private bool checkForBusinessFields()
        {
            int empty = 0;
            string needs = "\n";

            if (Business_Number.Text == "") { empty++; needs += "Number \n"; }
            if (Business_Address.Text == "") { empty++; needs += "Adress \n"; }
            if (Business_Name.Text == "") { empty++; needs += "Name \n"; }
            if (Business_Fax.Text == "") { empty++; needs += "Fax \n"; }
            if (Business_Contact.Text == "") { empty++; needs += "Contact \n"; }
            if (Business_SENumber.Text == "") { empty++; needs += "SE-Number \n"; }


            if (empty > 0)
            {
                MessageBox.Show("You need to fill these fields: \n" + needs);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
