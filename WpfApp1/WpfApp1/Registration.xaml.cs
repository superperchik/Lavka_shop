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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private user _currentuser = new user();
        public Registration(user selecteduser)
        {
            if (selecteduser != null)
                _currentuser = selecteduser;
            InitializeComponent();
            DataContext = _currentuser;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentuser.firstname))
                errors.AppendLine("Введите Имя");
            if (string.IsNullOrWhiteSpace(_currentuser.lastname))
                errors.AppendLine("Введите Фамилию");
            if (string.IsNullOrWhiteSpace(_currentuser.login))
                errors.AppendLine("Введите Логин");
            if (string.IsNullOrWhiteSpace(_currentuser.password))
                errors.AppendLine("Введите Пароль");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentuser.id == 0)
                LavkaEntities1.GetContext().users.Add(_currentuser);

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
