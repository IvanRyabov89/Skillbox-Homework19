using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_Logics
{
    public class AddModel:IModel
    {
        private ObservableCollection<IFauna> animal;
        public AddModel(ObservableCollection<IFauna> animalCollection)
        {
            animal= animalCollection;
        }
        public void AddFauna(IFauna newFauna)
        {
            animal.Add(newFauna);
        }
       
    }
}
