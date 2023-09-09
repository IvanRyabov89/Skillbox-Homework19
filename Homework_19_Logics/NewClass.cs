using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_Logics
{
    class NewClass:IFauna
    {
        public string Class { get;set; }
        public string Genus { get;set; }
        public string Breed { get;set; }
        public string Age { get;set; }

        public NewClass()
        {
            this.Class= "Not Determined";
            this.Genus = "Not Determined";
            this.Breed = "Not Determined";
            this.Age = "Not Determined";
        }
        public override string ToString()
        {
            return $"{this.Class}{this.Genus}{this.Breed}{this.Age}";
        }
    }
}
