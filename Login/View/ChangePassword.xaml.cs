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
using Login.Controllers;

namespace Login.View
{
    /// <summary>
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        public string G_Username;
        public ChangePassword(string Username)
        {
            InitializeComponent();
            setUsername(Username);
        }

        public void setUsername(string username)
        {
            G_Username = username;
        }

        private void Btn_Change_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home(G_Username);
            User_Controller user = new User_Controller(); 

            string _a_password = Txt_a_password.Password;
            string _b_password = Txt_b_password.Password;
            string _c_password = Txt_c_password.Password;

            var result = user.changePassword(G_Username, _a_password, _b_password, _c_password);
            if (result == 1)
            {
                MessageBox.Show("Change Password Success!");
            }else if(result == 2)
            {
                MessageBox.Show("New Password Didnt Same!");
            }
            else
            {
                MessageBox.Show("Wrong Current Password!");
            }           
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home(G_Username);
            this.Hide();
            home.Show();
            this.Close();
        }
    }
}
