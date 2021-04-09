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
    /// Логика взаимодействия для AdminForm.xaml
    /// </summary>
    public partial class AdminForm : Page
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void UsersBtnAdmin_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Users());
        }

        private void UnitsDBAdmin_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ThingsAdmin());
        }
    }
}
