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

namespace Login.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public string G_username;
        public Home(string Username)
        {
            InitializeComponent();
            setUsername(Username);
        }
        public void setUsername(string username)
        {
            G_username = username;
        }

        private void Btn_Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Hide();
            main.Show();
            this.Close();
        }

        private void Btn_Ch_Password_Click(object sender, RoutedEventArgs e)
        {
            ChangePassword change = new ChangePassword(G_username);
            this.Hide();
            change.Show();
            this.Close();

        }
    }
}
