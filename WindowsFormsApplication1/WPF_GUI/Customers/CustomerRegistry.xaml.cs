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
    /// Interaction logic for CustomerRegistry.xaml
    /// </summary>
    public partial class CustomerRegistry : Window
    {            
        List<PrivateCustomer> privateCustomers = Cardealer.getInstance().getPrivateCustomers();
        List<BusinessCustomer> businessCustomers = Cardealer.getInstance().getBusinessCustomers();

        public CustomerRegistry()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            CustomerGrid.ItemsSource = privateCustomers;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            CustomerGrid.ItemsSource = businessCustomers;

        }
    }
}
