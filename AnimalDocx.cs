using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Homework_19
{
    class AnimalDocx:IAnimalSave
    {
        private string nameFile;
        public AnimalDocx(string NameFile)
        {
            this.nameFile = NameFile;
        }
        private ObservableCollection<IFauna> CreateDocx()
        {
            Animal animal= new Animal();
            ObservableCollection<IFauna> fauna = new ObservableCollection<IFauna>();
            fauna= animal.Fauna();
            return fauna;
        }
        public void SaveAnimal(ObservableCollection<IFauna> fauna) 
        {
            using (StreamWriter writer = new StreamWriter($"{nameFile}.docx"))
            {
                writer.WriteLine(CreateDocx());
            }
        }  
    }
}
