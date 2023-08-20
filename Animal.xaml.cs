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
using System.Collections.ObjectModel;
using System.Collections;

namespace Homework_19
{
    /// <summary>
    /// Логика взаимодействия для dd.xaml
    /// </summary>
    public partial class Animal : Window 
    {
        ObservableCollection<IFauna> list2 = new ObservableCollection<IFauna>();
        //RepositoryAnimal fauna = new RepositoryAnimal();
        public Animal()
        {
            InitializeComponent();
            ListFauna.ItemsSource = list2;
            list2.Add(FaunaFactory.GetFauna("Птицы", "Дятловые", "Дятел красноголовый", "3"));
            //List<IFauna> list = fauna.PrintRepository();
            //ObservableCollection<IFauna> list2 = new ObservableCollection<IFauna>(list as List<IFauna>);
            //ListFauna.ItemsSource= list2;
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddAnimal add = new AddAnimal(this);
            add.ShowDialog();
        }
        public void AddFauna(IFauna fauna)
        {
            list2.Add(fauna);
        }
        //public void Massiv(string[] mas)
        //{
        //    fauna.Add(FaunaFactory.GetFauna($"{mas[0]}", $"{mas[1]}", $"{mas[2]}", $"{mas[3]}"));
        //    List<IFauna> listing = fauna.PrintRepository();
        //    ObservableCollection<IFauna> list2 = new ObservableCollection<IFauna>(listing as List<IFauna>);
        //    ListFauna.ItemsSource = list2;
        //}
        //public void ReFreshAnimal()
        //{
        //    ListFauna.Items.Refresh();
        //}
        private void saveAnimal_Click(object sender, RoutedEventArgs e)
        {

            saveAnimal save = new saveAnimal();
            save.ShowDialog();
        }
        public ObservableCollection<IFauna> Fauna()
        {
            return list2;
        }
    }
}
