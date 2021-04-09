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
    /// Логика взаимодействия для UserForm.xaml
    /// </summary>
    public partial class UserForm : Page
    {
        public UserForm()
        {
            InitializeComponent();
            //DGridUserBuy.ItemsSource = LavkaEntities1.GetContext().things.ToList();
            

           /* var allTypes = LavkaEntities1.GetContext().things.ToList();
            allTypes.Insert(0, new Type  
            { 
                Name = "Все типы" 
            });
            CBoxSearch.ItemsSource = allTypes;
            CBoxSearch.SelectedIndex = 0;
           */
            var currentLavka = LavkaEntities1.GetContext().things.ToList();
            ThingsUser.ItemsSource = currentLavka;
           // UpdateThings();
        }

      /*  private void UpdateThings()
        {
            var currentLavka = LavkaEntities1.GetContext().things.ToList();
            if (CBoxSearch.SelectedIndex > 0)
                currentLavka = currentLavka.Where(p => p.Types.Contains(CBoxSearch.SelectedItem as Type)).ToList();
            currentLavka = currentLavka.Where(p =>.Name.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

        } */

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
           
            Manager.MainFrame.Navigate(new AddEditThings((sender as Button).DataContext as thing));
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CBoxSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
