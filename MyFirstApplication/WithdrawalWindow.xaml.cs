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
    /// Interaction logic for WithdrawalWindow.xaml
    /// </summary>
    public partial class WithdrawalWindow : Window
    {

        public CardHolder currentUser;
        public WithdrawalWindow(CardHolder currentUser)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int withdrawAmount = int.Parse(withdrawalAmount.Text);
                if (withdrawAmount <= currentUser.getBalance())
                {
                    currentUser.setBalance(currentUser.getBalance() - withdrawAmount);
                    if (Application.Current.MainWindow is MainWindow mainwindow)
                    {
                        mainwindow.userBalance.Text = currentUser.getBalance().ToString() + "$";
                    }
                }
                else
                    MessageBox.Show("Insufficient balance!");
            }
            catch
            {
                MessageBox.Show("Please enter valid amount!");

            }
            this.Close();
        }
    }
}
