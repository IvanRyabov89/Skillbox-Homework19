using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Homework_19
{
    public class AnimalJson:IAnimalSave
    {
        private string Name;
        public AnimalJson(string name)
        {
            this.Name = name;
        }

        public void SaveAnimal(ObservableCollection<IFauna> animals)
        {
            string json = JsonConvert.SerializeObject(animals);
            System.IO.File.WriteAllText($"{Name}.json", json);
        }
    }
}
