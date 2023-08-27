using System;
using System.Collections.ObjectModel;

namespace Homework_19_Logic
{
    interface IModel
    {
        void GetData(string Class,string Genus,string Breed,string Age,ObservableCollection<IFauna>Animal);

    }
}
