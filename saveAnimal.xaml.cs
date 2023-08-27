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
using System.Windows.Shapes;

namespace Homework_19
{
    /// <summary>
    /// Логика взаимодействия для saveAnimal.xaml
    /// </summary>
    public partial class saveAnimal : Window
    {
        public saveAnimal()
        {
            InitializeComponent();
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            string name = NameFile.Text;
            string format= FormatFile.Text;
            switch (format)
            {
                case "Docx":
                    var saveDocx = new AnimalDocx(name);
                    AnimalWriter writer = new AnimalWriter(saveDocx);
                    writer.Save();
                    break;

                case "Pdf":
                    var savePdf = new AnimalPdf(name);
                    AnimalWriter writer1 = new AnimalWriter(savePdf);
                    writer1.Save();
                    break;

                case "Xlsx":
                    var saveXlsx = new AnimalXlsx(name);
                    AnimalWriter writer2 = new AnimalWriter(saveXlsx);
                    writer2.Save();
                    break;

                case "Txt":
                    var saveTxt = new AnimalTxt(name);
                    AnimalWriter writer3 = new AnimalWriter(saveTxt);
                    writer3.Save();
                    break;

                case "Json":
                    var saveJson = new AnimalJson(name);
                    AnimalWriter writer4 = new AnimalWriter(saveJson);
                    writer4.Save();
                    break;

                case "Xml":
                    var saveXml = new AnimalXml(name);
                    AnimalWriter writer5 = new AnimalWriter(saveXml);
                    writer5.Save();
                    break;
            }
            Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
