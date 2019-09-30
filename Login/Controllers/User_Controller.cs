using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Models;
using Login.Context;
using System.Windows;

namespace Login.Controllers
{
    class User_Controller : User
    {
        public void AddUser(string _name, string _username, string _password)
        {
            var result = 0;
            User user = new User();
            MyContext context = new MyContext();

            user.Username = _username;
            user.Password = _password;
            user.Name = _name;
            context.Users.Add(user);
            result = context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Register Successful!");
            }
            else
            {
                MessageBox.Show("Register Failed!");
            }
        }
    }
}
