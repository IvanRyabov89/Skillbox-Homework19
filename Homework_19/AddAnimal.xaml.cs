using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using Homework_19_Logics;
using Library;

namespace Homework_19
{
    /// <summary>
    /// Логика взаимодействия для AddAnimal.xaml
    /// </summary>
    public partial class AddAnimal : Window
    {
        private IModel model;
        private AddModel addModel;
        private Animal parentForm;
        public AddAnimal(Animal parent,IModel model, AddModel addModels)
        {
            InitializeComponent();
            parentForm = parent;
            this.model = model;
            addModel = addModels;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string NewclassParam = NewClass.Text;
            string NewGenusParam = NewGenus.Text;
            string NewBreedParam = NewBreed.Text;
            string NewAgeParam = NewAge.Text;
            IFauna newFauna = FaunaFactory.GetFauna(NewclassParam, NewGenusParam, NewBreedParam, NewAgeParam);
            //model.AddFauna((Homework_19_Logics.IFauna)newFauna);
            addModel.AddFauna((IFauna)newFauna);
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
