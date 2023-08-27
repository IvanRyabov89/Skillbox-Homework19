using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19
{
    class AnimalTxt:IAnimalSave
    {
        Animal animal = new Animal();
        private string nameFile;
        public AnimalTxt(string NameFile)
        {
            this.nameFile = NameFile;
        }
        private ObservableCollection<IFauna> CreateTxt()
        {
            ObservableCollection<IFauna> fauna = new ObservableCollection<IFauna>();
            fauna = animal.Fauna();
            return fauna;
        }
        public void SaveAnimal(ObservableCollection<IFauna> fauna)
        {
            string name = $"{nameFile}.txt" ;
            using (StreamWriter writer = new StreamWriter(name))
            {
                ObservableCollection<IFauna> list = CreateTxt();
                foreach(IFauna a in list)
                {
                    writer.WriteLine(a);
                }
            }
        }
    }
}
