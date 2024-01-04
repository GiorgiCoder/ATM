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
    /// Interaction logic for changePassword.xaml
    /// </summary>
    public partial class changePassword : Window
    {

        public CardHolder currentUser;

        public changePassword(CardHolder currentUser)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentUser.getPassword().Equals(currPassw.Password))
            {
                if (newPassw.Password == "")
                {
                    MessageBox.Show("Enter a password!");
                }
                else
                {
                    currentUser.setUserPassword(newPassw.Password);
                    this.Close();
                    MessageBox.Show("Password changed successfully!");
                    return;
                }
            }
            else
            {
                currPassw.Clear();
                MessageBox.Show("Incorrect current password!");
            }
        }
    }
}
