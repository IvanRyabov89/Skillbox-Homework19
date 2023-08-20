using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Shapes;
using System.Windows.Documents;
using System.Collections.ObjectModel;

namespace Homework_19
{
    class AnimalXlsx : IAnimalSave
    {
        ObservableCollection<IFauna> fauna = new ObservableCollection<IFauna>();
        private string nameFile;
        public AnimalXlsx(string NameFile)
        {
            this.nameFile = NameFile;
        }
       
        private ObservableCollection<IFauna> CreateXlsx(ObservableCollection<IFauna> Animal)
        {
            Animal animal = new Animal();
            ObservableCollection<IFauna> fauna = new ObservableCollection<IFauna>();
            fauna = animal.Fauna();
            return fauna;

            //string path = $"{nameFile}.xlsx";
            //FileStream aFile = new FileStream(path, FileMode.Create);
            //StreamWriter sw = new StreamWriter(aFile);
            //foreach (IFauna fauna in Animal)
            //{
            //    sw.WriteLine(fauna);
            //}
            //return Animal;
        }
        public void SaveAnimal(ObservableCollection<IFauna> Animal)
        {
            using (StreamWriter writer = new StreamWriter($"{nameFile}.xlsx"))
            {
                writer.WriteLine(CreateXlsx(Animal));
            }
        }
    }
}
