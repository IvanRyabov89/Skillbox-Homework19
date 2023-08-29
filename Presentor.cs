using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_Logics
{
    public  class Presentor
    {
        IView view;
        IModel model;
        public Presentor(IView View)
        {
            this.view = View;
            model=new AddModel();
        }
        public void Result()
        {
            model.GetData(view.Class, view.Genus, view.Breed, view.Age);
        }
    }
}
