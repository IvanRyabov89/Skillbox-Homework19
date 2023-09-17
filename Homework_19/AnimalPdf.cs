using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Homework_19
{
    class AnimalPdf : IAnimalSave
    {
        private string nameFile;
        public AnimalPdf(string NameFile)
        {
            this.nameFile = NameFile;
        }
        private ObservableCollection<IFauna> CreatePdf()
        {
            Animal animal = new Animal();
            ObservableCollection<IFauna> fauna = new ObservableCollection<IFauna>();
            fauna = animal.Fauna();
            return fauna;
        }
        public void SaveAnimal(ObservableCollection<IFauna> Animal)
        {
            using (StreamWriter writer = new StreamWriter($"{nameFile}.pdf"))
            {
                ObservableCollection<IFauna> list = CreatePdf();
                foreach (IFauna animal in list)
                {
                    writer.WriteLine(animal);
                }
            }
        }
    }
}
