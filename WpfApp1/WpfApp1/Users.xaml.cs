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
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Page
    {
        public Users()
        {
            InitializeComponent();
            DGridUsersAdmin.ItemsSource = LavkaEntities1.GetContext().users.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditUsers((sender as Button).DataContext as user));
        }

        private void BtnAddUsers_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditUsers(null));
        }

        private void BtnDeleteUsers_Click(object sender, RoutedEventArgs e)
        {
                var UsersForRemoving = DGridUsersAdmin.SelectedItems.Cast<user>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {UsersForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)

            {
                try
                {
                    LavkaEntities1.GetContext().users.RemoveRange(UsersForRemoving);
                    LavkaEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridUsersAdmin.ItemsSource = LavkaEntities1.GetContext().users.ToList();


                }
                catch ( Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                LavkaEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridUsersAdmin.ItemsSource = LavkaEntities1.GetContext().users.ToList();
            }
        }
    }
}
