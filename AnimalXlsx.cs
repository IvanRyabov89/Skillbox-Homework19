using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19
{
    internal class AnimalXlsx
    {
        private string nameFile;
        public AnimalXlsx(string NameFile)
        {
            this.nameFile = NameFile;
        }
        private List<IFauna> CreateXlsx(List<IFauna> Animal)
        {
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
