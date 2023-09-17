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
using Library;

namespace Homework_19
{
    class AnimalXlsx : IAnimalSave
    {
        Animal animal = new Animal();
        private string nameFile;
        public AnimalXlsx(string NameFile)
        {
            this.nameFile = NameFile;
        }
       
        private ObservableCollection<IFauna> CreateXlsx()
        {
           
            ObservableCollection<IFauna> fauna = new ObservableCollection<IFauna>();
            fauna = animal.Fauna();
            return fauna;
        }
        public void SaveAnimal(ObservableCollection<IFauna> Animal)
        {
            using (StreamWriter writer = new StreamWriter($"{nameFile}.xlsx"))
            {
                ObservableCollection<IFauna> list = CreateXlsx();
                foreach (IFauna animal in list)
                {
                    writer.WriteLine(animal);
                }
            }
        }
    }
}
