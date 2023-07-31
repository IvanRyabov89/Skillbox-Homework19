using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19
{
    /// <summary>
    /// млекопитающие
    /// </summary>
    class Mammal: IFauna
    {
        public string Class { get;set; }
        public string Genus { get;set; }
        public string Breed { get;set; }
        public string Age { get;set; }
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
    }
}
