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
    
    public partial class TransferToFundsWindow : Window
    {

        CardHolder currentUser;
        public TransferToFundsWindow(CardHolder currentUser)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (currentUser.getBalance() < double.Parse(transferAmount.Text))
                {
                    transferAmount.Clear();
                    MessageBox.Show("Not enough balance!");
                }
                else
                {
                    double tranAmount = double.Parse(transferAmount.Text);
                    currentUser.setSavings(currentUser.getSavings() + tranAmount);
                    currentUser.setBalance(currentUser.getBalance() - tranAmount);
                    if (Application.Current.MainWindow is MainWindow mainWindow)
                    {
                        mainWindow.userBalance.Text = currentUser.getBalance().ToString() + "$";
                        mainWindow.userSavings.Text = currentUser.getSavings().ToString() + "$";
                    }
                    this.Close();
                }
            }
            catch
            {
                transferAmount.Clear();
                MessageBox.Show("Please entere a valid amount!");
            }
        }
    }
}
