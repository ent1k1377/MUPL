using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Mupl
{
    /// <summary>
    /// Логика взаимодействия для AddEditLabel.xaml
    /// </summary>
    public partial class AddEditLabel : Window
    {
        private label _currentLabel = new label();
        public AddEditLabel(label selectedLabel)
        {
            InitializeComponent();
            if (selectedLabel != null)
                _currentLabel = selectedLabel;

            DataContext = _currentLabel;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void BtnLoadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = ""; // Default file name
                               // dlg.DefaultExt = ".png"; // Default file extension
            dlg.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
         "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
         "Portable Network Graphic (*.png)|*.png";   // Filter files by extension

            // Show open file dialog box
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                Photo.Source = new BitmapImage(new Uri(dlg.FileName));
                _currentLabel.photo = System.IO.Path.GetFileName(dlg.FileName);
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentLabel.name))
                errors.AppendLine("Укажите название");
            if (string.IsNullOrWhiteSpace(_currentLabel.description))
                errors.AppendLine("Укажите описание");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentLabel.id == 0)
                muplEntities.GetContext().label.Add(_currentLabel);

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
