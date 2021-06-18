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

namespace Mupl
{
    /// <summary>
    /// Логика взаимодействия для AddGenre.xaml
    /// </summary>
    public partial class AddGenre : Window
    {
        private genre _currentGenre = new genre();

        public AddGenre(genre selectedGenre)
        {
            InitializeComponent();
            if (selectedGenre != null)
                _currentGenre = selectedGenre;

            DataContext = _currentGenre;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentGenre.name))
                errors.AppendLine("Укажите название жанра");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentGenre.id == 0)
                muplEntities.GetContext().genre.Add(_currentGenre);

            try
            {
                muplEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                BtnBack_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            new AdminPanel().Show();
            Hide();
        }
    }
}
