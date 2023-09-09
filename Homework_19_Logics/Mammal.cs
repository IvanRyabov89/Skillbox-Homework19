using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_Logics
{
    /// <summary>
    /// млекопитающие
    /// </summary>
    class Mammal: IFauna
    {
        private string classing;
        private string genus;
        private string breed;
        private string age;

        public string Class
        {
            get { return classing; }
            set
            {
                classing = value;
                OnPropertyChanged("Class");
            }
        }
        public string Genus
        {
            get { return genus; }
            set
            {
                genus = value;
                OnPropertyChanged("Genus");
            }
        }
        public string Breed
        {
            get { return breed; }
            set
            {
                breed = value;
                OnPropertyChanged("Breed");
            }
        }
        public string Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
        /// <summary>
        /// млекопитающие
        /// </summary>
        /// <param name="Genus"></param>
        /// <param name="Breed"></param>
        /// <param name="Age"></param>
        public Mammal(string Genus,string Breed,string Age)
        {
            this.Class = "Млекопитающие";
            this.Genus = Genus;
            this.Breed = Breed;
            this.Age = Age;
        }
        public override string ToString()
        {
            return $"{this.Class}{this.Genus} {this.Breed}{this.Age}";
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
