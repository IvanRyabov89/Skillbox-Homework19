using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19
{
    class AnimalPdf :IAnimalSave
    {
        private string nameFile;
        public AnimalPdf(string NameFile)
        {
            this.nameFile = NameFile;
        }
        private List<IFauna> CreatePdf(List<IFauna> Animal)
        {
            return Animal;
        }
        public void SaveAnimal(List<IFauna> Animal)
        {
            using (StreamWriter writer = new StreamWriter($"{nameFile}.pdf"))
            {
                writer.WriteLine(CreatePdf(Animal));
            }
        }
    }
}
