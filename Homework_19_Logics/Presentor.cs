using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Homework_19_Logics
{
    public  class Presentor
    {
        IFauna fauna;
        IView view;
        IModel model;
        public Presentor(IView View)
        {
            ObservableCollection<IFauna> collections = Homework_19.Animal.Fauna();
            this.view = View;
            model=new AddModel(collections);
        }

        public void Result()
        {
            model.AddFauna(fauna);

        }
    }
}
