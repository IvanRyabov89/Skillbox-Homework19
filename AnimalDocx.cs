using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19
{
    class AnimalDocx:IAnimalSave
    {
        private string nameFile;
        public AnimalDocx(string NameFile)
        {
            this.nameFile = NameFile;
        }
        private List<IFauna> CreateDocx(List<IFauna> Animal)
        {
            return Animal;
        }
        public void SaveAnimal(List<IFauna> Animal) 
        {
            using (StreamWriter writer = new StreamWriter($"{nameFile}.docx"))
            {
                writer.WriteLine(CreateDocx(Animal));
            }
        }  
    }
}
