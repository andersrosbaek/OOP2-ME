﻿using System;
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
        List<PrivateCustomer> privateCustomers = Cardealer.getInstance().getPrivateCustomers();
        List<BusinessCustomer> businessCustomers = Cardealer.getInstance().getBusinessCustomers();
        List<Car> cars = Cardealer.getInstance().getCars();
        List<Truck> trucks = Cardealer.getInstance().getTrucks();

        public RegisterContract()
        {
            InitializeComponent();
<<<<<<< HEAD

            List<PrivateCustomer> privateCustomers      = Cardealer.getInstance().getPrivateCustomers();
            List<BusinessCustomer> businessCustomers    = Cardealer.getInstance().getBusinessCustomers();
            List<Car> cars                              = Cardealer.getInstance().getCars();
            List<Truck> trucks                          = Cardealer.getInstance().getTrucks();


=======
            fillComboBoxes();
            
>>>>>>> origin/master
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
                    btnVehicleModel.Items.Add(model.Model);
                }

            }

            foreach (Truck model in trucks)
            {
                if (model != null)
                {
                    btnCompanyVehicleModel.Items.Add(model.Model);
                }
            }
        }

        private void fillComboBoxes()
        {
            btnCustomer.Items.Add("Select a customer");
            btnVehicleModel.Items.Add("Select a model");
            btnVehicleColor.Items.Add("Select a color");
            btnVehiclePrice.Items.Add("Select a price");
            btnCompany.Items.Add("Select a company");
            btnCompanyVehicleModel.Items.Add("Select a model");
            btnCompanyVehicleColor.Items.Add("Select a color");
            btnCompanyVehiclePrice.Items.Add("Select a price");
        }

        private void SalesRadioButton(object sender, RoutedEventArgs e)
        {
            SalesGrid.Visibility = System.Windows.Visibility.Visible;
            LeasingGrid.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void LeasingRadioButton(object sender, RoutedEventArgs e)
        {
            LeasingGrid.Visibility = System.Windows.Visibility.Visible;
            SalesGrid.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void inputVehicleColor(object sender, SelectionChangedEventArgs e)
        {
            btnVehicleColor.Items.Clear();
            btnVehicleColor.Items.Add("Select a color");
            btnVehicleColor.SelectedIndex = 0;
            foreach (Car model in cars)
            {
                if (String.Equals(model.Model, btnVehicleModel.SelectedItem))
                {
                    btnVehicleColor.Items.Add(model.Color);
                }

            }
        }

        private void inputVehiclePrice(object sender, SelectionChangedEventArgs e)
        {
            btnVehiclePrice.Items.Clear();
            btnVehiclePrice.Items.Add("Select a price");
            btnVehiclePrice.SelectedIndex = 0;
            foreach (Car model in cars)
            {
                if (String.Equals(model.Model, btnVehicleModel.SelectedItem) && String.Equals(model.Color, btnVehicleColor.SelectedItem))
                {
                    btnVehiclePrice.Items.Add(model.Price);
                }

            }
        }

        private void inputTotalVehiclePrice(object sender, SelectionChangedEventArgs e)
        {
            if(btnVehiclePrice.SelectedIndex > 0 && btnCommissionSelection.SelectedIndex > 0)
            {
                double vehiclePrice = (double) btnVehiclePrice.SelectedItem;
                double salesCommission = (double) btnCommissionSelection.SelectedItem;
                lblTotalVehicleprice.Content = vehiclePrice + vehiclePrice * (salesCommission / 100);
            }
        }

        private void inputCompanyVehicleColor(object sender, SelectionChangedEventArgs e)
        {
            btnCompanyVehicleColor.Items.Clear();
            btnCompanyVehicleColor.Items.Add("Select a color");
            btnCompanyVehicleColor.SelectedIndex = 0;
            foreach (Truck model in trucks)
            {
                if (String.Equals(model.Model, btnCompanyVehicleModel.SelectedItem))
                {
                    btnCompanyVehicleColor.Items.Add(model.Color);
                }

            }
        }

        private void inputCompanyVehiclePrice(object sender, SelectionChangedEventArgs e)
        {
            btnCompanyVehiclePrice.Items.Clear();
            btnCompanyVehiclePrice.Items.Add("Select a price");
            btnCompanyVehiclePrice.SelectedIndex = 0;
            foreach (Truck model in trucks)
            {
                if (String.Equals(model.Model, btnCompanyVehicleModel.SelectedItem) && String.Equals(model.Color, btnCompanyVehicleColor.SelectedItem))
                {
                    btnCompanyVehiclePrice.Items.Add(model.Price);
                }

            }
        }

        private void inputTotalCompanyVehiclePrice(object sender, SelectionChangedEventArgs e)
        {
            if (btnCompanyVehiclePrice.SelectedIndex > 0 && btnCompanyCommissionSelection.SelectedIndex > 0)
            {
                double companyVehiclePrice = (double)btnCompanyVehiclePrice.SelectedItem;
                double leasingCommission = (double)btnCompanyCommissionSelection.SelectedItem;
                lblCompanyMonthlyVehicleCost.Content = (companyVehiclePrice + companyVehiclePrice * (leasingCommission / 100))/60;
                lblCompanyTotalVehicleCost.Content = companyVehiclePrice + companyVehiclePrice * (leasingCommission / 100);
            }
        }

        private void createSalesContract(object sender, RoutedEventArgs e)
        {

        }

        private void createLeasingContrac(object sender, RoutedEventArgs e)
        {

        }

        

        
    }
}