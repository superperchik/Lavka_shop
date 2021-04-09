using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginPage());
            Manager.MainFrame = MainFrame;
            //ImportThings();
        }
        //private void ImportThings()
        //{
        //    var fileData = File.ReadAllLines(@"C:\Users\1\Desktop\lavka\things.txt");
        //    var images = Directory.GetFiles(@"C:\Users\1\Desktop\lavka\imgs");

        //    foreach (var line in fileData)
        //    {
        //        var Data = line.Split('\t');

        //        var tempThing = new thing
        //        {
        //            name = Data[0].Replace("\"", ""),
        //            description = Data[1].Replace("\"", ""),
        //            count = int.Parse(Data[2]),
        //            condition = int.Parse(Data[3]),
        //            price = decimal.Parse(Data[4])

        //        };


                
                
        //            try
        //            {
        //                tempThing.image = File.ReadAllBytes(images.FirstOrDefault(p => p.Contains(tempThing.name)));
        //            }

        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //            LavkaEntities.GetContext().things.Add(tempThing);
        //            LavkaEntities.GetContext().SaveChanges();

                
        //    }
        //}

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
