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
    /// Interaction logic for DeleteAccountWindow.xaml
    /// </summary>
    public partial class DeleteAccountWindow : Window
    {

        public CardHolder currentUser;
        public bool isConfirmed = false;
        public DeleteAccountWindow(CardHolder currentUser)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void checkIfConfirmed_Click(object sender, RoutedEventArgs e)
        {
            isConfirmed = !isConfirmed;
            if (isConfirmed)
            {
                enter.IsEnabled = true;
            }
            else
            {
                enter.IsEnabled = false;
            }
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if (currentUser.getPassword().Equals(userPassword.Password))
            {
                LogInWindow.cardHolders.Remove(currentUser);
                this.Close();
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    var loginWindow = new LogInWindow();
                    Application.Current.MainWindow = loginWindow;
                    loginWindow.Show();
                    mainWindow.Close();
                }
                MessageBox.Show("Your account has been deleted");
            }
            else
            {
                userPassword.Clear();
                MessageBox.Show("Incorrect password!");
            }
        }
    }
}
