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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dataTrack.ItemsSource = muplEntities.GetContext().track.ToList();
        }

        private void BtnPlayAudio_Click(object sender, RoutedEventArgs e)
        {
            Audio.Source = new Uri(dataTrack.SelectedItems.Cast<track>().ToList()[0].path);
            Audio.Play();
        }

        private void BtnPauseAudio_Click(object sender, RoutedEventArgs e)
        {
            Audio.Pause();
        }
    }
}
