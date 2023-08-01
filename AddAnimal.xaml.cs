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

namespace Homework_19
{
    /// <summary>
    /// Логика взаимодействия для AddAnimal.xaml
    /// </summary>
    public partial class AddAnimal : Window
    {
        RepositoryAnimal fauna = new RepositoryAnimal();
        public AddAnimal()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string NewclassParam = NewClass.Text;
            string NewGenusParam = NewGenus.Text;
            string NewBreedParam = NewBreed.Text;
            string NewAgeParam = NewAge.Text;
            MessageBox.Show($"NewclassParam={NewclassParam}{null,50} NewGenusParam={NewGenusParam}{null,50} NewBreedParam={NewBreedParam}{null,50}" +
                $" NewAgeParam={NewAgeParam}");
            fauna.Add(FaunaFactory.GetFauna($"{NewclassParam}", $"{NewGenusParam }", $"{NewBreedParam}", $"{NewAgeParam}"));
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
