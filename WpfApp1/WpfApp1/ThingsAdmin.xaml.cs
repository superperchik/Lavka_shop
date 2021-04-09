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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ThingsAdmin.xaml
    /// </summary>
    public partial class ThingsAdmin : Page
    {
        public ThingsAdmin()
        {
            InitializeComponent();
            DGThingsAdmin.ItemsSource = LavkaEntities1.GetContext().things.ToList();
        }

        private void BtnEditthing_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditThings((sender as Button).DataContext as thing));
        }

        private void BtnAddThings_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditThings(null));
        }

        private void BtnDeleteThings_Click(object sender, RoutedEventArgs e)
        {
            var UsersForRemoving = DGThingsAdmin.SelectedItems.Cast<thing>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {UsersForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)

            {
                try
                {
                    LavkaEntities1.GetContext().things.RemoveRange(UsersForRemoving);
                    LavkaEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGThingsAdmin.ItemsSource = LavkaEntities1.GetContext().things.ToList();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
