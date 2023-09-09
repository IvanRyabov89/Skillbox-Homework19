using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_Logics
{
    public interface IFauna
    {
        /// <summary>
        /// класс
        /// </summary>
        string Class { get; set; }
        /// <summary>
        /// род
        /// </summary>
        string Genus { get; set; }
        /// <summary>
        /// порода
        /// </summary>
        string Breed { get; set; }
        /// <summary>
        /// возраст
        /// </summary>
        string Age { get; set; }

    }
}
