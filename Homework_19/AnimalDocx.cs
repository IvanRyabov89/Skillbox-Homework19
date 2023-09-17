using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using Library;

namespace Homework_19
{
    class AnimalDocx:IAnimalSave
    {
        ObservableCollection<IFauna> fauna = new ObservableCollection<IFauna>();
        Animal animal = new Animal();
        private string nameFile;
        public AnimalDocx(string NameFile)
        {
            this.nameFile = NameFile;
        }
        private ObservableCollection<IFauna> CreateDocx()
        {
            fauna= animal.Fauna();
            return fauna;
        }
        public void SaveAnimal(ObservableCollection<IFauna> fauna) 
        {
            string name = $"{nameFile}.docx";
           
            string[] massiv = new string[fauna.Count];
            int i=0 ;
            using (StreamWriter writer = new StreamWriter(name))
            {
                ObservableCollection<IFauna> list = CreateDocx();
                foreach (IFauna animal in list)
                {
                    massiv[i]= Convert.ToString(animal);
                    //writer.WriteLine(animal);
                    i++;
                }
                
            }
            File.WriteAllLines(name, massiv);
            //File.AppendAllText(name, Convert.ToString(animal));
        }  
    }
}
