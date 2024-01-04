using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace MyFirstApplication
{

    public partial class LogInWindow : Window
    {

        public CardHolder currentUser;
        public int logInTries = 0;

        public static List<CardHolder> cardHolders = new List<CardHolder>
        {
            new CardHolder("giorgi", "gio123", 91294710, 0123, "Giorgi", "Otinashvili", 0, 0),
            new CardHolder("temo", "temo123", 42938795, 1234, "Temo", "Otinashvili", 0, 0),
            new CardHolder("malkhazi", "malkhazi123", 74016552, 2345, "Malkhaz", "Doe", 0, 0),
            new CardHolder("ushangi", "ushangi123", 85854926, 3456, "Ushangi", "Vighacishvili", 0, 0),
            new CardHolder("zurabchik", "zura123", 85123926, 4567, "Zura :)", "Avaliani", 0, 0)
        };



        public LogInWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            logInTries++;

            currentUser = cardHolders.FirstOrDefault(x => x.getUserName() == username.Text);

            if (currentUser != null)
            {
                if (currentUser.getPassword() == password.Password)
                {
                    var mainWindow = new MainWindow(currentUser);
                    Application.Current.MainWindow = mainWindow;
                    mainWindow.Show();
                    Close();
                    return;
                }
                else
                {
                    password.Clear();
                    if (logInTries >= 3)
                    {
                        Close();
                        MessageBox.Show("Too many unsuccessful tries! Try again later!");
                        return;
                    }
                    else MessageBox.Show("Incorrect password!");
                }
            }
            else
            {
                username.Clear();
                password.Clear();
                if (logInTries >= 3)
                {
                    Close();
                    MessageBox.Show("Too many unsuccessful tries! Try again later!");
                    return;
                }
                else MessageBox.Show("User not found!");
            }
        }
    }
}
