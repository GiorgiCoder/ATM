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

namespace MyFirstApplication
{
    /// <summary>
    /// Interaction logic for changePINCodeWindow.xaml
    /// </summary>
    public partial class changePINCodeWindow : Window
    {

        public CardHolder currentUser;

        public changePINCodeWindow(CardHolder currentUser)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (currentUser.getPin().Equals(int.Parse(currPin.Text)))
                {
                    if (newPin.Text == null)
                    {
                        MessageBox.Show("Enter a PIN code!");
                    }
                    else
                    {
                        currentUser.setPin(int.Parse(newPin.Text));
                        this.Close();
                        MessageBox.Show("PIN code changed successfully!");
                        return;
                    }
                }
                else
                {
                    currPin.Clear();
                    MessageBox.Show("Incorrect PIN code!");
                }
            }
            catch
            {
                MessageBox.Show("Enter valid PIN code!");
            }
            /*if (currentUser.getPassword().Equals(currPin.Text))
            {
                if (newPin.Text == "")
                {
                    MessageBox.Show("Enter a PIN code!");
                }
                else
                {
                    currentUser.setUserPassword(newPin.Text);
                    this.Close();
                    MessageBox.Show("PIN code changed successfully!");
                    return;
                }
            }
            else
            {
                currPin.Clear();
                MessageBox.Show("Incorrect current PIN code!");
            }*/
        }
    }
}
