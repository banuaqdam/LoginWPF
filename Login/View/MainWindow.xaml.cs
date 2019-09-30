using Login.View;
using MaterialDesignThemes.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Login.Controllers;


namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Txt_Username.Text = Properties.Settings.Default.Username;
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            User_Controller user = new User_Controller();
            string _username = Txt_Username.Text;
            string _password = Txt_Password.Password;
            var result = user.Login(_username, _password);

            if(result == true)
            {
                this.Hide();
                Home home = new Home(_username);
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User/Password Error!");
            }       
        }

        private void Btn_Register_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Register Register = new Register();
            Register.ShowDialog();
            this.Close();
        }

        private void Chk_Remember_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Username = Txt_Username.Text;
            Properties.Settings.Default.Save();
        }

        private void Btn_Forgot_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Under Construction");
        }
    }
}
