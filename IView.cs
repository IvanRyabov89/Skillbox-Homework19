﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_Logic
{
    interface IView
    {
        /// <summary>
        /// класс
        /// </summary>
        string Class { get; }
        /// <summary>
        /// род
        /// </summary>
        string Genus { get; }
        /// <summary>
        /// порода
        /// </summary>
        string Breed { get; }
        /// <summary>
        /// возраст
        /// </summary>
        string Age { get;}
        ObservableCollection<IFauna> Animal { set; }
    }
}
