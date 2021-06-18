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
    /// Логика взаимодействия для AddEditTrack.xaml
    /// </summary>
    public partial class AddEditTrack : Window
    {
        private track _currentTrack = new track();

        public AddEditTrack(track selectedTrack)
        {
            InitializeComponent();
            ComboPerfomances.ItemsSource = muplEntities.GetContext().performer.ToList();
            ComboAlbums.ItemsSource = muplEntities.GetContext().album.ToList();
            if (selectedTrack != null)
            {
                _currentTrack = selectedTrack;
                
                ComboPerfomances.Text = muplEntities.GetContext().performer.Where(p => p.id == _currentTrack.id_performer).ToList()[0].name.ToString();
                ComboAlbums.Text = muplEntities.GetContext().album.Where(p => p.id == _currentTrack.id_album).ToList()[0].name.ToString();
            }
            DataContext = _currentTrack;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentTrack.name))
                errors.AppendLine("Укажите название");
            if (string.IsNullOrWhiteSpace(ComboPerfomances.Text))
                errors.AppendLine("Укажите исполнителя");
            if (string.IsNullOrWhiteSpace(ComboAlbums.Text))
                errors.AppendLine("Укажите альбом");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            _currentTrack.id_album = muplEntities.GetContext().album.Where(p => p.name == ComboAlbums.Text).ToList()[0].id;
            _currentTrack.id_performer = muplEntities.GetContext().performer.Where(p => p.name == ComboPerfomances.Text).ToList()[0].id;
            if (_currentTrack.id == 0)
                muplEntities.GetContext().track.Add(_currentTrack);

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

        private void BtnLoadAudio_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = ""; // Default file name
                               // dlg.DefaultExt = ".png"; // Default file extension
            dlg.Filter = "All supported audio|*.mp3;*.ogg;*.wav|" +
                         "MP3 (*.mp3)|*.mp3|" +
                         "OGG (*.ogg)|*.ogg|" +
                         "WAV (*.wav)|*.wav";   // Filter files by extension

            // Show open file dialog box
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                _currentTrack.path = dlg.FileName;
            }
        }

        private void BtnPlayAudio_Click(object sender, RoutedEventArgs e)
        {
            Audio.Play();
        }

        private void BtnPauseAudio_Click(object sender, RoutedEventArgs e)
        {
            Audio.Pause();
        }
    }
}
