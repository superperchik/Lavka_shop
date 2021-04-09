using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        enum Role { Failed, Admin, User }

        static Role GetRole(string login, string password)
        {
            Role role = Role.Failed;
            using (var connection = new SqlConnection("server=localhost\\SQLEXPRESS;Trusted_Connection=Yes;Database=Lavka;"))
            {
                connection.Open();
                var command = new SqlCommand("Select [Role] From users WHERE login=@login AND password=@password", connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                using (var dataReader = command.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        switch ((int)dataReader["role"])
                        {
                            case 0: role = Role.User; break;
                            case 1: role = Role.Admin; break;
                        }
                    }
                }
            }
            return role;
        }




        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            Role role = GetRole(LoginBox.Text, PassBox.Password);
            if (role == Role.Failed)
            {
                MessageBox.Show("Неверный логин или пароль");
                //Manager.MainFrame.Navigate(new UserForm());
            }
            else
            {
                if (role == Role.Admin)
                {
                    Manager.MainFrame.Navigate(new AdminForm());
                }
                else if (role == Role.User)
                {
                    Manager.MainFrame.Navigate(new UserForm());
                }
            }
        }


        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Registration(null));
        }
    }
}
