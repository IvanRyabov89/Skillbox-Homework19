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
        private string nameFile;
        public AnimalTxt(string NameFile)
        {
            this.nameFile = NameFile;
        }
        private ObservableCollection<IFauna> CreateTxt()
        {
            Animal animal = new Animal();
            ObservableCollection<IFauna> fauna = new ObservableCollection<IFauna>();
            fauna = animal.Fauna();
            return fauna;

        }
        public void SaveAnimal(ObservableCollection<IFauna> fauna)
        {
            string name = $"{nameFile}.txt" ;
            using (StreamWriter writer = new StreamWriter(name, false))
            {

                writer.WriteLine(CreateTxt());
            }
            //using (FileStream stream=new FileStream(name,FileMode.OpenOrCreate))
            //{
            //    stream.
            //}
        }
    }
}
