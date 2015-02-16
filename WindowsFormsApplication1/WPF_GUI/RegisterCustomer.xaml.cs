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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class RegisterCustomer : Window
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string actualdata = string.Empty;
            char[] entereddata = Number.Text.ToCharArray();
            foreach (char aChar in entereddata.AsEnumerable())
            {
                if (Char.IsDigit(aChar))
                {
                    actualdata = actualdata + aChar;
                    // MessageBox.Show(aChar.ToString());
                }
                else
                {
                    MessageBox.Show(aChar + " is not numeric");
                    actualdata.Replace(aChar, ' ');
                    actualdata.Trim();
                }
            }
            Number.Text = actualdata;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            PrivateGrid.Visibility = System.Windows.Visibility.Visible; 
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            PrivateGrid.Visibility = System.Windows.Visibility.Hidden; 
        }
        
    }
}
