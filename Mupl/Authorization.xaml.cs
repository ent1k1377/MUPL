using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mupl
{
    public partial class Authorization : Window
    {

        public Authorization()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Open_Registration(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Hide();
        }

        private static string GetHash(string plaintext)
        {
            var sha = new SHA1Managed();
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
            return Convert.ToBase64String(hash);
        }
        
        private void OpenApp(object sender, RoutedEventArgs e)
        {
            string hashedPassword = GetHash(password.Password);
            var user = muplEntities.GetContext().users.Where(p => p.login == login.Text).Where(p => p.password == hashedPassword).ToList();
            if (user.Count() != 0)
            {
                var role = user[0].role;

                if (role == "user")
                {
                    Main mainWindow = new Main();
                    mainWindow.Show();
                    Hide();
                }
                else if (role == "admin")
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Пароль или логин не правильный");
                }
            }
        }
    }
}
