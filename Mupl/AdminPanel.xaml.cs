using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mupl
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        private Grid[] _grids;
        private Grid _currentGrid;

        public AdminPanel()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dataUsers.ItemsSource = muplEntities.GetContext().users.ToList();
            _currentGrid = GridUsers;
            _grids = new Grid[] { GridGenre, GridLabel, GridAlbum, GridPerformer, GridTrack, GridUsers };
        }

        private void BtnEditGenre_Click(object sender, RoutedEventArgs e)
        {
            new AddGenre((sender as Button).DataContext as genre).Show();
            Hide();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (_currentGrid == GridGenre)
            {
                new AddGenre(null).Show();
            }
            else if (_currentGrid == GridLabel)
            {
                new AddEditLabel(null).Show();
            }
            else if (_currentGrid == GridAlbum)
            {
                new AddEditAlbum(null).Show();
            }
            else if (_currentGrid == GridPerformer)
            {
                new AddEditPerformer(null).Show();
            }
            else if (_currentGrid == GridTrack)
            {
                new AddEditTrack(null).Show();
            }
            Hide();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (_currentGrid == GridGenre)
            {
                var forRemoving = dataGenre.SelectedItems.Cast<genre>().ToList();

                if (MessageBox.Show($"Вы точно хотите удалить следующие {forRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        muplEntities.GetContext().genre.RemoveRange(forRemoving);
                        muplEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        dataGenre.ItemsSource = muplEntities.GetContext().genre.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            else if (_currentGrid == GridUsers)
            {
                var forRemoving = dataUsers.SelectedItems.Cast<users>().ToList();

                if (MessageBox.Show($"Вы точно хотите удалить следующие {forRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        muplEntities.GetContext().users.RemoveRange(forRemoving);
                        muplEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        dataUsers.ItemsSource = muplEntities.GetContext().users.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            else if (_currentGrid == GridLabel)
            {
                var forRemoving = dataLabel.SelectedItems.Cast<label>().ToList();

                if (MessageBox.Show($"Вы точно хотите удалить следующие {forRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        muplEntities.GetContext().label.RemoveRange(forRemoving);
                        muplEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        dataLabel.ItemsSource = muplEntities.GetContext().label.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            else if (_currentGrid == GridAlbum)
            {
                var forRemoving = dataAlbum.SelectedItems.Cast<album>().ToList();

                if (MessageBox.Show($"Вы точно хотите удалить следующие {forRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        muplEntities.GetContext().album.RemoveRange(forRemoving);
                        muplEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        dataAlbum.ItemsSource = muplEntities.GetContext().album.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            else if (_currentGrid == GridPerformer)
            {
                var forRemoving = dataPerformer.SelectedItems.Cast<performer>().ToList();

                if (MessageBox.Show($"Вы точно хотите удалить следующие {forRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        muplEntities.GetContext().performer.RemoveRange(forRemoving);
                        muplEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        dataPerformer.ItemsSource = muplEntities.GetContext().performer.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            else if (_currentGrid == GridTrack)
            {
                var forRemoving = dataTrack.SelectedItems.Cast<track>().ToList();

                if (MessageBox.Show($"Вы точно хотите удалить следующие {forRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        muplEntities.GetContext().track.RemoveRange(forRemoving);
                        muplEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        dataTrack.ItemsSource = muplEntities.GetContext().track.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }

        }

        private void VisibleGrids()
        {
            foreach (var item in _grids)
            {
                if (_currentGrid != item)
                    item.Visibility = Visibility.Hidden;
                else
                    item.Visibility = Visibility.Visible;
            }
        }

        private void BtnLabelEdit_Click(object sender, RoutedEventArgs e)
        {
            new AddEditLabel((sender as Button).DataContext as label).Show();
            Hide();
        }

        private void BtnUsersEdit_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnTrackEdit_Click(object sender, RoutedEventArgs e)
        {
            new AddEditTrack((sender as Button).DataContext as track).Show();
            Hide();
        }

        private void BtnPerformerEdit_Click(object sender, RoutedEventArgs e)
        {
            new AddEditPerformer((sender as Button).DataContext as performer).Show();
            Hide();
        }

        private void BtnAlbumEdit_Click(object sender, RoutedEventArgs e)
        {
            new AddEditAlbum((sender as Button).DataContext as album).Show();
            Hide();
        }

        private void UsersTable_Click(object sender, RoutedEventArgs e)
        {
            dataUsers.ItemsSource = muplEntities.GetContext().users.ToList();
            _currentGrid = GridUsers;
            VisibleGrids();
        }

        private void PerformerTable_Click(object sender, RoutedEventArgs e)
        {
            dataPerformer.ItemsSource = muplEntities.GetContext().performer.ToList();
            _currentGrid = GridPerformer;
            VisibleGrids();
        }

        private void AlbumTable_Click(object sender, RoutedEventArgs e)
        {
            dataAlbum.ItemsSource = muplEntities.GetContext().album.ToList();
            _currentGrid = GridAlbum;
            VisibleGrids();
        }

        private void TrackTable_Click(object sender, RoutedEventArgs e)
        {
            dataTrack.ItemsSource = muplEntities.GetContext().track.ToList();
            _currentGrid = GridTrack;
            VisibleGrids();
        }

        private void LabelTable_Click(object sender, RoutedEventArgs e)
        {
            dataLabel.ItemsSource = muplEntities.GetContext().label.ToList();
            _currentGrid = GridLabel;
            VisibleGrids();
        }

        private void GenreTable_Click(object sender, RoutedEventArgs e)
        {
            dataGenre.ItemsSource = muplEntities.GetContext().genre.ToList();
            _currentGrid = GridGenre;
            VisibleGrids();
        }
    }
}
