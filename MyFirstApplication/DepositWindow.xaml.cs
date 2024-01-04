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

    public partial class DepositWindow : Window
    {

        public CardHolder currentUser;
        
        public DepositWindow(CardHolder currentUser)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int depAmount = int.Parse(depositAmount.Text);
                currentUser.setBalance(currentUser.getBalance() + depAmount);
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    mainWindow.userBalance.Text = currentUser.getBalance().ToString() + "$";
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid amount!");
            }
            this.Close();
        }
    }
}
