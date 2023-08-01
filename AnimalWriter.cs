using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19
{
    class AnimalWriter
    {
        public IAnimalSave Mode { get;set; }
        public List<IFauna> Animals { get; set; }
        public AnimalWriter(IAnimalSave Method)
        {
            this.Mode = Method;
        }
        public void Save()
        {
            Mode.SaveAnimal(Animals);
        }
    }
}
