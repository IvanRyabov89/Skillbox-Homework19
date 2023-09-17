using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Library;

namespace Homework_19
{
    class AnimalWriter
    {
        public IAnimalSave Mode { get;set; }
        public ObservableCollection<IFauna> Animals { get; set; }
        public AnimalWriter(IAnimalSave Method)
        {
            this.Mode = Method;
        }
        public void Save()
        {
            Animal animal = new Animal();
            Animals = animal.Fauna();
            Mode.SaveAnimal(Animals);
        }
    }
}
