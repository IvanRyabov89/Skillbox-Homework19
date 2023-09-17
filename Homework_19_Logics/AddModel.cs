using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Homework_19_Logics
{
    public class AddModel:IModel
    {
        public  ObservableCollection<IFauna> animal;
        public AddModel()
        {
            animal = new ObservableCollection<IFauna>();
            animal.Add(FaunaFactory.GetFauna("Птицы", "Дятловые", "Дятел красноголовый", "3"));
        }

        public void AddFauna(IFauna newFauna)
        {
            animal.Add(newFauna);
        }
       public ObservableCollection<IFauna> Fauna()
       {
            return animal;
       }
    }
}
