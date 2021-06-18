using Microsoft.Win32;
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

namespace Mupl
{
    /// <summary>
    /// Логика взаимодействия для AddEditPerformer.xaml
    /// </summary>
    public partial class AddEditPerformer : Window
    {
        private performer _currentPerformer = new performer();
        public AddEditPerformer(performer selectedPerformer)
        {
            InitializeComponent();
            ComboLabels.ItemsSource = muplEntities.GetContext().label.ToList();
            if (selectedPerformer != null)
            {
                _currentPerformer = selectedPerformer;
                //ComboLabels.ItemsSource = muplEntities.GetContext().label.ToList();
                ComboLabels.Text = muplEntities.GetContext().label.Where(p => p.id == _currentPerformer.id_label).ToList()[0].name.ToString();
            }
                
            DataContext = _currentPerformer;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            new AdminPanel().Show();
            Hide();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentPerformer.name))
                errors.AppendLine("Укажите название");
            if (string.IsNullOrWhiteSpace(_currentPerformer.description))
                errors.AppendLine("Укажите описание");
            if (string.IsNullOrWhiteSpace(ComboLabels.Text))
                errors.AppendLine("Укажите лейбл");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            _currentPerformer.id_label = muplEntities.GetContext().label.Where(p => p.name == ComboLabels.Text).ToList()[0].id;
            if (_currentPerformer.id == 0)
                muplEntities.GetContext().performer.Add(_currentPerformer);

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
                _currentPerformer.photo = System.IO.Path.GetFileName(dlg.FileName);
            }
        }
    }
}
