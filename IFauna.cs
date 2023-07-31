using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19
{
    interface IFauna
    {
        /// <summary>
        /// род
        /// </summary>
        string Genus { get;set; }
        /// <summary>
        /// порода
        /// </summary>
        string Breed { get;set; }
        /// <summary>
        /// возраст
        /// </summary>
        string Age { get;set; }
        
    }
}
