using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Shapes;
using System.Windows.Documents;

namespace Homework_19
{
    class AnimalXlsx : IAnimalSave
    {
        private string nameFile;
        public AnimalXlsx(string NameFile)
        {
            this.nameFile = NameFile;
        }
        async void Method(List<IFauna> Animal)
        {
            //string path = $"{nameFile}.xlsx";
            //using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    // преобразуем строку в байты
            //    byte[] buffer = Encoding.Default.GetBytes(Animal);
            //    // запись массива байтов в файл
            //    await fstream.WriteAsync(buffer, 0, buffer.Length);
            //    Console.WriteLine("Текст записан в файл");
            //}
        }
        private List<IFauna> CreateXlsx(List<IFauna> Animal)
        {
            //string path = $"{nameFile}.xlsx";
            //FileStream aFile = new FileStream(path, FileMode.Create);
            //StreamWriter sw = new StreamWriter(aFile);
            //foreach (IFauna fauna in Animal)
            //{

            //    sw.WriteLine(fauna);
            //}

            //Method(Animal);
            return Animal;
        }
        public void SaveAnimal(List<IFauna> Animal)
        {
            using (StreamWriter writer = new StreamWriter($"{nameFile}.xlsx"))
            {
                writer.WriteLine(CreateXlsx(Animal));
            }
        }
    }
}
