﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Library;

namespace Homework_19
{
    interface IAnimalSave
    {
        void SaveAnimal(ObservableCollection<IFauna>list);
    }
}
