using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Library;

namespace Homework_19
{
    public class AnimalXml:IAnimalSave
    {
        private string NameFile;
        
        public AnimalXml(string name)
        {
            this.NameFile = name;
        }

        public void SaveAnimal(ObservableCollection<IFauna> animals)
        {
            XElement Animals = new XElement("AnimalCollection");
            foreach (IFauna animalnow in animals)
            {
                XElement Animal = new XElement("Animal");
                XElement Class = new XElement("Class");
                Class.Add(animalnow.Class);
                XElement Genus = new XElement("Genus");
                Genus.Add(animalnow.Genus);
                XElement Breed = new XElement("Breed");
                Breed.Add(animalnow.Breed);
                XElement Age = new XElement("Age");
                Age.Add(animalnow.Age);
                Animal.Add(Class, Genus, Breed, Age);
                Animals.Add(Animal);
            }
            Animals.Save(NameFile);
        }
    }
}
