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
using Word = Microsoft.Office.Interop.Word;
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для BuyPage.xaml
    /// </summary>
    public partial class BuyPage : Page
    {
        private thing _currentthing = new thing();
        public BuyPage(thing selectedthing)
        {
            InitializeComponent();
            if (selectedthing != null)
                _currentthing = selectedthing;
            InitializeComponent();
            DataContext = _currentthing;
        }

        private void BtnBuyThing_Click(object sender, RoutedEventArgs e)
        {
            var application = new Word.Application();
            Word.Document document = application.Documents.Add();
        
                Word.Paragraph paragraph = document.Paragraphs.Add();
                Word.Range range = paragraph.Range;
            application.Visible = true;
            document.SaveAs2(@"D:\Test.docx");
        
        
        
        
        }
    }
}
