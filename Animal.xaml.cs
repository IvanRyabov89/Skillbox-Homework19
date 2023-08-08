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
using System.Windows.Shapes;

namespace Homework_19
{
    /// <summary>
    /// Логика взаимодействия для dd.xaml
    /// </summary>
    public partial class Animal : Window
    {
        RepositoryAnimal fauna = new RepositoryAnimal();
        public Animal()
        {
            InitializeComponent();
            fauna.Add(FaunaFactory.GetFauna("Птицы", "Дятловые", "Дятел красноголовый", "3"));
            List<IFauna> list = fauna.PrintRepository();
            ListFauna.ItemsSource = list;
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void Massiv(string[] mas)
        {
            fauna.Add(FaunaFactory.GetFauna($"{mas[0]}", $"{mas[1]}", $"{mas[2]}", $"{mas[3]}"));
            List<IFauna> list = fauna.PrintRepository();
            ListFauna.ItemsSource = list;
            //Animal animal = new Animal();
            //animal.Refresh();
            ListFauna.Items.Refresh();
            
        }

       

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddAnimal add = new AddAnimal();
            add.ShowDialog();
        }

        private void saveAnimal_Click(object sender, RoutedEventArgs e)
        {
            saveAnimal save = new saveAnimal();
            save.ShowDialog();
        }
    }
}
