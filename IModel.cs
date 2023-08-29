using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_Logics
{
    interface IModel
    {
        void GetData(string Class, string Genus, string Breed, string Age);
        ObservableCollection<IFauna> Result();
    }
}
