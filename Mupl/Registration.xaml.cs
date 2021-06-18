using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Mupl
{
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void OpenAutorization(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Hide();
        }

        private void RegistrationDB(object sender, RoutedEventArgs e)
        {
            if (CheckUserRegistrationAsync(login.Text, password1.Password, password2.Password, email.Text))
            {
                try
                {
                    muplEntities.GetContext().users.Add(new users { login = login.Text, password = GetHash(password1.Password), email = email.Text, role="user", photo="Images/photo0.png" });
                    muplEntities.GetContext().SaveChanges();
                    OpenAutorization(null, null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
                
            }
        }

        static string GetHash(string plaintext)
        {
            var sha = new SHA1Managed();
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
            return Convert.ToBase64String(hash);
        }



        private bool CheckUserRegistrationAsync(string login, string password1, string password2, string email)
        {
            
            if (login.Length < 4)
            {
                MessageBox.Show("Логин меньше 4 символов");
            }
            else if (login.Length > 16)
            {
                MessageBox.Show("Логин больше 16 символов");
            }
            else if (muplEntities.GetContext().users.Where(p => p.login == login).ToList().Count() != 0)
            {
                MessageBox.Show("Такой логин уже существет");
            }
            else if (!Regex.IsMatch(login, @"^[\w+]{4,16}$"))
            {
                MessageBox.Show("В логине могут присутсвовать только символы анлийского языка и цифры");
            }
            else if (password1.Length < 8)
            {
                MessageBox.Show("Пароли меньше 8 символов");
            }
            else if (password1.Length > 32)
            {
                MessageBox.Show("Пароли больще 32 символов");
            }
            else if (password1 != password2)
            {
                MessageBox.Show("Пароли не верны");
            }
            else if (!Regex.IsMatch(password1, @"^[\w+]{8,32}$")) 
            {
                MessageBox.Show("В пароле должны присутствовать символы английского алфавита в нижнем и высоком регистре, а также хотя бы одна цифра ");
            }
            else if (!Regex.IsMatch(email, @"^([a-z0-9_\.-]+)@([a-z0-9_\.-]+)\.([a-z\.]{2,6})$"))
            {
                MessageBox.Show("Введен неправильный Email");
            }
            else return true;
            return false;
            
        }
    }
}
