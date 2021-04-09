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
    /// Логика взаимодействия для AddEditThings.xaml
    /// </summary>
    public partial class AddEditThings : Page
    {
        private thing _currentthing = new thing();

        public AddEditThings(thing selectedthing)
        {
            InitializeComponent();
            if (selectedthing != null)
                _currentthing = selectedthing;
            InitializeComponent();
            DataContext = _currentthing;
        }

        private void BtnSaveThing_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentthing.name))
                errors.AppendLine("Введите Имя");
            if (string.IsNullOrWhiteSpace(_currentthing.description))
                errors.AppendLine("Введите Фамилию");
           // if (string.IsNullOrWhiteSpace(_currentthing.login))
           //     errors.AppendLine("Введите Логин");
           // if (string.IsNullOrWhiteSpace(_currentthing.password))
            //    errors.AppendLine("Введите Пароль");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentthing.id == 0)
                LavkaEntities1.GetContext().things.Add(_currentthing);

            try
            {
                LavkaEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
