using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Models;
using Login.Context;
using System.Windows;
using Login.View;

namespace Login.Controllers
{
    class User_Controller : User
    {
        public string G_username;

        public void setUsername(string username)
        {
            G_username = username;
        } 
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

        public bool Login (string _username, string _password)
        {
            MyContext context = new MyContext();
            User user = new User();

            user.Username = _username;
            user.Password = _password;
            var get = context.Users.Where(u => u.Username == _username).FirstOrDefault<User>();
            if(get != null)
            {
                if(get.Password == _password)
                {
                    return true;
                }
                else
                {
                    return false;
                }          
            }
            else
            {
                return false;
            }
        }

        public int changePassword (string _username, string _a_password, string _b_password, string _c_password)
        {
            MyContext context = new MyContext();
            User user = new User();
            var get = context.Users.Where(u => u.Username == _username).FirstOrDefault<User>();
            if(get == null)
            {
                MessageBox.Show("Username tidak ada");
            }
            if (get.Password == _a_password)
            {
                if(_b_password == _c_password)
                {
                    get.Password = _b_password;
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;
            }
            
        }
    }
}
