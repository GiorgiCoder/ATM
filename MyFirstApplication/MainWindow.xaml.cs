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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public CardHolder currentUser;

        public MainWindow(CardHolder currentUser)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.currentUser = currentUser;
            welcomeMessage.Text = "Welcome, " + currentUser.getFName() + "!";
            userFandLName.Text = currentUser.getFName() + " " + currentUser.getLName();
            userBalance.Text = currentUser.getBalance().ToString() + "$";
            userSavings.Text = currentUser.getSavings().ToString() + "$";

        }


        private void depositButton_Click(object sender, RoutedEventArgs e)
        {
            var depositWindow = new DepositWindow(currentUser);
            depositWindow.Show();
        }

        private void changePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            var changePasswordWindow = new changePassword(currentUser);
            changePasswordWindow.Show();
        }

        private void transferToFundsButton_Click(object sender, RoutedEventArgs e)
        {
            var transFunds = new TransferToFundsWindow(currentUser);
            transFunds.Show();
        }


        private void WithdrawButton_Click(object sender, RoutedEventArgs e)
        {
            var withdrawalWindow = new WithdrawalWindow(currentUser);
            withdrawalWindow.Show();
        }

        private void changePinCodeButton_Click(object sender, RoutedEventArgs e)
        {
            var changePINWindow = new changePINCodeWindow(currentUser);
            changePINWindow.Show();
        }


        private void deleteAccount_Click(object sender, RoutedEventArgs e)
        {
            var deleteAcc = new DeleteAccountWindow(currentUser);
            deleteAcc.Show();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            if(Application.Current.MainWindow is MainWindow mainWindow)
                {
                var loginWindow = new LogInWindow();
                Application.Current.MainWindow = loginWindow;
                loginWindow.Show();
                mainWindow.Close();
            }
        }
    }
}