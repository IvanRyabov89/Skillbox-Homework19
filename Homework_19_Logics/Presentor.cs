﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections;
using Library;


namespace Homework_19_Logics
{
    public  class Presentor
    {
       //Animal animal = new Animal();
        IFauna fauna;
        IView view;
        IModel model;
        public Presentor(IView View)
        {
            //ObservableCollection<IFauna> collections = animal.Fauna();
            this.view = View;
            //model = new AddModel(collections);
            model = new AddModel();
        }

        public void Result()
        {
            model.AddFauna(fauna);

        }
    }
}
