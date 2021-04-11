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
        private string condition_num;
        private string ConditonString;

        public BuyPage(thing selectedthing)
        {
            InitializeComponent();
            if (selectedthing != null)
                _currentthing = selectedthing;
            InitializeComponent();
            DataContext = _currentthing;
            condition_num = Convert.ToString(condition.Text);

            ConditonString = (condition_num == "1") ? "Плохое": (condition_num == "2") ? "среднее": "отличное" ;
            

        }

        
        private void BtnBuyThing_Click(object sender, RoutedEventArgs e)
        {
            var allthings = _currentthing.ToString();
            var application = new Word.Application();
            Word.Document document = application.Documents.Add();
        foreach (var allthing in allthings)
            {
                //  Word.Paragraph thingsParagrapth = document.Paragraphs.Add();
                //  Word.Range thingsRange = thingsParagrapth.Range;
                //   thingsRange.Text = allthings;
                // thingsRange.InsertParagraphAfter();
                Word.Paragraph tableParagraph = document.Paragraphs.Add();
                Word.Range tableRange = tableParagraph.Range;
                Word.Table paymentsTable = document.Tables.Add(tableRange, 1, 2);
                paymentsTable.Borders.InsideLineStyle = paymentsTable.Borders.OutsideLineStyle
                    = Word.WdLineStyle.wdLineStyleSingle;
                paymentsTable.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                Word.Range CellRange;
                CellRange = paymentsTable.Cell(1, 1).Range;
                CellRange.Text = "Название";
                CellRange = paymentsTable.Cell(1, 2).Range;
                CellRange.Text = Convert.ToString(namedata.Text);
                CellRange = paymentsTable.Cell(2, 1).Range;
                CellRange.Text = "Описание";
                CellRange = paymentsTable.Cell(2, 2).Range;
                CellRange.Text = Convert.ToString(description.Text); ;
                CellRange = paymentsTable.Cell(3, 1).Range;
                CellRange.Text = "Состояние";
                CellRange = paymentsTable.Cell(3, 2).Range;
                CellRange.Text = ConditonString;
                CellRange = paymentsTable.Cell(4, 1).Range;
                CellRange.Text = "Цена";
                CellRange = paymentsTable.Cell(4, 2).Range;
                CellRange.Text = Convert.ToString(price.Text); ;

            }
                Word.Paragraph paragraph = document.Paragraphs.Add();
                Word.Range range = paragraph.Range;
               
            application.Visible = true;
            document.SaveAs2(@"D:\Test.docx");
        
        
        
        
        }
    }
}
