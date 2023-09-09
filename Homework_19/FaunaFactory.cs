using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19
{
    class FaunaFactory
    {
        public static IFauna GetFauna(string TypeFauna,
                             string Genus,
                             string Breed,
                             string Age)
        {
            switch (TypeFauna)
                {
                case "Млекопитающие": return new Mammal(Genus,Breed,Age);
                case "Птицы": return new Bird(Genus,Breed,Age);
                case "Земноводные": return new Amphibians(Genus, Breed, Age);
                default: return new NewClass();
                }
        }
    }
}
